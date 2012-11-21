namespace AwesomeEmail
{
    partial class Loginv2
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
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
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
            this.LoginUserName = new System.Windows.Forms.TextBox();
            this.LoginPassword = new System.Windows.Forms.TextBox();
            this.Advanced = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.ServerProperties.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 458);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(402, 31);
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = global::AwesomeEmail.Properties.Resources.MailIcon;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.Advanced});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 5;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(402, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Connect";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowMinimize = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Login";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.Advanced);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Settings";
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
            this.ServerProperties.Location = new System.Drawing.Point(22, 280);
            this.ServerProperties.Name = "ServerProperties";
            this.ServerProperties.Size = new System.Drawing.Size(352, 95);
            this.ServerProperties.TabIndex = 10;
            this.ServerProperties.TabStop = false;
            this.ServerProperties.Text = "Server Properties";
            this.ServerProperties.Visible = false;
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
            // 
            // SmtpPort
            // 
            this.SmtpPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpPort.Location = new System.Drawing.Point(273, 55);
            this.SmtpPort.Name = "SmtpPort";
            this.SmtpPort.Size = new System.Drawing.Size(59, 21);
            this.SmtpPort.TabIndex = 11;
            this.SmtpPort.Text = "465";
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
            // 
            // SmtpServer
            // 
            this.SmtpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SmtpServer.Location = new System.Drawing.Point(83, 55);
            this.SmtpServer.Name = "SmtpServer";
            this.SmtpServer.Size = new System.Drawing.Size(107, 21);
            this.SmtpServer.TabIndex = 10;
            this.SmtpServer.Text = "smtp.gmail.com";
            // 
            // PopPort
            // 
            this.PopPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopPort.Location = new System.Drawing.Point(272, 18);
            this.PopPort.Name = "PopPort";
            this.PopPort.Size = new System.Drawing.Size(59, 21);
            this.PopPort.TabIndex = 3;
            this.PopPort.Text = "995";
            // 
            // PopServer
            // 
            this.PopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PopServer.Location = new System.Drawing.Point(84, 19);
            this.PopServer.Name = "PopServer";
            this.PopServer.Size = new System.Drawing.Size(106, 21);
            this.PopServer.TabIndex = 2;
            this.PopServer.Text = "pop.gmail.com";
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
            // 
            // LoginUserName
            // 
            this.LoginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserName.Location = new System.Drawing.Point(106, 194);
            this.LoginUserName.Name = "LoginUserName";
            this.LoginUserName.Size = new System.Drawing.Size(186, 21);
            this.LoginUserName.TabIndex = 11;
            // 
            // LoginPassword
            // 
            this.LoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPassword.Location = new System.Drawing.Point(106, 231);
            this.LoginPassword.Name = "LoginPassword";
            this.LoginPassword.PasswordChar = '*';
            this.LoginPassword.Size = new System.Drawing.Size(186, 21);
            this.LoginPassword.TabIndex = 12;
            // 
            // Advanced
            // 
            this.Advanced.Caption = "Advanced";
            this.Advanced.Id = 4;
            this.Advanced.Name = "Advanced";
            this.Advanced.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Advanced_ItemClick);
            // 
            // Loginv2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 489);
            this.Controls.Add(this.ServerProperties);
            this.Controls.Add(this.LoginUserName);
            this.Controls.Add(this.LoginPassword);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Loginv2";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "RibbonForm1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ServerProperties.ResumeLayout(false);
            this.ServerProperties.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private System.Windows.Forms.GroupBox ServerProperties;
        private System.Windows.Forms.CheckBox useSslCheckBox;
        private System.Windows.Forms.TextBox SmtpPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SmtpServer;
        private System.Windows.Forms.TextBox PopPort;
        private System.Windows.Forms.TextBox PopServer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox LoginUserName;
        private System.Windows.Forms.TextBox LoginPassword;
        private DevExpress.XtraBars.BarButtonItem Advanced;
    }
}