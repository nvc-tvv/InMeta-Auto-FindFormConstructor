namespace AutoFormFind
{
    partial class MFormSettingsString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFormSettingsString));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupItems = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btClear = new DevExpress.XtraEditors.SimpleButton();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.txtIn = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            this.listItems = new DevExpress.XtraEditors.ListBoxControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.btCansel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1.SuspendLayout();
            this.groupItems.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupItems);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 272);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // groupItems
            // 
            this.groupItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupItems.Controls.Add(this.tableLayoutPanel2);
            this.groupItems.Controls.Add(this.listItems);
            this.groupItems.Location = new System.Drawing.Point(3, 6);
            this.groupItems.Name = "groupItems";
            this.groupItems.Size = new System.Drawing.Size(318, 260);
            this.groupItems.TabIndex = 15;
            this.groupItems.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btClear, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.txtValue, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtIn, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelControl2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btAdd, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.labelControl3, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(143, 17);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(172, 240);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // btClear
            // 
            this.btClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClear.Location = new System.Drawing.Point(3, 211);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(166, 26);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Отчистить список";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // txtValue
            // 
            this.txtValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtValue.Location = new System.Drawing.Point(3, 66);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(166, 20);
            this.txtValue.TabIndex = 4;
            // 
            // txtIn
            // 
            this.txtIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIn.Location = new System.Drawing.Point(3, 22);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(166, 20);
            this.txtIn.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Текст";
            // 
            // labelControl2
            // 
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Значение";
            // 
            // btAdd
            // 
            this.btAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btAdd.Location = new System.Drawing.Point(3, 180);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(166, 25);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Добавить";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // listItems
            // 
            this.listItems.Dock = System.Windows.Forms.DockStyle.Left;
            this.listItems.Location = new System.Drawing.Point(3, 17);
            this.listItems.Name = "listItems";
            this.listItems.Size = new System.Drawing.Size(140, 240);
            this.listItems.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.78261F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.6087F));
            this.tableLayoutPanel1.Controls.Add(this.btOK, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btCansel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 275);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(324, 30);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // btOK
            // 
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOK.Location = new System.Drawing.Point(108, 3);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(106, 24);
            this.btOK.TabIndex = 5;
            this.btOK.Text = "ОК";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCansel
            // 
            this.btCansel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCansel.Location = new System.Drawing.Point(220, 3);
            this.btCansel.Name = "btCansel";
            this.btCansel.Size = new System.Drawing.Size(101, 24);
            this.btCansel.TabIndex = 6;
            this.btCansel.Text = "Отмена";
            this.btCansel.Click += new System.EventHandler(this.btCansel_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 114);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 52);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Внимание! Значение \r\nпредопределенных значений \r\nдолжно совпадать по типу с\r\nтипо" +
                "м данных свойства";
            // 
            // MFormSettingsString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(324, 305);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MFormSettingsString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка свойства...";
            this.groupBox1.ResumeLayout(false);
            this.groupItems.ResumeLayout(false);
            this.groupItems.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listItems)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.TextEdit txtIn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ListBoxControl listItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.SimpleButton btClear;
        private DevExpress.XtraEditors.SimpleButton btAdd;
        private DevExpress.XtraEditors.SimpleButton btCansel;
        private DevExpress.XtraEditors.LabelControl labelControl3;


    }
}