using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using System.Net.Mail;
using OpenPop.Pop3;
using OpenPop.Mime;
using OpenPop.Mime.Header;
using OpenPop.Common.Logging;
using Message = OpenPop.Mime.Message;
using AwesomeEmail.Pop3.Exceptions;
using AwesomeEmail.Properties;
using System.Threading;


namespace AwesomeEmail
{
    public partial class Client : RibbonForm
    {
        private readonly Dictionary<int, Message> messages = new Dictionary<int, Message>();
        public Client()
        {
            InitializeComponent();
            InitSkinGallery();

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void iNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            ReceiveMails();
        }

        //ReciveMails
        private void ReceiveMails()
        {
            // Disable buttons while working
            progressBar.Value = 0;
            Pop3Client pop3Client;

            try
            {
                pop3Client = new Pop3Client();
                pop3Client.Connect(Settings.Default.PopServer, int.Parse(Settings.Default.PopPort), (Settings.Default.UsSsl));
                pop3Client.Authenticate(Settings.Default.LoginUser, Settings.Default.LoginPw);
                int count = pop3Client.GetMessageCount();
                totalMessagesTextBox.Text = count.ToString();
                messageTextBox.Text = "";
                messages.Clear();
                listMessages.Nodes.Clear();
                listAttachments.Nodes.Clear();
                int success = 0;
                int fail = 0;
                for (int i = count; i >= 1; i -= 1)
                {
                    // Check if the form is closed while we are working. If so, abort
                    if (IsDisposed)
                        return;

                    // Refresh the form while fetching emails
                    // This will fix the "Application is not responding" problem
                    Application.DoEvents();
                    try
                    {
                        Message message = pop3Client.GetMessage(i);

                        // Add the message to the dictionary from the messageNumber to the Message
                        messages.Add(i, message);

                        // Create a TreeNode tree that mimics the Message hierarchy
                        TreeNode node = new TreeNodeBuilder().VisitMessage(message);

                        // Set the Tag property to the messageNumber
                        // We can use this to find the Message again later
                        node.Tag = i;

                        // Show the built node in our list of messages
                        listMessages.Nodes.Add(node);

                        success++;
                    }
                    catch (Exception e)
                    {
                        DefaultLogger.Log.LogError(
                            "TestForm: Message fetching failed: " + e.Message + "\r\n" +
                            "Stack trace:\r\n" +
                            e.StackTrace);
                        fail++;
                    }

                    progressBar.Value = (int)(((double)(count - i) / count) * 100);
                }

                MessageBox.Show(this, "Mail received!\nSuccesses: " + success + "\nFailed: " + fail, "Message fetching done");

                if (fail > 0)
                {
                    MessageBox.Show(this,
                                    "Since some of the emails were not parsed correctly (exceptions were thrown)\r\n" +
                                    "please consider sending your log file to the developer for fixing.\r\n" +
                                    "If you are able to include any extra information, please do so.",
                                    "Help improve OpenPop!");
                }
            }
            catch (InvalidLoginException)
            {
                MessageBox.Show(this, "The server did not accept the user credentials!", "POP3 Server Authentication");
            }
            catch (PopServerNotFoundException)
            {
                MessageBox.Show(this, "The server could not be found", "POP3 Retrieval");
            }
            catch (PopServerLockedException)
            {
                MessageBox.Show(this, "The mailbox is locked. It might be in use or under maintenance. Are you connected elsewhere?", "POP3 Account Locked");
            }
            catch (LoginDelayException)
            {
                MessageBox.Show(this, "Login not allowed. Server enforces delay between logins. Have you connected recently?", "POP3 Account Login Delay");
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Error occurred retrieving mail. " + e.Message, "POP3 Retrieval");
            }
            finally
            {
                // Enable the buttons again
                progressBar.Value = 100;
            }
        }

        //List Messages on click
        private void listMessages_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Fetch out the selected message
            Message message = messages[GetMessageNumberFromSelectedNode(listMessages.SelectedNode)];

