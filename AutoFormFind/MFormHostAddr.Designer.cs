namespace AutoFormFind
{
    partial class MFormHostAddr
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
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.sb_OK = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Cansel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.EditValue = "localhost";
            this.textEdit1.Location = new System.Drawing.Point(11, 31);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(214, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // sb_OK
            // 
            this.sb_OK.Location = new System.Drawing.Point(11, 70);
            this.sb_OK.Name = "sb_OK";
            this.sb_OK.Size = new System.Drawing.Size(92, 23);
            this.sb_OK.TabIndex = 1;
            this.sb_OK.Text = "OK";
            this.sb_OK.Click += new System.EventHandler(this.sb_OK_Click);
            // 
            // sb_Cansel
            // 
            this.sb_Cansel.Location = new System.Drawing.Point(134, 70);
            this.sb_Cansel.Name = "sb_Cansel";
            this.sb_Cansel.Size = new System.Drawing.Size(91, 23);
            this.sb_Cansel.TabIndex = 2;
            this.sb_Cansel.Text = "Отмена";
            this.sb_Cansel.Click += new System.EventHandler(this.sb_Cansel_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(213, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Введите адрес сервера проектов ИнМета";
            // 
            // MFormHostAddr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 103);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.sb_Cansel);
            this.Controls.Add(this.sb_OK);
            this.Controls.Add(this.textEdit1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MFormHostAddr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Адрес сервера...";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton sb_OK;
        private DevExpress.XtraEditors.SimpleButton sb_Cansel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}