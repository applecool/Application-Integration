﻿namespace Lab2
{
    partial class LangaugeValidation
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
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnLoadXml = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnLoadXSD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.Enabled = false;
            this.btnValidate.Location = new System.Drawing.Point(75, 228);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(132, 23);
            this.btnValidate.TabIndex = 7;
            this.btnValidate.Text = "Start Validation";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnLoadXml
            // 
            this.btnLoadXml.Location = new System.Drawing.Point(75, 166);
            this.btnLoadXml.Name = "btnLoadXml";
            this.btnLoadXml.Size = new System.Drawing.Size(132, 23);
            this.btnLoadXml.TabIndex = 6;
            this.btnLoadXml.Text = "Load XML";
            this.btnLoadXml.UseVisualStyleBackColor = true;
            this.btnLoadXml.Click += new System.EventHandler(this.btnLoadXml_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Choose XML File";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Title = "Choose DTD File";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Staus of Parsing:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(24, 136);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 13);
            this.lblStatus.TabIndex = 10;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(12, 35);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(254, 88);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.Text = "";
            // 
            // btnLoadXSD
            // 
            this.btnLoadXSD.Location = new System.Drawing.Point(75, 199);
            this.btnLoadXSD.Name = "btnLoadXSD";
            this.btnLoadXSD.Size = new System.Drawing.Size(132, 23);
            this.btnLoadXSD.TabIndex = 6;
            this.btnLoadXSD.Text = "Load XSD";
            this.btnLoadXSD.UseVisualStyleBackColor = true;
            this.btnLoadXSD.Click += new System.EventHandler(this.btnLoadXsd_Click);
            // 
            // LangaugeValidation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 268);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnLoadXSD);
            this.Controls.Add(this.btnLoadXml);
            this.Name = "LangaugeValidation";
            this.Text = "LangaugeValidation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnLoadXml;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnLoadXSD;
    }
}