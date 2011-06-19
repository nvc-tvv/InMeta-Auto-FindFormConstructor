using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Integro.InMeta.Runtime;
using System.Collections;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing;
using DevExpress.XtraEditors.Controls;


namespace AutoFormFind
{
    class ApplicationInMeta
    {
        private string nameHostAddresses = null;
        /// <summary>
        /// Возвращает адрес центрального сервера
        /// </summary>
        public string Name { get { return nameHostAddresses; } }
        /// <summary>
        /// Конструктор класса 
        /// </summary>
        public ApplicationInMeta(string nameHostAddresses) 
        {
            this.nameHostAddresses = nameHostAddresses;
        }

        /// <summary>
        /// Возвращает проекты ИнМета
        /// </summary>
        /// <returns></returns>
        public string[] GetApplication()
        {
            return ((IEnumerable<string>)from app in DataApplication.GetAppIds(Name)
                                         orderby app
                                         select app).ToArray<string>();
        }
    }

    class BusinessObjectClasses
    {
        /// <summary>
        /// Храним ссылку на сессию
        /// </summary>
        private DataSession session;
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="session"></param>
        public BusinessObjectClasses(DataSession session) { this.session = session; }

        public IList Select(string value)
        {
            var meta = from data in session.Application.Metadata.Classes.Cast<MetadataClass>()
                       where data.Caption.StartsWith(value, true, null)
                       orderby data.Caption
                       select new { Caption = data.Caption + " - [" + data.Name + "]", Name = data.Name };
            return meta.ToArray();
        }
    }

    class CreateControlsProperty
    {
        private String type;
        private String NameClass;
        private String NameProperty;
        private String HTMLPropertyCaption;
        private Boolean[] checkSettingHtml = new Boolean[11];
        private List<object> NamePropertyItems;
        private Int32 Id;
        private String NameTable;
        private Int32 IdClass;
        private DataSession session;
        private String AssocClass;

        public CreateControlsProperty(
                                        DataSession session,
                                        String NameClass,
                                        String NameProp,
                                        String PropertyCaption,
                                        Int32 Id,
                                        Int32 IdClass,
                                        List<object> items,
                                        Boolean[] checkSettingHtml
                                     )
        {
            this.session = session;
            this.Id = Id;
            this.NameClass = NameClass;
            if (NameProp.IndexOf("-") == -1)
                this.NameProperty = NameProp;
            else
                this.NameProperty = NameProp.Substring(0, NameProp.IndexOf("-"));

            this.HTMLPropertyCaption = PropertyCaption;
            this.NamePropertyItems = items;
            this.IdClass = IdClass;
            this.NameTable = session[NameClass].Class.DataTable;
            checkSettingHtml.CopyTo(this.checkSettingHtml, 0);
            if (!this.checkSettingHtml[9])
                this.type = session[NameClass].Class.AllProperties.Need(this.NameProperty).DataTypeName;
            else
            {
                this.type = "string";
                if (NameProp.IndexOf("-") == -1)
                    AssocClass = session[NameClass].Class.AllProperties.Need(NameProperty).Association.Refs[0].RefClass.Name;
                else
                {
                    AssocClass = session[NameClass].Class.AllProperties.Need(NameProperty).Association.Refs.Need(session[NameProp.Substring(NameProp.IndexOf("-") + 1)].Class).RefClass.Name;
                }
            }
        }

