namespace AwesomeEmail
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerProperties = new System.Windows.Forms.GroupBox();
            this.useSslCheckBox = new System.Windows.Forms.CheckBox();
            this.SmtpPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SmtpServer = new System.Windows.Forms.TextBox();
            this.PopPort = new System.Windows.Forms.TextBox();
            this.PopServer = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.Advanced = new System.Windows.Forms.Button();
            this.ServerProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerProperties
            // 
            this.ServerProperties.Controls.Add(this.useSslCheckBox);
            this.ServerProperties.Controls.Add(this.SmtpPort);
            this.ServerProperties.Controls.Add(this.label2);
            this.ServerProperties.Controls.Add(this.SmtpServer);
            this.ServerProperties.Controls.Add(this.PopPort);
            this.ServerProperties.Controls.Add(this.PopServer);
            this.ServerProperties.Controls.Add(this.label14);
            this.ServerProperties.Controls.Add(this.label1);
            this.ServerProperties.Controls.Add(this.label15);
            this.ServerProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerProperties.ForeColor = System.Drawing.Color.Silver;
            this.ServerProperties.Location = new System.Drawing.Point(45, 254);
            this.ServerProperties.Name = "ServerProperties";
            this.ServerProperties.Size = new System.Drawing.Size(352, 95);
            this.ServerProperties.TabIndex = 2;
            this.ServerProperties.TabStop = false;
            this.ServerProperties.Text = "Server Properties";
            this.ServerProperties.Visible = false;
            this.ServerProperties.Enter += new System.EventHandler(this.ServerProperties_Enter);
            // 
            // useSslCheckBox
            // 
            this.useSslCheckBox.AutoSize = true;
            this.useSslCheckBox.Checked = true;
            this.useSslCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useSslCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useSslCheckBox.ForeColor = System.Drawing.Color.Black;
            this.useSslCheckBox.Location = new System.Drawing.Point(272, 76);
            this.useSslCheckBox.Name = "useSslCheckBox";
            this.useSslCheckBox.Size = new System.Drawing.Size(74, 19);
            this.useSslCheckBox.TabIndex = 10;
            this.useSslCheckBox.Text = "Use SSL";
            this.useSslCheckBox.UseVisualStyleBackColor = true;
            this.useSslCheckBox.CheckedChanged += new System.EventHandler(this.useSslCheckBox_CheckedChanged);
            // 
            // SmtpPort
            // 
            this.SmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpPort.Location = new System.Drawing.Point(273, 55);
            this.SmtpPort.Name = "SmtpPort";
            this.SmtpPort.Size = new System.Drawing.Size(59, 21);
            this.SmtpPort.TabIndex = 11;
            this.SmtpPort.Text = "465";
            this.SmtpPort.TextChanged += new System.EventHandler(this.SmtpPort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(200, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Smtp Port :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // SmtpServer
            // 
            this.SmtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpServer.Location = new System.Drawing.Point(83, 55);
            this.SmtpServer.Name = "SmtpServer";
            this.SmtpServer.Size = new System.Drawing.Size(107, 21);
            this.SmtpServer.TabIndex = 10;
            this.SmtpServer.Text = "smtp.gmail.com";
            this.SmtpServer.TextChanged += new System.EventHandler(this.SmtpServer_TextChanged);
            // 
            // PopPort
            // 
            this.PopPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopPort.Location = new System.Drawing.Point(272, 18);
            this.PopPort.Name = "PopPort";
            this.PopPort.Size = new System.Drawing.Size(59, 21);
            this.PopPort.TabIndex = 3;
            this.PopPort.Text = "995";
            this.PopPort.TextChanged += new System.EventHandler(this.PopPort_TextChanged);
            // 
            // PopServer
            // 
            this.PopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopServer.Location = new System.Drawing.Point(84, 19);
            this.PopServer.Name = "PopServer";
            this.PopServer.Size = new System.Drawing.Size(106, 21);
            this.PopServer.TabIndex = 2;
            this.PopServer.Text = "pop.gmail.com";
            this.PopServer.TextChanged += new System.EventHandler(this.PopServer_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(203, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 15);
            this.label14.TabIndex = 1;
            this.label14.Text = "Pop Port :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Smtp Server :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 0;
            this.label15.Text = "Pop Server :";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // Connect
            // 
            this.Connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connect.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Connect.Location = new System.Drawing.Point(180, 165);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(87, 23);
            this.Connect.TabIndex = 8;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(132, 138);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(186, 21);
            this.LoginPassword.TabIndex = 7;
            this.LoginPassword.TextChanged += new System.EventHandler(this.LoginPassword_TextChanged);
            // 
            // LoginUserName
            // 
            this.LoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserName.Location = new System.Drawing.Point(132, 101);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(186, 21);
            this.LoginUserName.TabIndex = 6;
            this.LoginUserName.TextChanged += new System.EventHandler(this.LoginUserName_TextChanged);
            // 
            // Advanced
            // 
            this.Advanced.Location = new System.Drawing.Point(45, 225);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(75, 23);
            this.Advanced.TabIndex = 9;
            this.Advanced.Text = "Advanced";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 361);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.ServerProperties);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.LoginPassword);
            this.MaximumSize = new System.Drawing.Size(467, 400);
            this.MinimumSize = new System.Drawing.Size(467, 400);
            this.Name = "Login";
            this.Text = "Awesome Email";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ServerProperties.ResumeLayout(false);
            this.ServerProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ServerProperties;
        private System.Windows.Forms.TextBox SmtpPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SmtpServer;
        private System.Windows.Forms.TextBox PopPort;
        private System.Windows.Forms.TextBox PopServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox LoginPassword;
        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.Button Advanced;
        private System.Windows.Forms.CheckBox useSslCheckBox;
    }
}

