using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace AwesomeEmail
{
    public partial class Loginv2 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Loginv2()
        {
            InitializeComponent();
        }

        private void Advanced_ItemClick(object sender, ItemClickEventArgs e)
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
    }
}