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
namespace ProcessingDom
{
    public partial class Form1 : Form
    {
        // path to the xml document
        const string XML_FILE_PATH = "..\\..\\Resources\\Languages.xml";
        public List<String> langList = new List<string>();
        public Hashtable UsesMAP, StandardsMAP;
     
        public Form1()
        {
            InitializeComponent();
            loadIntendedUses();
            loadStandardTypes();
            loadLanguages();

        }

        private void loadLanguages()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList languagesList = root.GetElementsByTagName("language");

            for (int i = 0; i < languagesList.Count; i++)
            {
                langList.Add(languagesList.Item(i).FirstChild.InnerText);
            }
        }

        private void loadIntendedUses()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode uses = root.LastChild.PreviousSibling;

            XmlElement usesElement = (XmlElement)uses;
            XmlNodeList usesList = usesElement.GetElementsByTagName("use");
            UsesMAP = new Hashtable();
            for (int i = 0; i < usesList.Count; i++)
            {
                listBoxUses.Items.Add(usesList.Item(i).InnerText);
                UsesMAP.Add(usesList.Item(i).Attributes.GetNamedItem("uid").Value, usesList.Item(i).InnerText);
            }

        }

        private void loadStandardTypes()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH);

            XmlElement root = xmlDoc.DocumentElement;
            XmlNode standards = root.LastChild;

            XmlElement standardsElement = (XmlElement)standards;
            XmlNodeList standardsList = standardsElement.GetElementsByTagName("type");
            StandardsMAP = new Hashtable();
            for (int i = 0; i < standardsList.Count; i++)
            {
                listBoxStandards.Items.Add(standardsList.Item(i).InnerText);
                StandardsMAP.Add(standardsList.Item(i).Attributes.GetNamedItem("tid").Value, standardsList.Item(i).InnerText);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(XML_FILE_PATH); // load xml document from file system

            XmlElement root = xmlDoc.DocumentElement;
            // go to language element/node
            XmlNode languagesNode = root.FirstChild;
            XmlNode usesNode = root.LastChild.PreviousSibling;
            XmlNode standardsNode = root.LastChild;
            if (validateLanguageName())
            {
                XmlElement newLanguageElement = xmlDoc.CreateElement("language");
                newLanguageElement.SetAttribute("id","_"+(root.ChildNodes.Count -1).ToString());

                XmlElement newNameElement = xmlDoc.CreateElement("name");
                newNameElement.InnerText = txtLanguage.Text;
                XmlElement newImperativeElement, newObjectOrientedElement, newFunctionalElement, newProceduralElement, newGenericElement,
                    newReflectiveElement, newEventDriven;
                newImperativeElement = xmlDoc.CreateElement("imperative");
                newObjectOrientedElement = xmlDoc.CreateElement("object-oriented");
                newFunctionalElement = xmlDoc.CreateElement("functional");
                newGenericElement = xmlDoc.CreateElement("generic");
                newProceduralElement = xmlDoc.CreateElement("procedural");
                newReflectiveElement = xmlDoc.CreateElement("reflective");
                newEventDriven = xmlDoc.CreateElement("event-driven");
                for (int i = 0; i < chkdListProperties.CheckedItems.Count; i++)
                {
                    if (chkdListProperties.CheckedItems.Contains("Imperative"))
                    {
                        newImperativeElement.InnerText = "Yes"; 
                    }
                    if (chkdListProperties.CheckedItems.Contains("Object-Oriented"))
                    {
                        newObjectOrientedElement.InnerText = "Yes";
                    }
                    if (chkdListProperties.CheckedItems.Contains("Functional"))
                    {
                        newFunctionalElement.InnerText = "Yes";
                    }
                    if (chkdListProperties.CheckedItems.Contains("Generic"))
                    {
                        newGenericElement.InnerText = "Yes"; 
                    }
                    if (chkdListProperties.CheckedItems.Contains("Procedural"))
                    {
                        newProceduralElement.InnerText = "Yes"; 
                    }
                    if (chkdListProperties.CheckedItems.Contains("Reflective"))
                    {
                        newReflectiveElement.InnerText = "Yes"; 
                    }
                    if (chkdListProperties.CheckedItems.Contains("Event-Driven"))
                    {
                        newEventDriven.InnerText = "Yes"; 
                    }
                }

                String[] intededuses = txtUses.Text.Trim().Split('\n');

                foreach (string use in intededuses)
                {
                    if (!UsesMAP.ContainsValue(use.TrimEnd('\r')))
                    {
                        XmlElement useElement = xmlDoc.CreateElement("use");
                        useElement.SetAttribute("uid", "_" + (UsesMAP.Count + 1));
                        useElement.InnerText = use.TrimEnd('\r');
                        UsesMAP.Add("_" + (UsesMAP.Count + 1), use.TrimEnd('\r'));
                        usesNode.AppendChild(useElement);
                    }
                    else if(use!="")
                    {
                        SetSelectedBreakType(listBoxUses, use.TrimEnd('\r'));
                    }
                    
                }
                String[] standardtypes = txtStandards.Text.Trim().Split('\n');

                foreach (string type in standardtypes)
                {
                    if (!StandardsMAP.ContainsValue(type.TrimEnd('\r')))
                    {
                        XmlElement standardtype = xmlDoc.CreateElement("type");
                        standardtype.SetAttribute("tid", "_0" + (StandardsMAP.Count + 1));
                        standardtype.InnerText = type.TrimEnd('\r');
                        StandardsMAP.Add("_0" + (StandardsMAP.Count + 1), type.TrimEnd('\r'));
                        standardsNode.AppendChild(standardtype);
                    }
                    else if(type!="")
                    {
                        SetSelectedBreakType(listBoxStandards, type.TrimEnd('\r'));
                    }
                }
                String useids="";

                foreach (var item in listBoxUses.SelectedItems)
                {
                    foreach (DictionaryEntry use in UsesMAP)
                    {
                        if (item.ToString().Equals(use.Value))
                        {
                            useids += use.Key + " ";
                        }
                    }
                }
             
                XmlElement IntendedUsesElement = xmlDoc.CreateElement("intendeduses");
                XmlElement IntendedUseElement = xmlDoc.CreateElement("intendeduse");
                IntendedUseElement.SetAttribute("id",useids.TrimEnd());
             
                String standardids = "";
                foreach (var item in listBoxStandards.SelectedItems)
                {
                    foreach (DictionaryEntry standard in StandardsMAP)
                    {
                        if (item.ToString().Equals(standard.Value))
                        {
                            standardids += standard.Key + " ";
                        }
                    }
                }
                XmlElement standardtypesElement = xmlDoc.CreateElement("standardtypes");
                XmlElement standardtypeElement = xmlDoc.CreateElement("standardtype");
                standardtypeElement.SetAttribute("id", standardids.TrimEnd());

                standardtypesElement.AppendChild(standardtypeElement);
                IntendedUsesElement.AppendChild(IntendedUseElement);
                // append title to language
                newLanguageElement.AppendChild(newNameElement);
                newLanguageElement.AppendChild(IntendedUsesElement);
                newLanguageElement.AppendChild(newImperativeElement);
                newLanguageElement.AppendChild(newObjectOrientedElement);
                newLanguageElement.AppendChild(newFunctionalElement);
                newLanguageElement.AppendChild(newProceduralElement);
                newLanguageElement.AppendChild(newGenericElement);
                newLanguageElement.AppendChild(newReflectiveElement);
                newLanguageElement.AppendChild(newEventDriven);
                newLanguageElement.AppendChild(standardtypesElement);
                // append course to courses
                root.PrependChild(newLanguageElement);

                // save the changes
                xmlDoc.Save(XML_FILE_PATH);

                langList.Add(txtLanguage.Text);

                txtLanguage.Text = "";
                txtStandards.Text = "";
                txtUses.Text = "";
                listBoxStandards.ClearSelected();
                listBoxUses.ClearSelected();
                chkdListProperties.ClearSelected();
                MessageBox.Show("Complete!");
            }
        }

        private bool validateLanguageName()
        {
            if (txtLanguage.Text == "")
            {
                lblError.Text = "Please enter the Language Name";
                return false;
            }
            if (langList.Contains(txtLanguage.Text))
            {
                lblError.Text = "Language Already Exists";
                return false;
            }

            return true;
        }
        private void SetSelectedBreakType(ListBox lb, string value)
        {
            for (int i = 0; i < lb.Items.Count; i++)
            {
               
                if (lb.Items[i].Equals(value))
                {
                    lb.SelectedIndices.Add(i);
                    break;
                }
            }
        }

        
    }
}
