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
using MSXML2;

namespace Lab6
{
    public partial class frmLanguages : Form
    {
        //path to the xml document
        string XML_FILE_PATH = Application.StartupPath + @"\..\..\..\Languages.xml";
        private Hashtable useMap, standardMap, propertyMap;
        MyContentHandler contentHandler;
        public frmLanguages()
        {
            useMap = new Hashtable();
            standardMap = new Hashtable();
            propertyMap = new Hashtable();
            InitializeComponent();
            processXml();
            useMap = contentHandler.getUsesMap();
            standardMap = contentHandler.getstandardsMap();
            propertyMap = contentHandler.getpropertiesMap();
            loadLanguages();
            loadIntendedUses();
            loadStandardTypes();

        }

        private void processXml()
        {
            // declare objects of SAXXMLReader, MyContentHandler, and MyErrorHandler
            SAXXMLReader reader = new SAXXMLReader();
            contentHandler = new MyContentHandler(this);
            MyErrorHandler errorHandler = new MyErrorHandler(this);

            reader.contentHandler = contentHandler;  // assign contentHandler object to contentHandler property
            reader.errorHandler = errorHandler;  // assign errorHandler object to errorHandler property

            try
            {
                reader.parseURL(XML_FILE_PATH); //parse/process the xml doc located at xmlURL
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadLanguages()
        {
            cmbLanguage.Items.AddRange(contentHandler.getLanguages().ToArray());
        }

        private void loadIntendedUses()
        {
            listBoxUses.Items.AddRange(contentHandler.getUses().ToArray());
        }

        private void loadStandardTypes()
        {
            listBoxStandards.Items.AddRange(contentHandler.getStandards().ToArray());
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            setSelectionforIntendedUses();
            setSelectionforStandardTypes();
            setSelectionforAppliedProperties();
            lblError.Text = "";
        }        
       
        private void setSelectionforIntendedUses()
        {
            listBoxUses.ClearSelected();
            populateSelection(useMap[cmbLanguage.Text].ToString().Split(' '), listBoxUses, 1);
        }

        private void setSelectionforStandardTypes()
        {
            listBoxStandards.ClearSelected();
            populateSelection(standardMap[cmbLanguage.Text].ToString().Split(' '), listBoxStandards, 2);
        }

        private void setSelectionforAppliedProperties()
        {
            while (chkdListProperties.CheckedIndices.Count > 0)
                chkdListProperties.SetItemChecked(chkdListProperties.CheckedIndices[0], false);
            string[] properties = propertyMap[cmbLanguage.Text].ToString().Split(',');
            for (int i = 0; i < properties.Count(); i++)
                if (properties[i] != "")
                    chkdListProperties.SetItemChecked(i, true);
        }

        private void SetSelectedBreakType(ListBox lb, string value)
        {
            lb.SelectedIndices.Add(int.Parse(value) - 1);
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
                    if (db1.getCount("select count(*) from uses where use='" + use + "'") == 0)
                    {
                        db1.ExecNonQuery("insert into uses values(" + (useid + 1) + ",'" + use + "')");
                    }
                }
                foreach (string standard in listBoxStandards.SelectedItems)
                {
                    int standardid = db1.getCount("select count(*) from standard");
                    if (db1.getCount("select count(*) from standard where type='" + standard + "'") == 0)
                    {
                        db1.ExecNonQuery("insert into standard values(" + (standardid + 1) + ",'" + standard + "')");
                    }
                }
                int languageid = db1.getCount("select count(*) from language ;");
             

                foreach (int use in listBoxUses.SelectedIndices)
                {
                    foreach (int standard in listBoxStandards.SelectedIndices)
                    {
                        languageid = languageid + 1;
                        db1.ExecNonQuery("insert into language (languageid,name,intendeduseid,standardtypeid) values(" + (languageid) + ",'" + cmbLanguage.Text + "'," + (use + 1) + "," + (standard + 1) + ");");                        
                    }                    
                }
                for (int i = 0; i < chkdListProperties.CheckedItems.Count; i++)
                {
                    if (chkdListProperties.CheckedItems.Contains("Imperative"))
                    {
                        db1.ExecNonQuery("update language set [imperative]='Yes' where name='" + cmbLanguage.Text + "'");
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

        private bool validateLanguageName()
        {
            db db1 = new db();

            if (cmbLanguage.Text == "")
            {
                lblError.Text = "*Please Choose the Language Name";
                return false;
            }
            if (db1.getCount("select count(*) from language where name='" + cmbLanguage.Text + "'") > 0)
            {
                lblError.Text = "Language Already added.";
                return false;
            }
            return true;
        }

    }

}