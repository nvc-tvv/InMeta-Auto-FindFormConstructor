using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Integro.InMeta.Runtime;
using DevExpress.XtraTreeList.Nodes;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using DevExpress.XtraTreeList;
using DevExpress.XtraLayout;
using DevExpress.XtraEditors.Controls; 


namespace AutoFormFind
{

    public partial class MFormMain : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Содержит ссылку на приложение
        /// </summary>
        private DataSession session;
        /// <summary>
        /// Структура дерева метаданных
        /// </summary>
        private TreeListNode nodeObject;

        private ClassInfo classInfo;
        public List<object> objControlsHtml = new List<object>();
        public static MFormMain instance;
        List<string> svjaz_all = new List<string> { };
        string sql_select;
        string sql_from;

        public MFormMain(DataSession session)
        {
            this.session = session;
            MFormMain.instance = this;
            InitializeComponent();
            txtFindClass_KeyUp(null, null);

        }

        #region Структура метаданных
        /// <summary>
        /// Структура метаданных
        /// </summary>
        /// <param name="className"></param>
        /// <param name="node"></param>
        private void GetTreeRecursive(MetadataClass className, Int32 node)
        {
            //Свойства
            foreach (MetadataProperty _property in className.Properties)
            {
                if (_property.IsAggregation)
                    if (_property.Association.Refs.Count == 1 && _property.Association.Selector == null)
                    {
                        nodeObject = treeListMain.AppendNode("nodeProperty", node, _property.Association.Refs[0].RefClass);
                        nodeObject.ImageIndex = 2;
                        nodeObject.SetValue("columnsNode", _property.Caption);
                        nodeObject.SetValue("columnsNameProperty", _property.Name);
                        nodeObject.SetValue("columnsInfo", "IsAggregationProperty");
                    }
                    else
                    {
                        TreeListNode nodeObjectChild = treeListMain.AppendNode("nodePropertyObject", node);
                        nodeObjectChild.SetValue("columnsNode", _property.Caption);
                        nodeObjectChild.SetValue("columnsNameProperty", _property.Name);
                        nodeObjectChild.SetValue("columnsInfo", "IsSelectorProperty");
                        nodeObjectChild.ImageIndex = 4;
                        nodeObjectChild.SelectImageIndex = 3;
                        foreach (MetadataAssociationRef refAssociation in _property.Association.Refs)
                        {
                            nodeObject = treeListMain.AppendNode("nodeProperty", nodeObjectChild, refAssociation.RefClass);
                            nodeObject.SetValue("columnsNode", refAssociation.RefClass.Caption);
                            nodeObject.SetValue("columnsNameProperty", refAssociation.RefClass.Name);
                            nodeObject.SetValue("columnsInfo", "IsAggregationProperty");
                            nodeObject.ImageIndex = 5;
                            nodeObject.SelectImageIndex = 3;
                        }
                    }
                else if (_property.IsAssociation)
                    //foreach (MetadataAssociationRef refAssociation in _property.Association.Refs)
                    //{
                        
                    //    nodeObject = treeListMain.AppendNode("nodeProperty", node, refAssociation.RefClass);
                    //    nodeObject.ImageIndex = 6;
                    //    nodeObject.SetValue("columnsNode", _property.Caption);
                    //    nodeObject.SetValue("columnsNameProperty", _property.Name);
                    //    nodeObject.SetValue("columnsInfo", "IsAssociationProperty");
                    //}
                    if (_property.Association.Refs.Count == 1)
                    {
                        nodeObject = treeListMain.AppendNode("nodeProperty", node, _property.Association.Refs[0].RefClass);
                        nodeObject.ImageIndex = 6;
                        nodeObject.SetValue("columnsNode", _property.Caption);
                        nodeObject.SetValue("columnsNameProperty", _property.Name);
                        nodeObject.SetValue("columnsInfo", "IsAssociationProperty");
                    }
                    else
                    {
                        TreeListNode nodeObjectChild = treeListMain.AppendNode("nodePropertyObject", node);
                        nodeObjectChild.SetValue("columnsNode", _property.Caption);
                        nodeObjectChild.SetValue("columnsNameProperty", _property.Name);
                        nodeObjectChild.SetValue("columnsInfo", "IsSelectorProperty");
                        nodeObjectChild.ImageIndex = 4;
                        nodeObjectChild.SelectImageIndex = 3;
                        foreach (MetadataAssociationRef refAssociation in _property.Association.Refs)
                        {
                            nodeObject = treeListMain.AppendNode("nodeProperty", nodeObjectChild, refAssociation.RefClass);
                            nodeObject.SetValue("columnsNode", refAssociation.RefClass.Caption);
                            nodeObject.SetValue("columnsNameProperty", refAssociation.RefClass.Name);
                            nodeObject.SetValue("columnsInfo", "IsAssociationProperty");
                            nodeObject.ImageIndex = 5;
                            nodeObject.SelectImageIndex = 3;
                        }
                    }
                else
                {
                    if (_property.IsUserField && !_property.IsId)
                    {
                        nodeObject = treeListMain.AppendNode("nodeProperty", node, null);
                        nodeObject.ImageIndex = 1;
                        nodeObject.SetValue("columnsNode", _property.Caption);
                        nodeObject.SetValue("columnsNameProperty", _property.Name);
                        nodeObject.SetValue("columnsType", _property.DataType.ToString());
                        nodeObject.SetValue("columnsInfo", "Property");
                    }
                }
                nodeObject.SelectImageIndex = 3;
            }

            //Дочернии классы
            foreach (MetadataChildRef refChild in className.Childs)
            {
                nodeObject = treeListMain.AppendNode("nodeRefChildClass", node, refChild.ChildClass);
                XDocument docXmlLinq = XDocument.Parse(refChild.AggregationRef.RefClass.SourceNode.OuterXml);
                IEnumerable<string> caption = from t in docXmlLinq.Root.Elements("aggregation")
                                              where t.Attribute("ref-class").Value == refChild.ChildClass.Name
                                              select t.Attribute("role-caption").Value;
                foreach(string s in caption)
                    nodeObject.SetValue("columnsNode", s);
                nodeObject.SetValue("columnsInfo", "refChild");
                nodeObject.SetValue("columnsNameProperty", refChild.ChildClass.Name);
                nodeObject.SelectImageIndex = 3;
                nodeObject.ImageIndex = 7;

            }

            //Представления
            foreach (MetadataObjectView objectView in className.ObjectViews)
            {
                nodeObject = treeListMain.AppendNode("nodeProperty", node, null);
                nodeObject.SetValue("columnsNode", objectView.Caption);
                nodeObject.SetValue("columnsInfo", "ObjectView");
                nodeObject.ImageIndex = 8;
                nodeObject.SelectImageIndex = 3;
            }
        }
        #endregion

