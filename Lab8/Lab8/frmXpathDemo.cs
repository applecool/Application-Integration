using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;
using System.IO;

namespace Lab8
{
    public partial class frmXpathDemo : Form
    {
        XmlDocument xmlDoc;
        string XML_SOURCE;
        string xslFile, outputFile;

        public frmXpathDemo()
        {
            InitializeComponent();
            xmlDoc = new XmlDocument();
            XML_SOURCE = Application.StartupPath + @"\..\..\..\Languages.xml";
            xslFile = Application.StartupPath + @"\..\..\..\Languages_Table.xsl";
            outputFile = Application.StartupPath + @"\..\..\..\Languages.html";
            xmlDoc.Load(XML_SOURCE);
            updateXSL("languages/language");
        }

        private void cboElement_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboElement.SelectedItem.ToString())
            {
                case "Language":
                    loadElements("language/name");
                    break;
                case "Intended Use":
                    loadElements("uses/use");
                    break;
                case "Standard":
                    loadElements("standards/type");
                    break;
                default:
                    break;
            }
        }

        private void loadElements(string element)
        {
            XmlNodeList lst = xmlDoc.SelectNodes("//" + element);

            cboElementValues.Items.Clear();

            foreach (XmlNode item in lst)
            {
                cboElementValues.Items.Add(item.InnerText);
            }

        }

        private void cboElementValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboElement.SelectedItem.ToString())
            {
                case "Language":
                    updateXSL("languages/language[name='" + cboElementValues.SelectedItem.ToString() + "']");
                    break;
                case "Intended Use":
                    updateXSL("languages/language[intendeduses/intendeduse/@id='_" + (cboElementValues.SelectedIndex + 1).ToString() + "']");
                    break;
                case "Standard":
                    updateXSL("languages/language[standardtypes/standardtype/@id='_0" + (cboElementValues.SelectedIndex + 1).ToString() + "']");
                    break;
                default:
                    displayLanguage();
                    break;
            }
        }

        private void updateXSL(string xPath)
        {
            XmlDocument xslDoc = new XmlDocument();
            xslDoc.Load(xslFile);
            XmlNamespaceManager nsMgr = new XmlNamespaceManager(xslDoc.NameTable);
            nsMgr.AddNamespace("xsl", "http://www.w3.org/1999/XSL/Transform");

            XmlNode param_path = xslDoc.SelectSingleNode(@"/xsl:transform/xsl:param[@name='elementPath']", nsMgr);

            param_path.Attributes["select"].Value = xPath;
            xslDoc.Save(xslFile);

            displayLanguage();
        }

        private void displayLanguage()
        {
            XslCompiledTransform xslTransform = new XslCompiledTransform();
            XsltSettings settings = new XsltSettings(false, true);

            // load xsl stylesheet
            xslTransform.Load(xslFile, settings, null);

            // tranform the source file using the stylesheet
            xslTransform.Transform(XML_SOURCE, outputFile);

            // display the resulting file in the webbrowser control
            web.Url = new Uri(outputFile);
        }

    }
}
