namespace AutoFormFind
{
    partial class MFormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFormSettings));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTypeProperty = new DevExpress.XtraEditors.TextEdit();
            this.rButtonsSettings = new DevExpress.XtraEditors.RadioGroup();
            this.checkFirst = new DevExpress.XtraEditors.CheckEdit();
            this.txtClass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtCaption = new DevExpress.XtraEditors.TextEdit();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            this.chMultiselekt = new DevExpress.XtraEditors.CheckEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeProperty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rButtonsSettings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFirst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMultiselekt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(212, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Заголовок  в форме:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.txtTypeProperty);
            this.groupBox1.Controls.Add(this.rButtonsSettings);
            this.groupBox1.Controls.Add(this.checkFirst);
            this.groupBox1.Controls.Add(this.txtClass);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.txtCaption);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 226);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelControl2.Location = new System.Drawing.Point(173, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(233, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Создать список предопределенных значений";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // txtTypeProperty
            // 
            this.txtTypeProperty.Location = new System.Drawing.Point(213, 90);
            this.txtTypeProperty.Name = "txtTypeProperty";
            this.txtTypeProperty.Properties.ReadOnly = true;
            this.txtTypeProperty.Size = new System.Drawing.Size(199, 20);
            this.txtTypeProperty.TabIndex = 24;
            // 
            // rButtonsSettings
            // 
            this.rButtonsSettings.Location = new System.Drawing.Point(2, 139);
            this.rButtonsSettings.Name = "rButtonsSettings";
            this.rButtonsSettings.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Равно"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Не равно"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Меньше"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Меньше или равно"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Больше"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Больше или равно"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Лежит в диапазоне")});
            this.rButtonsSettings.Size = new System.Drawing.Size(413, 84);
            this.rButtonsSettings.TabIndex = 23;
            this.rButtonsSettings.SelectedIndexChanged += new System.EventHandler(this.rButtonsSettings_SelectedIndexChanged);
            // 
            // checkFirst
            // 
            this.checkFirst.Enabled = false;
            this.checkFirst.Location = new System.Drawing.Point(3, 114);
            this.checkFirst.Name = "checkFirst";
            this.checkFirst.Properties.Caption = "точный/по включению";
            this.checkFirst.Size = new System.Drawing.Size(164, 19);
            this.checkFirst.TabIndex = 22;
            this.checkFirst.CheckedChanged += new System.EventHandler(this.checkFirst_CheckedChanged);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(5, 44);
            this.txtClass.Name = "txtClass";
            this.txtClass.Properties.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(201, 20);
            this.txtClass.TabIndex = 11;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl5.LineLocation = DevExpress.XtraEditors.LineLocation.Right;
            this.labelControl5.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Vertical;
            this.labelControl5.Location = new System.Drawing.Point(5, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(201, 26);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Имя класса к которому относится данное свойство";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(213, 71);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(129, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Тип данного свойства";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 90);
            this.txtName.Name = "txtName";
            this.txtName.Properties.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(23, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Имя";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(212, 44);
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(200, 20);
            this.txtCaption.TabIndex = 1;
            // 
            // btCancel
            // 
            this.btCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCancel.Location = new System.Drawing.Point(306, 251);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 23);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "Отмена";
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btOK
            // 
            this.btOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOK.Location = new System.Drawing.Point(194, 251);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 23);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "ОК";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // chMultiselekt
            // 
            this.chMultiselekt.Dock = System.Windows.Forms.DockStyle.Top;
            this.chMultiselekt.Location = new System.Drawing.Point(0, 226);
            this.chMultiselekt.Name = "chMultiselekt";
            this.chMultiselekt.Properties.Caption = "Мультиселект";
            this.chMultiselekt.Size = new System.Drawing.Size(418, 19);
            this.chMultiselekt.TabIndex = 4;
            this.chMultiselekt.Visible = false;
            // 
            // MFormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 280);
            this.ControlBox = false;
            this.Controls.Add(this.chMultiselekt);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MFormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки свойства...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeProperty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rButtonsSettings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFirst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCaption.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chMultiselekt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtCaption;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtClass;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.CheckEdit checkFirst;
        private DevExpress.XtraEditors.CheckEdit chMultiselekt;
        private DevExpress.XtraEditors.RadioGroup rButtonsSettings;
        private DevExpress.XtraEditors.TextEdit txtTypeProperty;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}