        private void treeListMain_AfterFocusNode(object sender, NodeEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                classInfo.Tag = e.Node.Tag;
                classInfo.Id = e.Node.Id;
                classInfo.Property = false;
            }
            else
            {
                classInfo.Tag = e.Node.ParentNode != null ? e.Node.ParentNode.Tag : null;
                classInfo.Id = e.Node.Id;
                classInfo.Property = true;
            } 
        }

        private void treeListMain_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e)
        {
            switch(e.Node.GetDisplayText("columnsInfo"))
            {
                case "IsAggregationProperty": e.Appearance.BackColor = Color.DeepPink;                          break;
                case "IsAssociationProperty": e.Appearance.BackColor = Color.DarkGray;                          break;
                case "refChild":              e.Appearance.Font = new Font(e.Appearance.Font, FontStyle.Bold);  break;
                case "ObjectView":            e.Appearance.BackColor = Color.DarkSeaGreen;                      break;
            }
            //if (e.Node.GetDisplayText("columnsNameProperty").Equals("id"))
            //    e.Appearance.BackColor = Color.Red;
        }

        private void treeListMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeList objTreeList = (TreeList)sender;
                if (objTreeList.FocusedNode != null)
                    if (objTreeList.FocusedNode.Nodes.Count == 0 & !classInfo.Property)
                        this.GetTreeRecursive((MetadataClass)classInfo.Tag, (Int32)classInfo.Id);
            }
        }
        
        private void treeListMain_MouseDown(object sender, MouseEventArgs e)
        {
            DragDropEffects drag;
            if (e.Clicks != 2)
                if (treeListMain.FocusedNode != null)
                {
                    if ((string)treeListMain.FocusedNode.GetValue("columnsInfo") == "Property")
                    {
                        string obj = (string)treeListMain.FocusedNode.GetValue("columnsNode") + "|" +
                                     ((MetadataClass)classInfo.Tag).Name + "|" +
                                     (string)treeListMain.FocusedNode.GetValue("columnsNameProperty") + "|" +
                                     Convert.ToString(classInfo.Id) + "|" +
                                     ((MetadataClass)classInfo.Tag).Caption + "|" +
                                     Convert.ToString(treeListMain.FocusedNode.ParentNode.Id);
                        drag = DoDragDrop(obj, DragDropEffects.All);
                    }
                    if ((string)treeListMain.FocusedNode.GetValue("columnsInfo") == "IsAssociationProperty")
                    {
                        if ((string)treeListMain.FocusedNode.ParentNode.GetValue("columnsInfo") != "IsSelectorProperty")
                        {
                            string obj = (string)treeListMain.FocusedNode.GetValue("columnsNode") + "(Assoc)|" +
                                         ((MetadataClass)treeListMain.FocusedNode.ParentNode.Tag).Name + "|" +
                                         (string)treeListMain.FocusedNode.GetValue("columnsNameProperty") + "|" +
                                         Convert.ToString(classInfo.Id) + "|" +
                                         ((MetadataClass)treeListMain.FocusedNode.ParentNode.Tag).Caption + "|" +
                                         Convert.ToString(treeListMain.FocusedNode.ParentNode.Id);
                            drag = DoDragDrop(obj, DragDropEffects.All);
                        }
                        else
                        {
                            string obj = (string)treeListMain.FocusedNode.GetValue("columnsNode") + "(Assoc)|" +
                                         ((MetadataClass)treeListMain.FocusedNode.ParentNode.ParentNode.Tag).Name + "|" +
                                         (string)treeListMain.FocusedNode.ParentNode.GetValue("columnsNameProperty") +
                                         "-" + ((MetadataClass)treeListMain.FocusedNode.Tag).Name + "|" +
                                         Convert.ToString(classInfo.Id) + "|" +
                                         ((MetadataClass)treeListMain.FocusedNode.ParentNode.ParentNode.Tag).Caption + "|" +
                                         Convert.ToString(treeListMain.FocusedNode.ParentNode.ParentNode.Id);
                            drag = DoDragDrop(obj, DragDropEffects.All);
                        }
                        
                    }
                }
        }
        
        private void dataDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.String)))
            {
                String[] obj = e.Data.GetData(typeof(System.String)).ToString().Split(new Char[] { '|' });
                CheckedListBoxItem item = new CheckedListBoxItem();
                item.Description =  obj[0].ToString();
                item.Value = new object[] { obj[1].ToString(), obj[2].ToString(), obj[3].ToString(), obj[4].ToString(), obj[5].ToString() };
                checkListProperty.Items.AddRange(new CheckedListBoxItem[] { item });
                
            }
        }

        private void dataDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            this.checkListProperty.Items.Clear();
            svjaz_all.Clear();
        }

        private void btSettings_Click(object sender, EventArgs e)
        {
            Form f_settings;
            objControlsHtml.Clear();
            foreach (CheckedListBoxItem item in checkListProperty.Items)
                if (item.CheckState == CheckState.Checked)
                {
                    f_settings = new MFormSettings(session, 
                                                    (string)((object[])item.Value)[0],
                                                    (string)((object[])item.Value)[1],
                                                    Convert.ToInt32(((object[])item.Value)[2]),
                                                    Convert.ToInt32(((object[])item.Value)[4])
                                                  );
                    f_settings.ShowDialog();
                }
        }

        private void btCreateForms_Click(object sender, EventArgs e)
        {
            //Строим HTML код и формируем форму в Web Browser
            string str = null;
            foreach (CreateControlsProperty _prop in objControlsHtml)
                str += _prop.GetHTMLControls;
            webBrowserView.DocumentText = str;
        }

        /// <summary>
        /// Возвращает всех родителей в дереве
        /// </summary>
        /// <param name="node"></param>
        /// <param name="array"></param>
        void GetTablesSQL(TreeListNode node, ref List<object> array)
        {
            TreeListNode aNode = node;
            while (aNode.ParentNode != null & node.RootNode != node.ParentNode & aNode.ParentNode.GetValue("columnsNameProperty") != null)
                {
                    array.Add(aNode.ParentNode.Tag);
                    aNode = aNode.ParentNode;
                }
        }

        private void btOpenHTML_Click(object sender, EventArgs e)
        {
            CreateControlsProperty.SetInfo(webBrowserView.DocumentText);
        }

        private void btSQL_Click(object sender, EventArgs e)
        {
            foreach (CreateControlsProperty items in objControlsHtml)
            {
                TreeListNode node = treeListMain.FindNodeByID(items.GetId);
                if (node.GetValue("columnsInfo").ToString() == "IsAssociationProperty" && node.ParentNode.GetValue("columnsInfo").ToString() == "IsSelectorProperty")
                    node = node.ParentNode;
                node = node.ParentNode;
                List<string> svjaz_from_one_prop = new List<string> { };
                do
                {
                    string st = "";
                    if (node.GetValue("columnsInfo").ToString() != "RootClass")
                        if (node.GetValue("columnsInfo").ToString() != "refChild")
                        {
                            if (node.ParentNode.GetValue("columnsInfo").ToString() != "IsSelectorProperty")
                            {
                                st = "LEFT OUTER JOIN [" + ((MetadataClass)node.Tag).DataTable
                                    + "] [" + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "] ON ["
                                    + ((MetadataClass)node.ParentNode.Tag).DataTable.ToUpper() + node.ParentNode.Id.ToString() + "].[" +
                                    ((MetadataClass)node.ParentNode.Tag).AllProperties.Need(
                                    node.GetValue("columnsNameProperty").ToString()).DataField
                                    + "] = [" + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "].[OID]";
                                node = node.ParentNode;
                            }
                            else
                            {
                                st = "LEFT OUTER JOIN [" + ((MetadataClass)node.Tag).DataTable
                                    + "] [" + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "] ON ["
                                    + ((MetadataClass)node.ParentNode.ParentNode.Tag).DataTable.ToUpper() + node.ParentNode.ParentNode.Id.ToString() 
                                    + "].[" + ((MetadataClass)node.ParentNode.ParentNode.Tag).AllProperties.Need(
                                    node.ParentNode.GetValue("columnsNameProperty").ToString()).DataField + "] = ["
                                    + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "].[OID]";
                                node = node.ParentNode.ParentNode;
                            }

                            svjaz_from_one_prop.Add(st);
                        }
                        else
                        {
                            st = "LEFT OUTER JOIN [" + ((MetadataClass)node.Tag).DataTable
                                + "] [" + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "] ON ["
                                + ((MetadataClass)node.Tag).DataTable.ToUpper() + node.Id.ToString() + "].[";
                            foreach (MetadataProperty prpt in ((MetadataClass)node.Tag).AllProperties)
                            {
                                if (prpt.IsAggregation)
                                {
                                    if (prpt.Association.Refs.Count == 1)
                                    {
                                        if (prpt.Association.Refs[0].RefClass == (MetadataClass)node.ParentNode.Tag)
                                        {
                                            st = st + prpt.DataField + "] = [" + ((MetadataClass)node.ParentNode.Tag).DataTable.ToUpper()
                                                 + node.ParentNode.Id.ToString() + "].[OID]";
                                        }
                                    }
                                    else
                                    {
                                        foreach (MetadataAssociationRef refAss in prpt.Association.Refs)
                                        {
                                            if (refAss.RefClass == (MetadataClass)node.ParentNode.Tag)
                                            {
                                                st = st + prpt.DataField + "] = [" + ((MetadataClass)node.ParentNode.Tag).DataTable.ToUpper()
                                                     + node.ParentNode.Id.ToString() + "].[OID]";
                                            }
                                        }
                                    }
                                }
                            }
                            svjaz_from_one_prop.Add(st);
                            node = node.ParentNode;
                        }
                } while (node.ParentNode.Level != 0);
                for (int i = svjaz_from_one_prop.Count - 1; i > -1; i--)
                {
                    svjaz_all.Add(svjaz_from_one_prop[i]);
                }
            }
            //Строим SQL-запросы
            string str = "<%\r\n" + "Dim WhereResult\r\n" + "WhereResult = \"\"\r\n";
            foreach (CreateControlsProperty _prop in objControlsHtml)
            {
                str += _prop.GetSQLCodeControls + "\r\n";
            }
            str += "Content.Append WhereResult\r\n" + "%>";
            Form fr_sql = new MFormCreateSQL(svjaz_all.Distinct().ToList(), sql_select, sql_from, str);
            fr_sql.Show();
        }

        private void txtFindClass_KeyUp(object sender, KeyEventArgs e)
        {
            listClasses.DataSource = new BusinessObjectClasses(session).Select(txtFindClass.Text.Trim());
            listClasses.DisplayMember = "Caption";
            listClasses.ValueMember = "Name";
        }

        private void listClasses_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ListBoxControl list = (ListBoxControl)sender;
                treeListMain.Nodes.Clear();
                svjaz_all.Clear();
                btClear_Click(sender, e);
                TreeListNode nodeClass = treeListMain.AppendNode(new object[] { "Классы:" }, null);
                MetadataClass _cls = session[list.SelectedValue.ToString()].Class;
                nodeObject = treeListMain.AppendNode("nodeClass", nodeClass, _cls);
                nodeObject.ImageIndex = 0;
                nodeObject.SelectImageIndex = 3;
                nodeObject.SetValue("columnsNode", _cls.Caption);
                nodeObject.SetValue("columnsNameProperty", _cls.Name);
                nodeObject.SetValue("columnsInfo", "RootClass");
                sql_select = "SELECT [" + ((MetadataClass)treeListMain.Nodes[0].Nodes[0].Tag).DataTable.ToUpper() 
                    + treeListMain.Nodes[0].Nodes[0].Id.ToString() + "].[OID] as [id]";
                sql_from = "FROM [" + ((MetadataClass)treeListMain.Nodes[0].Nodes[0].Tag).DataTable + "] ["
                    + ((MetadataClass)treeListMain.Nodes[0].Nodes[0].Tag).DataTable.ToUpper() + treeListMain.Nodes[0].Nodes[0].Id.ToString() + "]";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (CreateControlsProperty _prop in objControlsHtml)
            {
                str += _prop.GetSQLParametrs + "\r\n";
            }
            Form param_sql = new MFormParamSQL(str);
            param_sql.Show();
        }

    }
}