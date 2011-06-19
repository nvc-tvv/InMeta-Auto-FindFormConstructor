namespace AutoFormFind
{
    partial class MFormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MFormMain));
            this.barManagerMain = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.treeListMain = new DevExpress.XtraTreeList.TreeList();
            this.columnsClass = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnsNameProperty = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.columnsInfo = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.image = new System.Windows.Forms.ImageList(this.components);
            this.splitterControl2 = new DevExpress.XtraEditors.SplitterControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFindClass = new DevExpress.XtraEditors.TextEdit();
            this.listClasses = new DevExpress.XtraEditors.ListBoxControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.contMenuListProperty = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.checkListProperty = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.panelButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btSQL = new DevExpress.XtraEditors.SimpleButton();
            this.btCreateForms = new DevExpress.XtraEditors.SimpleButton();
            this.btSettings = new DevExpress.XtraEditors.SimpleButton();
            this.btClear = new DevExpress.XtraEditors.SimpleButton();
            this.btOpenHTML = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.webBrowserView = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFindClass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClasses)).BeginInit();
            this.contMenuListProperty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkListProperty)).BeginInit();
            this.panelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManagerMain
            // 
            this.barManagerMain.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManagerMain.DockControls.Add(this.barDockControlTop);
            this.barManagerMain.DockControls.Add(this.barDockControlBottom);
            this.barManagerMain.DockControls.Add(this.barDockControlLeft);
            this.barManagerMain.DockControls.Add(this.barDockControlRight);
            this.barManagerMain.Form = this;
            this.barManagerMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barButtonItem1});
            this.barManagerMain.MainMenu = this.bar2;
            this.barManagerMain.MaxItemId = 11;
            this.barManagerMain.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Файл";
            this.barSubItem1.Id = 5;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Выход";
            this.barButtonItem1.Id = 6;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.treeListMain);
            this.groupControl1.Controls.Add(this.splitterControl2);
            this.groupControl1.Controls.Add(this.tableLayoutPanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 24);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(345, 519);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Структура классов";
            // 
            // treeListMain
            // 
            this.treeListMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.columnsClass,
            this.columnsNameProperty,
            this.columnsInfo});
            this.treeListMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeListMain.Location = new System.Drawing.Point(2, 139);
            this.treeListMain.Name = "treeListMain";
            this.treeListMain.OptionsBehavior.AutoFocusNewNode = true;
            this.treeListMain.OptionsBehavior.Editable = false;
            this.treeListMain.OptionsMenu.EnableColumnMenu = false;
            this.treeListMain.OptionsMenu.EnableFooterMenu = false;
            this.treeListMain.OptionsSelection.InvertSelection = true;
            this.treeListMain.OptionsView.ShowVertLines = false;
            this.treeListMain.SelectImageList = this.image;
            this.treeListMain.Size = new System.Drawing.Size(341, 378);
            this.treeListMain.TabIndex = 3;
            this.treeListMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeListMain_MouseDown);
            this.treeListMain.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.treeListMain_CustomDrawNodeCell);
            this.treeListMain.AfterFocusNode += new DevExpress.XtraTreeList.NodeEventHandler(this.treeListMain_AfterFocusNode);
            this.treeListMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeListMain_MouseDoubleClick);
            // 
            // columnsClass
            // 
            this.columnsClass.Caption = "Метаданные";
            this.columnsClass.FieldName = "columnsNode";
            this.columnsClass.MinWidth = 35;
            this.columnsClass.Name = "columnsClass";
            this.columnsClass.OptionsColumn.AllowSort = false;
            this.columnsClass.Visible = true;
            this.columnsClass.VisibleIndex = 0;
            // 
            // columnsNameProperty
            // 
            this.columnsNameProperty.Caption = "Name Inglish";
            this.columnsNameProperty.FieldName = "columnsNameProperty";
            this.columnsNameProperty.Name = "columnsNameProperty";
            this.columnsNameProperty.OptionsColumn.AllowSort = false;
            this.columnsNameProperty.Visible = true;
            this.columnsNameProperty.VisibleIndex = 1;
            // 
            // columnsInfo
            // 
            this.columnsInfo.Caption = "treeListColumn1";
            this.columnsInfo.FieldName = "columnsInfo";
            this.columnsInfo.Name = "columnsInfo";
            this.columnsInfo.OptionsColumn.AllowSort = false;
            // 
            // image
            // 
            this.image.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("image.ImageStream")));
            this.image.TransparentColor = System.Drawing.Color.Transparent;
            this.image.Images.SetKeyName(0, "class.png");
            this.image.Images.SetKeyName(1, "property.png");
            this.image.Images.SetKeyName(2, "agregation.png");
            this.image.Images.SetKeyName(3, "selection.png");
            this.image.Images.SetKeyName(4, "agragation2.png");
            this.image.Images.SetKeyName(5, "agregation3.png");
            this.image.Images.SetKeyName(6, "association.png");
            this.image.Images.SetKeyName(7, "classChild.png");
            this.image.Images.SetKeyName(8, "View.png");
            // 
            // splitterControl2
            // 
            this.splitterControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterControl2.Location = new System.Drawing.Point(2, 133);
            this.splitterControl2.Name = "splitterControl2";
            this.splitterControl2.Size = new System.Drawing.Size(341, 6);
            this.splitterControl2.TabIndex = 2;
            this.splitterControl2.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelControl2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFindClass, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listClasses, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(341, 113);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl2.Location = new System.Drawing.Point(3, 90);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 20);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Поиск";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(81, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Выберите класс";
            // 
            // txtFindClass
            // 
            this.txtFindClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFindClass.Location = new System.Drawing.Point(90, 90);
            this.txtFindClass.Name = "txtFindClass";
            this.txtFindClass.Size = new System.Drawing.Size(248, 20);
            this.txtFindClass.TabIndex = 2;
            this.txtFindClass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFindClass_KeyUp);
            // 
            // listClasses
            // 
            this.listClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listClasses.HorzScrollStep = 7;
            this.listClasses.Location = new System.Drawing.Point(90, 3);
            this.listClasses.Name = "listClasses";
            this.listClasses.Size = new System.Drawing.Size(248, 81);
            this.listClasses.TabIndex = 3;
            this.listClasses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listClasses_MouseDoubleClick);
            // 
            // splitterControl1
            // 
            this.splitterControl1.Location = new System.Drawing.Point(345, 24);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(6, 519);
            this.splitterControl1.TabIndex = 5;
            this.splitterControl1.TabStop = false;
            // 
            // contMenuListProperty
            // 
            this.contMenuListProperty.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRemove});
            this.contMenuListProperty.Name = "contMenuListProperty";
            this.contMenuListProperty.Size = new System.Drawing.Size(130, 26);
            // 
            // MenuItemRemove
            // 
            this.MenuItemRemove.Name = "MenuItemRemove";
            this.MenuItemRemove.Size = new System.Drawing.Size(129, 22);
            this.MenuItemRemove.Text = "Удалить";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.checkListProperty);
            this.groupControl3.Controls.Add(this.panelButtons);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl3.Location = new System.Drawing.Point(351, 24);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(385, 519);
            this.groupControl3.TabIndex = 12;
            this.groupControl3.Text = "Свойства";
            // 
            // checkListProperty
            // 
            this.checkListProperty.AllowDrop = true;
            this.checkListProperty.ContextMenuStrip = this.contMenuListProperty;
            this.checkListProperty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkListProperty.Location = new System.Drawing.Point(2, 20);
            this.checkListProperty.Name = "checkListProperty";
            this.checkListProperty.Size = new System.Drawing.Size(227, 497);
            this.checkListProperty.TabIndex = 8;
            this.checkListProperty.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataDrop_DragDrop);
            this.checkListProperty.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataDrop_DragEnter);
            // 
            // panelButtons
            // 
            this.panelButtons.ColumnCount = 1;
            this.panelButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelButtons.Controls.Add(this.btSQL, 0, 4);
            this.panelButtons.Controls.Add(this.btCreateForms, 0, 3);
            this.panelButtons.Controls.Add(this.btSettings, 0, 0);
            this.panelButtons.Controls.Add(this.btClear, 0, 1);
            this.panelButtons.Controls.Add(this.btOpenHTML, 0, 5);
            this.panelButtons.Controls.Add(this.simpleButton1, 0, 6);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtons.Location = new System.Drawing.Point(229, 20);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.RowCount = 8;
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 258F));
            this.panelButtons.Size = new System.Drawing.Size(154, 497);
            this.panelButtons.TabIndex = 7;
            // 
            // btSQL
            // 
            this.btSQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSQL.Image = global::AutoFormFind.Properties.Resources.sql;
            this.btSQL.Location = new System.Drawing.Point(3, 143);
            this.btSQL.Name = "btSQL";
            this.btSQL.Size = new System.Drawing.Size(148, 24);
            this.btSQL.TabIndex = 9;
            this.btSQL.Text = "SQL";
            this.btSQL.Click += new System.EventHandler(this.btSQL_Click);
            // 
            // btCreateForms
            // 
            this.btCreateForms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCreateForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btCreateForms.Image = global::AutoFormFind.Properties.Resources.forms;
            this.btCreateForms.Location = new System.Drawing.Point(3, 113);
            this.btCreateForms.Name = "btCreateForms";
            this.btCreateForms.Size = new System.Drawing.Size(148, 24);
            this.btCreateForms.TabIndex = 8;
            this.btCreateForms.Text = "Создать форму";
            this.btCreateForms.Click += new System.EventHandler(this.btCreateForms_Click);
            // 
            // btSettings
            // 
            this.btSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btSettings.Image = global::AutoFormFind.Properties.Resources.advancedsettings;
            this.btSettings.Location = new System.Drawing.Point(3, 3);
            this.btSettings.Name = "btSettings";
            this.btSettings.Size = new System.Drawing.Size(148, 24);
            this.btSettings.TabIndex = 5;
            this.btSettings.Text = "Настроить";
            this.btSettings.Click += new System.EventHandler(this.btSettings_Click);
            // 
            // btClear
            // 
            this.btClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btClear.Image = global::AutoFormFind.Properties.Resources.lists;
            this.btClear.Location = new System.Drawing.Point(3, 33);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(148, 24);
            this.btClear.TabIndex = 6;
            this.btClear.Text = "Отчистить список";
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btOpenHTML
            // 
            this.btOpenHTML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btOpenHTML.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btOpenHTML.Image = ((System.Drawing.Image)(resources.GetObject("btOpenHTML.Image")));
            this.btOpenHTML.Location = new System.Drawing.Point(3, 173);
            this.btOpenHTML.Name = "btOpenHTML";
            this.btOpenHTML.Size = new System.Drawing.Size(148, 24);
            this.btOpenHTML.TabIndex = 11;
            this.btOpenHTML.Text = "Показать HTML формы";
            this.btOpenHTML.Click += new System.EventHandler(this.btOpenHTML_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 203);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(148, 24);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Показать парамерты SQL";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.webBrowserView);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(736, 24);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(236, 519);
            this.groupControl2.TabIndex = 14;
            this.groupControl2.Text = "Вид";
            // 
            // webBrowserView
            // 
            this.webBrowserView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserView.Location = new System.Drawing.Point(2, 20);
            this.webBrowserView.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserView.Name = "webBrowserView";
            this.webBrowserView.Size = new System.Drawing.Size(232, 497);
            this.webBrowserView.TabIndex = 0;
            // 
            // MFormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 565);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.splitterControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MFormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автоматическое формирование форм поиска";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.barManagerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeListMain)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtFindClass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listClasses)).EndInit();
            this.contMenuListProperty.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkListProperty)).EndInit();
            this.panelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManagerMain;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ContextMenuStrip contMenuListProperty;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemove;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.CheckedListBoxControl checkListProperty;
        private System.Windows.Forms.TableLayoutPanel panelButtons;
        private DevExpress.XtraEditors.SimpleButton btSQL;
        private DevExpress.XtraEditors.SimpleButton btCreateForms;
        private DevExpress.XtraEditors.SimpleButton btSettings;
        private DevExpress.XtraEditors.SimpleButton btClear;
        private DevExpress.XtraEditors.SimpleButton btOpenHTML;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.WebBrowser webBrowserView;
        private System.Windows.Forms.ImageList image;
        private DevExpress.XtraEditors.TextEdit txtFindClass;
        private DevExpress.XtraEditors.ListBoxControl listClasses;
        private DevExpress.XtraTreeList.TreeList treeListMain;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnsClass;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnsNameProperty;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnsInfo;
        private DevExpress.XtraEditors.SplitterControl splitterControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}