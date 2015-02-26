using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace Lab5
{
    public partial class Form1 : Form
    {
        //path to the xml document
        const string XML_FILE_PATH = "..\\..\\Resources\\Languages.xml";
        public List<String> UsesMAP, StandardsMAP = new List<string>();

        public Form1()
        {
            InitializeComponent();
            loadIntendedUsesfrmXml();
            loadStandardTypesfrmXml();
            loadLanguagesfrmXml();
        }

        private void loadLanguagesfrmXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList languagesList = root.GetElementsByTagName("language");

            for (int i = 0; i < languagesList.Count; i++)
            {
                cmbLanguage.Items.Add(languagesList.Item(i).FirstChild.InnerText);
            }
        }

        private void loadIntendedUsesfrmXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode uses = root.LastChild.PreviousSibling;

            XmlElement usesElement = (XmlElement)uses;
            XmlNodeList usesList = usesElement.GetElementsByTagName("use");

            for (int i = 0; i < usesList.Count; i++)
            {
                listBoxUses.Items.Add(usesList.Item(i).InnerText);
            }

        }

        private void loadStandardTypesfrmXml()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode standards = root.LastChild;

            XmlElement standardsElement = (XmlElement)standards;
            XmlNodeList standardsList = standardsElement.GetElementsByTagName("type");

            for (int i = 0; i < standardsList.Count; i++)
            {
                listBoxStandards.Items.Add(standardsList.Item(i).InnerText);
            }
        }

        private bool validateLanguageName()
        {
            db db1 = new db();

            if (cmbLanguage.Text == "")
            {
                lblError.Text = "*Please Choose the Language Name";
                return false;
            }
            if (db1.getCount("select count(*) from language where name='" + cmbLanguage.Text + "';") > 0)
            {
                lblError.Text = "Language Already added.";
                return false;
            }
            return true;
        }

        private void SetSelectedBreakType(ListBox lb, string value)
        {
            lb.SelectedIndices.Add(int.Parse(value) - 1);
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            getSelectedIntendedUses();
            getSelectedStandardTypes();
            getSelectedAppliedProperties();
            lblError.Text = "";
        }

        private void getSelectedAppliedProperties()
        {
            while (chkdListProperties.CheckedIndices.Count > 0)
                chkdListProperties.SetItemChecked(chkdListProperties.CheckedIndices[0], false);
            string selectedLang = cmbLanguage.Text;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH); // load xml document from file system

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList children = root.ChildNodes;

            for (int i = 0; i < children.Count; i++) // the count of nodes in the list
            {
                XmlElement element = (XmlElement)children.Item(i);
                if (element.Name.Equals("language"))
                {
                    if (children.Item(i).FirstChild.InnerText.Equals(selectedLang))
                    {
                        XmlNodeList children2 = children.Item(i).ChildNodes;
                        for (int j = 0; j < children2.Count; j++) // the count of nodes in the list
                        {
                            XmlElement element2 = (XmlElement)children2.Item(j);
                            if (element2.Name.Equals("imperative"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Imperative"), true);
                            }
                            if (element2.Name.Equals("object-oriented"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Object-Oriented"), true);
                            }
                            if (element2.Name.Equals("functional"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Functional"), true);
                            }
                            if (element2.Name.Equals("procedural"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Procedural"), true);
                            }
                            if (element2.Name.Equals("generic"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Generic"), true);
                            }
                            if (element2.Name.Equals("reflective"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Reflective"), true);
                            }
                            if (element2.Name.Equals("event-driven"))
                            {
                                if (children2.Item(j).InnerText.Equals("Yes")) chkdListProperties.SetItemChecked(chkdListProperties.Items.IndexOf("Event-Driven"), true);
                            }
                        }
                    }
                }
            }
        }

        private void getSelectedIntendedUses()
        {
            listBoxUses.ClearSelected();
            string selectedLang = cmbLanguage.Text;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH); // load xml document from file system

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList children = root.ChildNodes;
            string[] useids;
            for (int i = 0; i < children.Count; i++) // the count of nodes in the list
            {
                XmlElement element = (XmlElement)children.Item(i);
                if (element.Name.Equals("language"))
                {
                    if (children.Item(i).FirstChild.InnerText.Equals(selectedLang))
                    {
                        XmlNodeList intendedusesList = element.GetElementsByTagName("intendeduses");

                        // loop through all intendeduses nodes (elements)
                        for (int j = 0; j < intendedusesList.Count; j++)
                        {
                            XmlNode intendeduseNode = intendedusesList.Item(j);
                            useids = intendeduseNode.FirstChild.Attributes["id"].Value.Split(' ');
                            populateSelection(useids, listBoxUses, 1);
                            UsesMAP = useids.ToList();
                            break;
                        }
                    }
                }
            }
        }

        private void getSelectedStandardTypes()
        {
            listBoxStandards.ClearSelected();
            string selectedLang = cmbLanguage.Text;
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH); // load xml document from file system

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList children = root.ChildNodes;
            string[] standardtypesids;

            for (int i = 0; i < children.Count; i++) // the count of nodes in the list
            {
                XmlElement element = (XmlElement)children.Item(i);
                if (element.Name.Equals("language"))
                {
                    if (children.Item(i).FirstChild.InnerText.Equals(selectedLang))
                    {
                        XmlNodeList standardtypesList = element.GetElementsByTagName("standardtypes");

                        // loop through all standard nodes (elements)
                        for (int j = 0; j < standardtypesList.Count; j++)
                        {
                            XmlNode standardtypesNode = standardtypesList.Item(j);
                            standardtypesids = standardtypesNode.FirstChild.Attributes["id"].Value.Split(' ');
                            StandardsMAP = standardtypesids.ToList();
                            populateSelection(standardtypesids, listBoxStandards, 2);
                            break;
                        }
                    }
                }
            }
        }

        private void populateSelection(string[] ids, ListBox listBoxUses, int rmvStrt)
        {
            foreach (string useid in ids)
            {
                SetSelectedBreakType(listBoxUses, useid.Remove(0, rmvStrt));
            }
        }

        private void btn_loadInDB_Click(object sender, EventArgs e)
        {
            db db1 = new db();
            if (validateLanguageName())
            {
                foreach (string use in listBoxUses.SelectedItems)
                {
                    int useid = db1.getCount("select count(*) from uses");
                    if (db1.getCount("select count(*) from uses where use='" + use + "';") == 0)
                    {
                        db1.ExecNonQuery("insert into uses values(" + (useid + 1) + ",'" + use + "');");
                    }
                }
                foreach (string standard in listBoxStandards.SelectedItems)
                {
                    int standardid = db1.getCount("select count(*) from standard");
                    if (db1.getCount("select count(*) from standard where type='" + standard + "';") == 0)
                    {
                        db1.ExecNonQuery("insert into standard values(" + (standardid + 1) + ",'" + standard + "');");
                    }
                }
                int languageid = db1.getCount("select count(*) from language ;");
                languageid = languageid + 1;

                foreach (int use in listBoxUses.SelectedIndices)
                {
                    foreach (int standard in listBoxStandards.SelectedIndices)
                    {
                        db1.ExecNonQuery("insert into language (languageid,name,intendeduseid,standardtypeid) values(" + (languageid) + ",'" + cmbLanguage.Text + "'," + (use + 1) + "," + (standard + 1) + ");");
                    }
                    languageid = languageid + 1;
                }
                for (int i = 0; i < chkdListProperties.CheckedItems.Count; i++)
                {
                    if (chkdListProperties.CheckedItems.Contains("Imperative"))
                    {
                        db1.ExecNonQuery("update language set imperative='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Object-Oriented"))
                    {
                        db1.ExecNonQuery("update language set [object-oriented]='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Functional"))
                    {
                        db1.ExecNonQuery("update language set Functional='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Generic"))
                    {
                        db1.ExecNonQuery("update language set Generic='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Procedural"))
                    {
                        db1.ExecNonQuery("update language set Procedural='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Reflective"))
                    {
                        db1.ExecNonQuery("update language set Reflective='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                    if (chkdListProperties.CheckedItems.Contains("Event-Driven"))
                    {
                        db1.ExecNonQuery("update language set [Event-Driven]='Yes' where name='" + cmbLanguage.Text + "'");
                    }
                }

                MessageBox.Show("loaded " + cmbLanguage.Text + " language in db successfully");
            }

        }

    }

}