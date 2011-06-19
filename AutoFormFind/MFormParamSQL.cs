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
    public partial class MFormParamSQL : DevExpress.XtraEditors.XtraForm
    {
        public MFormParamSQL(string param)
        {
            InitializeComponent();
            memoEdit1.Text = param;
        }
    }
}