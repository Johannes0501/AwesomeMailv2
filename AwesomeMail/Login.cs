using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AwesomeEmail.Properties;

namespace AwesomeEmail
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            LoginUserName.Text = Settings.Default["LoginUser"].ToString();
            LoginPassword.Text = Settings.Default["LoginPw"].ToString();
            PopServer.Text = Settings.Default["PopServer"].ToString();
            PopPort.Text = Settings.Default["PopPort"].ToString();

        }

        // advanced buttom options click
        public void Advanced_Click(object sender, EventArgs e)
        {
            if (ServerProperties.Visible == false)
            {
                ServerProperties.Visible = true;
            }
            else
            {
                ServerProperties.Visible = false;
            }
        }

        //connect 
        public void Connect_Click(object sender, EventArgs e)
        {

            if (this.CheckInputValidationForLogin(this.PopServer.Text, this.PopPort.Text, this.LoginUserName.Text, this.LoginPassword.Text))
            {
                //saving settings
                Settings.Default["LoginUser"] = LoginUserName.Text;
                Settings.Default["LoginPw"] = LoginPassword.Text;
                Settings.Default["PopServer"] = PopServer.Text;
                Settings.Default["PopPort"] = PopPort.Text;
                Settings.Default["UsSsl"] = useSslCheckBox.Checked;
                Settings.Default.Save();

                // Opening client program and closing Login
                System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(Clientopen));
                t.SetApartmentState(ApartmentState.STA);
                t.Start();

                this.Close();

            }

        }
        // Open client Application
        public static void Clientopen()
        {
            Application.Run(new Client());

        }

        private bool CheckInputValidationForLogin(string PopServer, string PopPort, string LoginUserName, string LoingPassword)
        {
            if (PopServer.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop server address.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (PopPort.Equals(""))
            {
                MessageBox.Show(this, "You must provide pop port number.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (LoginUserName.Equals(""))
            {
                MessageBox.Show(this, "You must provide username(Email).", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (LoginPassword.Equals(""))
            {
                MessageBox.Show(this, "You must provide password.", "Email Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void useSslCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void SmtpPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void SmtpServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void LoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServerProperties_Enter(object sender, EventArgs e)
        {

        }


    }
}
