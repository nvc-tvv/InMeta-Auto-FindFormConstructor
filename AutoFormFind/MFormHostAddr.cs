using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AutoFormFind
{
    public partial class MFormHostAddr : DevExpress.XtraEditors.XtraForm
    {
        public string hostAddr;
        public MFormHostAddr()
        {
            InitializeComponent();
        }

        private void sb_OK_Click(object sender, EventArgs e)
        {
            hostAddr = textEdit1.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void sb_Cansel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}