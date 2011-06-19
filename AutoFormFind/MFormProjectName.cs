using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Integro.InMeta.Runtime;

namespace AutoFormFind
{
    public partial class MFormProjectName : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Проект приложения
        /// </summary>
        private DataApplication dApp;
        /// <summary>
        /// Сессия приложения
        /// </summary>
        public DataSession dSess;
        private ApplicationInMeta AppInMeta;
        public MFormProjectName(string HostAddr)
        {
            InitializeComponent();
            try
            {
                AppInMeta = new ApplicationInMeta(HostAddr);
                cboProject.Properties.Items.AddRange(AppInMeta.GetApplication());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возможно среда ИнМета не установлена!!!\n\nТекст ошибки...\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Application.DoEvents();
            dApp = new DataApplication((string)cboProject.SelectedItem, AppInMeta.Name);
            dSess = dApp.CreateSession();
            bt_OK.Enabled = true;

        }

    }
}