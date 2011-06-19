using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace AutoFormFind
{
    public partial class MFormSettingsString : DevExpress.XtraEditors.XtraForm
    {
        private List<object> items = new List<object>();
        private ItemsList itemList;

        public MFormSettingsString()
        {
            InitializeComponent();
            itemList.Name = "Все";
            itemList.Value = "-1";
            itemList.Select = true;
            items.Add(itemList);
            listItems.Items.Add(itemList.Name);
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (txtIn.Text.Trim() != string.Empty & txtValue.Text.Trim() != string.Empty)
            {
                itemList.Name = txtIn.Text.Trim();
                itemList.Value = txtValue.Text.Trim();
                itemList.Select = false;
                items.Add(itemList);
                listItems.Items.Add(itemList.Name);
                txtIn.Text = string.Empty;
                txtValue.Text = string.Empty;
            }
            txtIn.Focus();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            MFormSettings.instance.items = items;
            this.Close();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            listItems.Items.Clear();
            items.Clear();
            itemList.Name = "Все";
            itemList.Value = "0000";
            itemList.Select = true;
            items.Add(itemList);
            listItems.Items.Add(itemList.Name);
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            listItems.Items.Clear();
            items.Clear();
            this.Close();
        }



    }
}