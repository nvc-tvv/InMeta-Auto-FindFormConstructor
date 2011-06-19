using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Integro.InMeta.Runtime;

namespace AutoFormFind
{
    public partial class MFormSettings : DevExpress.XtraEditors.XtraForm
    {
        private Int32 Id;
        private Int32 IdClass;
        private String NameTable;
        private String NameDataType;
        public List<object> items;
        public static MFormSettings instance;
        private DataSession session;
        private bool usl = false;
        private String NameClass;
        private String NameProp;
        private bool isAssoc = false;
        public MFormSettings(DataSession session, string NameClass, string NameProperty, int IdProp, int IdClass)
        {
            this.Id = IdProp;
            this.IdClass = IdClass;
            this.session = session;
            this.NameTable = session[NameClass].Class.DataTable;
            if (NameProperty.IndexOf("-") == -1)
                this.NameProp = NameProperty;
            else
                this.NameProp = NameProperty.Substring(0, NameProperty.IndexOf("-"));

            this.NameClass = NameClass;
            this.NameDataType = session[NameClass].Class.AllProperties.Need(this.NameProp).DataTypeName;
            MFormSettings.instance = this;

            InitializeComponent();

            this.txtCaption.Text = session[NameClass].Class.AllProperties.Need(this.NameProp).Caption;
            this.txtName.Text = NameProperty;
            this.txtClass.Text = NameClass;
            this.txtTypeProperty.Text = NameDataType;

            if (session[NameClass].Class.AllProperties.Need(NameProp).IsAssociation)
            {
                chMultiselekt.Visible = true;
                labelControl2.Visible = false;
                for (int i = 0; i < rButtonsSettings.Properties.Items.Count; i++)
                    rButtonsSettings.Properties.Items[i].Enabled = false;
                checkFirst.Enabled = false;
                this.txtTypeProperty.Text = "string";
                isAssoc = true;
            }
            if (NameDataType == "string" || NameDataType == "text")
            {
                checkFirst.Enabled = true;
                rButtonsSettings.SelectedIndex = 0;
                for (int i = 2; i < rButtonsSettings.Properties.Items.Count; i++)
                    rButtonsSettings.Properties.Items[i].Enabled = false;
            }
            if (NameDataType == "boolean")
            {
                labelControl2.Visible = false;
                for (int i = 0; i < rButtonsSettings.Properties.Items.Count; i++)
                    rButtonsSettings.Properties.Items[i].Enabled = false;
            }
            if (session[NameClass].Class.AllProperties.Need(this.NameProp).LookupValues.Count > 0)
            {
                usl = true;
                rButtonsSettings.SelectedIndex = 0;
                labelControl2.Visible = false;
                for (int i = 0; i < rButtonsSettings.Properties.Items.Count; i++)
                    rButtonsSettings.Properties.Items[i].Enabled = false;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (items != null && items.Count != 0) usl = true;
            MFormMain.instance.objControlsHtml.Add(new CreateControlsProperty(session, txtClass.Text.Trim(), txtName.Text.Trim(),
                txtCaption.Text.Trim(), Id, IdClass, items, new bool[] { 
                                                                    checkFirst.Checked,                                      //0 - Точный поиск
                                                                    rButtonsSettings.SelectedIndex.Equals(0) ? true: false,  //1 - ==
                                                                    rButtonsSettings.SelectedIndex.Equals(1) ? true: false,  //2 - !=
                                                                    rButtonsSettings.SelectedIndex.Equals(2) ? true: false,  //3 - <
                                                                    rButtonsSettings.SelectedIndex.Equals(3) ? true: false,  //4 - <=
                                                                    rButtonsSettings.SelectedIndex.Equals(4) ? true: false,  //5 - >
                                                                    rButtonsSettings.SelectedIndex.Equals(5) ? true: false,  //6 - >=
                                                                    rButtonsSettings.SelectedIndex.Equals(6) ? true: false,  //7 - В диапозоне
                                                                    usl,                                                     //8 - св-во с предопр. знач.
                                                                    isAssoc,                                                 //9 - св-во - ассоциация
                                                                    chMultiselekt.Checked                                    //10 - мультиселект
                                                              }));
            this.Close();
        }

        private void rButtonsSettings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rButtonsSettings.SelectedIndex == 6)
            {
                labelControl2.Visible = false;
            }
            else
            {
                labelControl2.Visible = true;
            }
        }


        private void labelControl2_Click(object sender, EventArgs e)
        {
            if (session[this.NameClass].Class.AllProperties.Need(this.NameProp).LookupValues.Count != 0)
            {
                MessageBox.Show("Данное свойство уже содержит предопределенные значения!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form f_setString = new MFormSettingsString();
                f_setString.ShowDialog();
            }
        }

        private void checkFirst_CheckedChanged(object sender, EventArgs e)
        {
            //if (checkFirst.Checked)
            //{
            //    rButtonsSettings.SelectedIndex = 0;
            //    for (int i = 0; i < rButtonsSettings.Properties.Items.Count; i++)
            //        rButtonsSettings.Properties.Items[i].Enabled = false;
            //}
            //else
            //    if (NameDataType == "string" || NameDataType == "text")
            //    {
            //        rButtonsSettings.SelectedIndex = 0;
            //        rButtonsSettings.Properties.Items[0].Enabled = true;
            //        rButtonsSettings.Properties.Items[1].Enabled = true;
            //    }
        }
    }
}