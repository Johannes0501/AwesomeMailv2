using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using AwesomeEmail.Properties;
using System.Net.Mail;
using System.Net;

namespace AwesomeEmail
{
    public partial class SendMail : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void Send_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                SendMailgo();
                //lblMsgSend.Text = "Your Comments after sending the mail";
                Subject.Text = "";
                To.Text = "";
               // From.Text = Properties.Settings.Default.LoginUser;
                MailMessage.Text = "";
                MessageBox.Show("mail Send");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        protected void SendMailgo()
        {
            var fromAddress = (Settings.Default.LoginUser);// Gmail Address from where you send the mail
            var toAddress = To.Text.ToString();
            string fromPassword = (Settings.Default.LoginPw);//Password of your gmail address
            string subject = Subject.Text.ToString();
            string body = "Subject: " + Subject.Text + "\n";                 
            body += "Question: \n" + MailMessage.Text + "\n";
            var smtp = new System.Net.Mail.SmtpClient();
            {
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(fromAddress, fromPassword);
                smtp.Timeout = 20000;
            }
            smtp.Send(fromAddress, toAddress, subject, body);
        }
    }
}