            // If the selected node contains a MessagePart and we can display the contents - display them
            if (listMessages.SelectedNode.Tag is MessagePart)
            {
                MessagePart selectedMessagePart = (MessagePart)listMessages.SelectedNode.Tag;
                if (selectedMessagePart.IsText)
                {
                    // We can show text MessageParts
                    messageTextBox.Text = selectedMessagePart.GetBodyAsText();
                }
                else
                {
                    // We are not able to show non-text MessageParts (MultiPart messages, images, pdf's ...)
                    messageTextBox.Text = "<<OpenPop>> Cannot show this part of the email. It is not text <<OpenPop>>";
                }
            }
            else
            {
                // If the selected node is not a subnode and therefore does not
                // have a MessagePart in it's Tag property, we genericly find some content to show

                // Find the first text/plain version
                MessagePart plainTextPart = message.FindFirstPlainTextVersion();
                if (plainTextPart != null)
                {
                    // The message had a text/plain version - show that one
                    messageTextBox.Text = plainTextPart.GetBodyAsText();
                }
                else
                {
                    // Try to find a body to show in some of the other text versions
                    List<MessagePart> textVersions = message.FindAllTextVersions();
                    if (textVersions.Count >= 1)
                        messageTextBox.Text = textVersions[0].GetBodyAsText();
                    else
                        messageTextBox.Text = "<<OpenPop>> Cannot find a text version body in this message to show <<OpenPop>>";
                }
            }

            // Clear the attachment list from any previus shown attachments
            listAttachments.Nodes.Clear();

            // Build up the attachment list
            List<MessagePart> attachments = message.FindAllAttachments();
            foreach (MessagePart attachment in attachments)
            {
                // Add the attachment to the list of attachments
                TreeNode addedNode = listAttachments.Nodes.Add((attachment.FileName));

                // Keep a reference to the attachment in the Tag property
                addedNode.Tag = attachment;
            }

            // Only show that attachmentPanel if there is attachments in the message
            bool hadAttachments = attachments.Count > 0;
            attachmentPanel.Visible = hadAttachments;

            // Generate header table
            DataSet dataSet = new DataSet();
            DataTable table = dataSet.Tables.Add("Headers");
            table.Columns.Add("Header");
            table.Columns.Add("Value");

            DataRowCollection rows = table.Rows;

            // Add all known headers
            rows.Add(new object[] { "Content-Description", message.Headers.ContentDescription });
            rows.Add(new object[] { "Content-Id", message.Headers.ContentId });
            foreach (string keyword in message.Headers.Keywords) rows.Add(new object[] { "Keyword", keyword });
            foreach (RfcMailAddress dispositionNotificationTo in message.Headers.DispositionNotificationTo) rows.Add(new object[] { "Disposition-Notification-To", dispositionNotificationTo });
            foreach (Received received in message.Headers.Received) rows.Add(new object[] { "Received", received.Raw });
            rows.Add(new object[] { "Importance", message.Headers.Importance });
            rows.Add(new object[] { "Content-Transfer-Encoding", message.Headers.ContentTransferEncoding });
            foreach (RfcMailAddress cc in message.Headers.Cc) rows.Add(new object[] { "Cc", cc });
            foreach (RfcMailAddress bcc in message.Headers.Bcc) rows.Add(new object[] { "Bcc", bcc });
            foreach (RfcMailAddress to in message.Headers.To) rows.Add(new object[] { "To", to });
            rows.Add(new object[] { "From", message.Headers.From });
            rows.Add(new object[] { "Reply-To", message.Headers.ReplyTo });
            foreach (string inReplyTo in message.Headers.InReplyTo) rows.Add(new object[] { "In-Reply-To", inReplyTo });
            foreach (string reference in message.Headers.References) rows.Add(new object[] { "References", reference });
            rows.Add(new object[] { "Sender", message.Headers.Sender });
            rows.Add(new object[] { "Content-Type", message.Headers.ContentType });
            rows.Add(new object[] { "Content-Disposition", message.Headers.ContentDisposition });
            rows.Add(new object[] { "Date", message.Headers.Date });
            rows.Add(new object[] { "Date", message.Headers.DateSent });
            rows.Add(new object[] { "Message-Id", message.Headers.MessageId });
            rows.Add(new object[] { "Mime-Version", message.Headers.MimeVersion });
            rows.Add(new object[] { "Return-Path", message.Headers.ReturnPath });
            rows.Add(new object[] { "Subject", message.Headers.Subject });

            // Add all unknown headers
            foreach (string key in message.Headers.UnknownHeaders)
            {
                string[] values = message.Headers.UnknownHeaders.GetValues(key);
                if (values != null)
                    foreach (string value in values)
                    {
                        rows.Add(new object[] { key, value });
                    }
            }
        }
        private static int GetMessageNumberFromSelectedNode(TreeNode node)
        {
            if (node == null)
                throw new ArgumentNullException("node");

            // Check if we are at the root, by seeing if it has the Tag property set to an int
            if (node.Tag is int)
            {
                return (int)node.Tag;
            }

            // Otherwise we are not at the root, move up the tree
            return GetMessageNumberFromSelectedNode(node.Parent);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(NewMail));
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }
        // Open New Mail from
        public static void NewMail()
        {
            Application.Run(new SendMail());
        }
    }
}