        /// <summary>
        /// Выводит HTML код контролов
        /// </summary>
        public String GetHTMLControls
        {
            get 
            {
                string paramBuildingCheck = string.Empty;
                string HtmlDocument = "<table border='1' cellSpacing='1' cellPadding='1' width='100%'>\r\n" +
                    "<tr><th colspan=3 bgcolor=\"#FFCC33\" style=\"text-align:left\">" + this.HTMLPropertyCaption + "</th></tr>\r\n";
                //условие на включения опции выбора типа поиска точный/по включению
                if (this.checkSettingHtml[0])
                    paramBuildingCheck = "<td style=\"width:2%\"><input type=\"checkbox\" id=\"BuildingCheck" + this.NameTable + this.IdClass 
                        + "_" + this.NameProperty + "\"\r\n" + "elem-attr=\"checked\" inmeta-param=\"BuildingCheck"
                        + this.NameTable + this.IdClass + "_" + this.NameProperty + "\"></td>\r\n";
                //
                if (this.type == "uint8" || this.type == "int16" || this.type == "int32" || this.type == "single" ||
                    this.type == "double" || this.type == "currency" || this.type == "char")
                {
                    if (!this.checkSettingHtml[7] && !this.checkSettingHtml[8])
                        HtmlDocument += "<tr><td><input type=\"text\" class=\"edit\" name=\"" + this.NameTable + this.IdClass + "_"
                            + this.NameProperty + "\" style='width:100%'\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass + "_"
                            + this.NameProperty + "\" inmeta-data-type=\"" + this.type + "\"></td></tr>\r\n";
                    else
                    {
                        //для свойств с заданными предопределенными значениями
                        if (this.checkSettingHtml[8])
                        {
                            if (NamePropertyItems != null)
                            {
                                HtmlDocument += "<tr><td><select name=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" size=\"1\" inmeta-param=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" style='width:100%' inmeta-data-type=\"int32\">\r\n";
                                foreach (object obj in this.NamePropertyItems)
                                    if (((ItemsList)obj).Select)
                                        HtmlDocument += "<option selected value=\"" + ((ItemsList)obj).Value + "\">" + ((ItemsList)obj).Name;
                                    else
                                        HtmlDocument += "<option value=\"" + ((ItemsList)obj).Value + "\">" + ((ItemsList)obj).Name;
                                HtmlDocument += "</select></td></tr>\r\n";
                            }
                            else
                            {
                                HtmlDocument += "<tr><td><select name=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" size=\"1\" inmeta-param=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" style='width:100%' inmeta-data-type=\"" + this.type + "\">\r\n";
                                HtmlDocument += "<option selected value=\"-1\">Все";
                                foreach (MetadataLookupValue obj in session[NameClass].Class.AllProperties.Need(NameProperty).LookupValues)
                                    HtmlDocument += "<option value=\"" + obj.Value + "\">" + obj.Caption;
                                HtmlDocument += "</select></td></tr>\r\n";
                            }
                        }
                        else
                        {
                            //для диапазона
                            HtmlDocument += "<tr><td style='width:5%'>от </td><td><input class=\"edit\" name=\"" + this.NameTable
                                + this.IdClass + "_Min" + this.NameProperty + "\"\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass
                                + "_Min" + this.NameProperty + "\" style='width:100%'></td></tr>\r\n" +
                                "<tr><td>до </td><td  style='width:5%'><input class=\"edit\" name=\"" + this.NameTable + this.IdClass + "_Max"
                                + this.NameProperty + "\"\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass + "_Max" + this.NameProperty
                                + "\"style='width:100%'></td></tr>\r\n";
                        }
                    }
                }
                //
                if (this.type == "string" || this.type == "text")
                {
                    if (!this.checkSettingHtml[9])
                        if (this.checkSettingHtml[8])
                        {
                            if (NamePropertyItems != null)
                            {
                                HtmlDocument += "<tr><td><select name=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" size=\"1\" inmeta-param=\"\r\n" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" style='width:100%' inmeta-data-type=\"string\">\r\n";
                                foreach (object obj in this.NamePropertyItems)
                                    if (((ItemsList)obj).Select)
                                        HtmlDocument += "<option selected value=\"" + ((ItemsList)obj).Value + "\">" + ((ItemsList)obj).Name;
                                    else
                                        HtmlDocument += "<option value=\"" + ((ItemsList)obj).Value + "\">" + ((ItemsList)obj).Name;
                                HtmlDocument += "</select></td></tr>\r\n";
                            }
                            else
                            {
                                HtmlDocument += "<tr><td><select name=\"" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" size=\"1\" inmeta-param=\"\r\n" + this.NameTable + this.IdClass + "_" + this.NameProperty
                                    + "\" style='width:100%' inmeta-data-type=\"string\">\r\n";
                                HtmlDocument += "<option selected value=\"0000\">Все";
                                foreach (MetadataLookupValue obj in session[NameClass].Class.AllProperties.Need(NameProperty).LookupValues)
                                    HtmlDocument += "<option value=\"" + obj.Value + "\">" + obj.Caption;
                                HtmlDocument += "</select></td></tr>\r\n";
                            }
                        }
                        else
                            HtmlDocument += "<tr>" + paramBuildingCheck + "<td><input type=\"text\" class=\"edit\" name=\"" + this.NameTable
                                + this.IdClass + "_" + this.NameProperty + "\" style='width:100%'\r\n" + "inmeta-param=\"" + this.NameTable
                                + this.IdClass + "_" + this.NameProperty + "\" inmeta-data-type=\"string\"></td></tr>\r\n";
                    else
                    {
                        string nameClassAssociation = AssocClass;
                        string _name = nameClassAssociation.Replace("/", string.Empty) + this.Id;
                        HtmlDocument += "<tr><td class='dropdown-edit' style='width:100%'>\r\n" +
                            "<input class=\"edit\" name=\"" + _name + "View\" style='width:100%' inmeta-param=\"" + _name + "View\" disabled>\r\n" +
                            "<input class=\"edit\" name=\"" + _name + "\" inmeta-param=\"" + _name + "\" type=\"hidden\">\r\n" +
                            "</td><td style='width:8pt'><button id=Select" + nameClassAssociation.Replace("/", "") + this.Id + "Button>...</button></td>\r\n" +
                            "<script defer='true' event='OnClick' for='Select" + nameClassAssociation.Replace("/", "") + this.Id + "Button' language=\"vbscript\">\r\n";
                        #region SCRIPT

                        HtmlDocument += this.checkSettingHtml[10] ? "Const cProperty = \"" + _name + "\"\r\n" +
                            "Dim sClass, arrIDs\r\n" +
                            "sClass = \"" + nameClassAssociation + "\"\r\n" +
                            "Dim sURL\r\n" +
                            "sURL = \"object_list_form.asp?class=\" & sClass & \"&multi-select=true\"\r\n" +
                            "arrIDs = window.ShowModalDialog(sURL, \"modal\", \"center:yes; help:no; resizable:yes; status:no\")\r\n" +
                            "if IsNull(arrIDs) then\r\n" +
                            "arrIDs = \"\"\r\n" +
                            "end if\r\n" +
                            "if IsArray(arrIDs) then\r\n" +
                            "arrIDs = Join(arrIDs, \",\")\r\n" +
                            "end if\r\n" +
                            "document.all(cProperty).Value = arrIDs\r\n" +
                            "Dim arrViews\r\n" +
                            "arrViews = \"\"\r\n" +
                            "if arrIDs <> \"\" then\r\n" +
                            "Dim DSC, aObjects, i\r\n" +
                            "Set DSC = CreateObject(\"InMetaCR.InMetaDataServiceClient\")\r\n" +
                            "DSC.ServerURL = InMeta.AppBaseURL\r\n" +
                            "aObjects = DSC.QueryObjectInfoArray(sClass, \"idProperty in ('\" & Join(Split(arrIDs, \",\"), \"','\") & \"')\", Array(), \"\")\r\n" +
                            "For i = LBound(aObjects) to UBound(aObjects)\r\n" +
                            "if arrViews <> \"\" then arrViews = arrViews & \",\"\r\n" +
                            "arrViews = arrViews & aObjects(i).ObjectView\r\n" +
                            "Next\r\n" +
                            "end if\r\n" +
                            "document.all(cProperty & \"View\").Value = arrViews\r\n" +
                            "</script>" :
                            "Dim anURL\r\n anURL = \"object_list_form.asp?class=" + nameClassAssociation + "&search-form=inmeta-one-field-search-form&FieldParam=Name&FilterParam=\" & document.all(\"" + _name + "View\").Value\r\n" +
                            "Dim anID\r\n anID = window.showModalDialog(anURL, \"modal\", \"center:yes; help:no; resizable:yes; status:no\")\r\n " +
                            "if (anID & \"\") <> \"\" then\r\n " +
                            "Dim aDataService, aCountry \r\n" +
                            "Set aDataService = CreateObject(\"InMetaCR.InMetaDataServiceClient\")\r\n " +
                            "aDataService.ServerURL = InMeta.AppBaseURL \r\n" +
                            "Set aCountry = aDataService.GetObjectInfo(\"" + nameClassAssociation + "\", anID, \"Name\") \r\n" +
                            "document.all(\"" + _name + "\").Value = aCountry.PropertyValue(\"id\")\r\n " +
                            "document.all(\"" + _name + "View\").Value = aCountry.ObjectView\r\n " +
                            "end if\r\n" +
                            "</script>";
                        #endregion
                    }
                }
                //
                if (this.type == "datetime")
                {
                    if (!this.checkSettingHtml[7])
                        HtmlDocument += "<tr><td><input type=\"text\" class=\"edit\" name=\"" + this.NameTable + this.IdClass + "_"
                            + this.NameProperty + "\" style='width:100%'\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass + "_"
                            + this.NameProperty + "\" inmeta-data-type=\"DateTime\"></td></tr>\r\n";
                    else
                    {
                        HtmlDocument += "<tr><td style='width:5%'>с </td><td><input class=\"edit\" name=\"" + this.NameTable
                            + this.IdClass + "_Min" + this.NameProperty + "\"\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass
                            + "_Min" + this.NameProperty + "\" style='width:100%'></td></tr>\r\n" +
                            "<tr><td>по </td><td  style='width:5%'><input class=\"edit\" name=\"" + this.NameTable + this.IdClass + "_Max"
                            + this.NameProperty + "\"\r\n" + "inmeta-param=\"" + this.NameTable + this.IdClass + "_Max" + this.NameProperty
                            + "\"style='width:100%'></td></tr>\r\n";
                    }
                }
                //
                if (this.type == "boolean")
                {
                    HtmlDocument = HtmlDocument.Substring(0, HtmlDocument.IndexOf("<tr>"));
                    HtmlDocument += "<tr><td style=\"width:2%\"><input type=\"checkbox\" id=\"" + this.NameTable + this.IdClass + "_"
                        + this.NameProperty + "\" elem-attr=\"checked\" inmeta-param=\"" + this.NameTable + this.IdClass + "_"
                        + this.NameProperty + "\"</td></tr><td>" + this.HTMLPropertyCaption + "</td>\r\n";
                }
                HtmlDocument += "</table>";
                return HtmlDocument;
            }
        }
        
