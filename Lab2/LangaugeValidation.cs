using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;           
using System.Xml.Schema;   

namespace Lab2
{
    public partial class LangaugeValidation : Form
    {
        String xmlFilename,xsdFilename;      
 
        public LangaugeValidation()
        {
            InitializeComponent();
            if (xsdFilename != null && xmlFilename!=null) btnValidate.Enabled = true;        
            else btnValidate.Enabled = false;          
        }

        private void btnLoadXml_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Begin Loading XML File";
            
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Open File 
                xmlFilename = openFileDialog1.FileName;
                lblStatus.Text = "Done Loading XML File";
            }
            if (xsdFilename != null && xmlFilename!=null) btnValidate.Enabled = true;
        
        }
        private void btnLoadXsd_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Begin Loading XSD File";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Open File 
                xsdFilename = openFileDialog1.FileName;
                lblStatus.Text = "Done Loading XSD File";
            }
            if (xsdFilename != null && xmlFilename != null) btnValidate.Enabled = true;

        } 
             
        private void btnValidate_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Starting Validation Process";
            txtMessage.Clear();
            validatingXMLWithXSD(xmlFilename,xsdFilename);
            lblStatus.Text = "Validation Process Done";
        }

        private void validatingXMLWithXSD(string fileFullPath, string pathXSD)
        {
            // Set the validation settings.
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.ValidationFlags |=
                XmlSchemaValidationFlags.ReportValidationWarnings;
            settings.ValidationEventHandler +=
                new ValidationEventHandler(ValidationCallBack);

            txtMessage.AppendText("Retrieving XSD - Please wait...\r\n");
            txtMessage.Update();

            XmlSchemaSet schemaSet = new XmlSchemaSet();       
            schemaSet.Add(null, pathXSD);
            settings.Schemas = schemaSet;

            // Create the XmlReader object.
            XmlReader reader;
            reader = XmlReader.Create(fileFullPath, settings);

            txtMessage.AppendText("Starting parsing...\r\n");
            // validate while reading/parsing... 
            while (reader.Read())
            {
                if (reader.IsStartElement())
                   txtMessage.AppendText(reader.LocalName + " START\r\n");
            };
          txtMessage.AppendText("End parsing...\r\n");
        }
        // Display any validation errors.
        private void ValidationCallBack(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
               txtMessage.AppendText( "Warning: Matching schema not found.  No validation occurred."
                    + e.Message + "\r\n", Color.Blue);
            else
                            
                txtMessage.AppendText("Validation Error: " + e.Message + "\r\n",Color.Red);              
        } 
  
    }

    //Display Font colored in RichTextBox
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}
