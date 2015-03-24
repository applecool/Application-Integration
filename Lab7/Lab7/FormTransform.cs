using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;       // needed
using System.Xml.Xsl;   // needed

namespace Lab7
{
    public partial class frmTransform : Form
    {
        string XML_SOURCE ;
        string xslFile,  outputFile;       

        public frmTransform()
        {
            XML_SOURCE = Application.StartupPath + @"\..\..\..\Languages.xml";
            InitializeComponent();           
        }

        // btnTransform click event handler
        private void btnTransform_Click(object sender, EventArgs e)
        {
            
            if (cmbXSLFiles.SelectedItem == null)
            {
                MessageBox.Show("Please select a file in the combobox!");
                return;
            }
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                outputFile = saveFileDialog1.FileName;
                performTransformation();
            }
        }

        // do the transformation
        private void performTransformation()
        {
            XslCompiledTransform xslTransform = new XslCompiledTransform();
            XsltSettings settings = new XsltSettings(false, true);

            // load xsl stylesheet
            xslTransform.Load(xslFile, settings, null);

            // tranform the source file using the stylesheet
            xslTransform.Transform(XML_SOURCE,
                 outputFile);

            // display the resulting file in the webbrowser control
            web.Url = new Uri(outputFile);
            MessageBox.Show("Html Document: "+outputFile+" created Successully.","Status:",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // construct the paths for xsl and output file
        private void cmbXSLFiles_SelectedValueChanged(object sender, EventArgs e)
        {
            // get the selected item from the combobox
            string selectedFormat = ((ComboBox)sender).SelectedItem.ToString();

               
            // get the xsl file name
            if(selectedFormat.Equals("List"))
            xslFile = Application.StartupPath + @"\..\..\..\Languages_List.xsl";
            else if (selectedFormat.Equals("Tabular"))
                xslFile = Application.StartupPath + @"\..\..\..\Languages_Table.xsl";
           
           
        }

       
    }
}