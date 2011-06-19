using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Collections;
using Integro.InMeta.Runtime;

namespace AutoFormFind
{
    public partial class MFormCreateSQL : DevExpress.XtraEditors.XtraForm
    {
        public MFormCreateSQL(List<string> svjazi, string sql_sel, string sql_from, string sqlUsl)
        {
            InitializeComponent();
            txtSQL.Text = sql_sel + "\r\n" + sql_from + "\r\n";
            for (int i = 0; i <  svjazi.Count; i++)
            {
                txtSQL.Text += svjazi[i] + "\r\n";
            }
            txtSQL.Text += sqlUsl;
        }
    }
}