        /// <summary>
        /// Выводит SQL код для текущего контрола
        /// </summary>
        public String GetSQLCodeControls
        {
            get
            {
                string driverName = session.Application.Settings.DbConfig.DriverName;
                string SqlCode = "";
                if (this.type == "uint8" || this.type == "int16" || this.type == "int32" || this.type == "single" ||
                    this.type == "double" || this.type == "currency" || this.type == "char")
                {
                    if (!this.checkSettingHtml[7] && !this.checkSettingHtml[8])
                    {
                        string sqlSing = "";
                        int i = 1;
                        while (!this.checkSettingHtml[i])
                            i++;
                        switch (i)
                        {
                            case 1: sqlSing = "="; break;
                            case 2: sqlSing = "<>"; break;
                            case 3: sqlSing = "<"; break;
                            case 4: sqlSing = "<="; break;
                            case 5: sqlSing = ">"; break;
                            case 6: sqlSing = ">="; break;
                        }
                        SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"\" then\r\n" +
                            "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                            this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " '\" & " + this.NameTable + this.IdClass + "_" +
                            this.NameProperty + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" + 
                            this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " '\" & " + 
                            this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"'\"\r\n" + "end if\r\n" + "end if\r\n";
                    }
                    else
                    {
                        //для свойств с предопределенными значениями
                        if (this.checkSettingHtml[8])
                        {
                            SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"-1\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() + 
                                this.IdClass + "].[" + this.NameProperty + "] = '\" & " + this.NameTable + this.IdClass + "_" +
                                this.NameProperty + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" + 
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] = '\" & " + this.NameTable + 
                                this.IdClass + "_" + this.NameProperty + " & \"'\"\r\n" + "end if\r\n" + "end if\r\n";
                        }
                        //для диапазона
                        else
                        {
                            SqlCode += "if " + this.NameTable + this.IdClass + "_Min" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] >= '\" & " + this.NameTable + this.IdClass + "_Min" +
                                this.NameProperty + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] >= '\" & " +
                                this.NameTable + this.IdClass + "_Min" + this.NameProperty + " & \"'\"\r\n" + "end if\r\n" + "end if\r\n" +
                                "if " + this.NameTable + this.IdClass + "_Max" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] <= '\" & " + this.NameTable + this.IdClass + "_Max" +
                                this.NameProperty + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] <= '\" & " +
                                this.NameTable + this.IdClass + "_Max" + this.NameProperty + " & \"'\"\r\n" + "end if\r\n" + "end if\r\n";
                        }
                    }
                }
                //
                if (this.type == "datetime")
                {
                    if (!this.checkSettingHtml[7])
                    {
                        string sqlSing = "";
                        int i = 1;
                        while (!this.checkSettingHtml[i])
                            i++;
                        switch (i)
                        {
                            case 1: sqlSing = "="; break;
                            case 2: sqlSing = "<>"; break;
                            case 3: sqlSing = "<"; break;
                            case 4: sqlSing = "<="; break;
                            case 5: sqlSing = ">"; break;
                            case 6: sqlSing = ">="; break;
                        }
                        if (driverName == "ADO.MSSQL")
                            SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " Convert(DateTime,'\" & " + this.NameTable + this.IdClass + "_" +
                                this.NameProperty + " & \"',104)\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " Convert(DateTime,'\" & " +
                                this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"',104)\"\r\n" + "end if\r\n" + "end if\r\n";
                        if (driverName == "ADO.ORACLE")
                            SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " TO_DATE('\" & " + this.NameTable + this.IdClass + "_" +
                                this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " TO_DATE('\" & " +
                                this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "end if\r\n" + "end if\r\n";
                    }
                    else
                    {
                        if (driverName == "ADO.MSSQL")
                            SqlCode += "if " + this.NameTable + this.IdClass + "_Min" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] >= Convert(DateTime,'\" & " + this.NameTable + this.IdClass + "_Min" +
                                this.NameProperty + " & \"',104)\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] >= Convert(DateTime,'\" & " +
                                this.NameTable + this.IdClass + "_Min" + this.NameProperty + " & \"',104)\"\r\n" + "end if\r\n" + "end if\r\n" +
                                "if " + this.NameTable + this.IdClass + "_Max" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] <= Convert(DateTime,'\" & " + this.NameTable + this.IdClass + "_Max" +
                                this.NameProperty + " & \"',104)\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] <= Convert(DateTime,'\" & " +
                                this.NameTable + this.IdClass + "_Max" + this.NameProperty + " & \"',104)\"\r\n" + "end if\r\n" + "end if\r\n";
                        if (driverName == "ADO.ORACLE")
                            SqlCode += "if " + this.NameTable + this.IdClass + "_Min" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] >= TO_DATE('\" & " + this.NameTable + this.IdClass + "_Min" +
                                this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] >= TO_DATE('\" & " +
                                this.NameTable + this.IdClass + "_Min" + this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "end if\r\n" + "end if\r\n" +
                                "if " + this.NameTable + this.IdClass + "_Max" + this.NameProperty + " <> \"\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] <= TO_DATE('\" & " + this.NameTable + this.IdClass + "_Max" +
                                this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] <= TO_DATE('\" & " +
                                this.NameTable + this.IdClass + "_Max" + this.NameProperty + " & \"', 'DD.MM.YYYY')\"\r\n" + "end if\r\n" + "end if\r\n";
                    }
                }
                //
                if (this.type == "boolean")
                {
                    SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " then\r\n" + 
                        "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                        this.IdClass + "].[" + this.NameProperty + "] = '1'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + 
                        "AND [" + this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] = '1'\"\r\n" + "end if\r\n" + 
                        "else\r\n" + "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                        this.IdClass + "].[" + this.NameProperty + "] = '0'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" +
                        "AND [" + this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] = '0'\"\r\n" + "end if\r\n" + "end if\r\n";
                }
                //
                if (this.type == "string" || this.type == "text")
                {
                    if (!this.checkSettingHtml[9])
                    {
                        if (!this.checkSettingHtml[8])
                        {
                            string sqlSing = "", sqlLike = "";
                            if (this.checkSettingHtml[1])
                            {
                                sqlSing = "=";
                                sqlLike = "LIKE";
                            }
                            if (this.checkSettingHtml[2])
                            {
                                sqlSing = "<>";
                                sqlLike = "NOT LIKE";
                            }
                            if (this.checkSettingHtml[0])
                            {
                                SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"\" then\r\n" +
                                    "if BuildingCheck" + this.NameTable + this.IdClass + "_" + this.NameProperty + " then\r\n" +
                                    "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                    this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " '\" & " + this.NameTable + this.IdClass + "_" +
                                    this.NameProperty + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                    this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlSing + " '\" & " +
                                    this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"'\"\r\n" + "end if\r\n" + "else\r\n" +
                                    "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                    this.IdClass + "].[" + this.NameProperty + "] " + sqlLike + " '%\" & " + this.NameTable + this.IdClass + "_" +
                                    this.NameProperty + " & \"%'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                    this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlLike + " '%\" & " +
                                    this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"%'\"\r\n" + "end if\r\n" + "end if\r\n" + "end if\r\n";
                            }
                            else
                            {
                                SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"\" then\r\n" +
                                    "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                    this.IdClass + "].[" + this.NameProperty + "] " + sqlLike + " '%\" & " + this.NameTable + this.IdClass + "_" +
                                    this.NameProperty + " & \"%'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                    this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] " + sqlLike + " '%\" & " +
                                    this.NameTable + this.IdClass + "_" + this.NameProperty + " & \"%'\"\r\n" + "end if\r\n" + "end if\r\n";
                            }
                        }
                        else //для свойств с предопределенными значениями
                        {
                            SqlCode += "if " + this.NameTable + this.IdClass + "_" + this.NameProperty + " <> \"-1\" then\r\n" +
                                "if WhereResult = \"\" then\r\n" + "WhereResult = \"" + "WHERE [" + this.NameTable.ToUpper() +
                                this.IdClass + "].[" + this.NameProperty + "] LIKE '%\" & " + this.NameTable + this.IdClass + "_" +
                                this.NameProperty + " & \"%'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + this.NameProperty + "] LIKE '%\" & " + this.NameTable +
                                this.IdClass + "_" + this.NameProperty + " & \"%'\"\r\n" + "end if\r\n" + "end if\r\n";
                        }
                    }
                    else //условия запроса для свойства-ассоциации
                    {
                        string nameClassAssociation = AssocClass;
                        string _name = nameClassAssociation.Replace("/", string.Empty) + this.Id;
                        if (!this.checkSettingHtml[10])
                        {
                            SqlCode += "if " + _name + " <> \"\" then\r\n" + "if WhereResult = \"\" then\r\n" + "WhereResult = \"" +
                                "WHERE [" + this.NameTable.ToUpper() + this.IdClass + "].[" + session[NameClass].Class.AllProperties.Need(NameProperty).DataField + 
                                "] = '\" & " + _name + " & \"'\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + session[NameClass].Class.AllProperties.Need(NameProperty).DataField + 
                                "] = '\" & " + _name + " & \"'\"\r\n" + "end if\r\n" + "end if\r\n";
                        }
                        else //для мультиселекта
                        {
                            SqlCode += "if " + _name + " <> \"\" then\r\n" + "if WhereResult = \"\" then\r\n" + "WhereResult = \"" +
                                "WHERE [" + this.NameTable.ToUpper() + this.IdClass + "].[" + session[NameClass].Class.AllProperties.Need(NameProperty).DataField +
                                "] IN ('\" & Join(Split(" + _name + ", \",\"), \"','\") & \"')\"\r\n" + "else\r\n" + "WhereResult = WhereResult & \"" + "AND [" +
                                this.NameTable.ToUpper() + this.IdClass + "].[" + session[NameClass].Class.AllProperties.Need(NameProperty).DataField +
                                "] IN ('\" & Join(Split(" + _name + ", \",\"), \"','\") & \"')\"\r\n" + "end if\r\n" + "end if\r\n";
                        }

                    }
                }
                return SqlCode;
            }
        }

        /// <summary>
        /// Выводит SQL код для текущего контрола
        /// </summary>
        public String GetSQLParametrs
        {
            get
            {
                string SqlParam = "Название: ";
                if (!this.checkSettingHtml[7] && !this.checkSettingHtml[9])
                {
                    if (this.checkSettingHtml[0])
                    {
                        SqlParam += "BuildingCheck" + this.NameTable + this.IdClass + "_" + this.NameProperty + "Тип данных: boolean\r\n";
                    }
                    SqlParam += this.NameTable + this.IdClass + "_" + this.NameProperty + "\r\n" + "Тип данных: " + this.type + "\r\n\r\n";
                }
                else
                {
                    if (this.checkSettingHtml[7])
                    {
                        SqlParam += this.NameTable + this.IdClass + "_Min" + this.NameProperty + "\r\n" + "Тип данных: " + this.type + "\r\n" +
                            "Название: " + this.NameTable + this.IdClass + "_Max" + this.NameProperty + "\r\n" + "Тип данных: " + this.type + "\r\n\r\n";
                    }
                    else
                    {
                        string nameClassAssociation = AssocClass;
                        string _name = nameClassAssociation.Replace("/", string.Empty) + this.Id;
                        SqlParam += _name + "\r\n" + "Тип данных: string\r\n" +
                            "Название: "+ _name + "View\r\n" + "Тип данных: string\r\n\r\n";
                    }
                }
                
                return SqlParam;
            }
        }


        /// <summary>
        /// Выводит имя класса
        /// </summary>
        public String GetNameClass { get { return this.NameClass; } }
        /// <summary>
        /// Выводит имя свойства
        /// </summary>
        public String GetNameProperty { get { return this.NameProperty; } }
        /// <summary>
        /// Выводит заголовок свойства
        /// </summary>
        public String GetNamePropertyCaption { get { return this.HTMLPropertyCaption; } }
        /// <summary>
        /// Выводит идентификатор свойства находящегося в дереве метаданных
        /// </summary>
        public Int32 GetId { get { return this.Id; } } 
        /// <summary>
        /// Выводит информацию о HTML коде формы
        /// </summary>
        /// <param name="info"></param>
        public static void SetInfo(string info)
        {
            try
            {
                string patch = System.IO.Path.GetTempPath() + @"\formsTemp.txt";
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(patch, false, Encoding.GetEncoding(1251)))
                    sw.Write(info.Trim());
                System.Diagnostics.Process.Start(patch);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }

    /// <summary>
    /// Храненит значение выпадающего списка
    /// </summary>
    struct ItemsList
    {
        /// <summary>
        /// Хранит имя находящегося в списке
        /// </summary>
        public String Name { get; set; }
        /// <summary>
        /// Хранит текущее значение свойства
        /// </summary>
        public String Value { get; set; }
        /// <summary>
        /// Хранит статус выбора загруженного по умолчанию свойства
        /// </summary>
        public Boolean Select { get; set; }
    }

    /// <summary>
    /// Сохраняет информацию нескольких полей класса, свойство которого перетаскиваем
    /// </summary>
    struct ClassInfo
    {
        /// <summary>
        /// Хранит информацию каждого Node дерева его объект
        /// </summary>
        public Object Tag { get; set; }
        /// <summary>
        /// Хранит информацию о родительском узле
        /// </summary>
        public Object ParentNode { get; set; }
        /// <summary>
        /// Хранит информацию идентификатор каждого нода
        /// </summary>
        public Object Id { get; set; }
        /// <summary>
        /// Идентифицирует свойство
        /// </summary>
        public Boolean Property { get; set; }
    }


}