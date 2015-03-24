namespace Lab7
{
    partial class frmTransform
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
            this.btnTransform = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.cmbXSLFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnTransform
            // 
            this.btnTransform.Location = new System.Drawing.Point(356, 414);
            this.btnTransform.Name = "btnTransform";
            this.btnTransform.Size = new System.Drawing.Size(135, 23);
            this.btnTransform.TabIndex = 1;
            this.btnTransform.Text = "Generate Html Document";
            this.btnTransform.UseVisualStyleBackColor = true;
            this.btnTransform.Click += new System.EventHandler(this.btnTransform_Click);
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(39, 58);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(774, 350);
            this.web.TabIndex = 2;
            // 
            // cmbXSLFiles
            // 
            this.cmbXSLFiles.FormattingEnabled = true;
            this.cmbXSLFiles.Items.AddRange(new object[] {
            "List",
            "Tabular"});
            this.cmbXSLFiles.Location = new System.Drawing.Point(370, 31);
            this.cmbXSLFiles.Name = "cmbXSLFiles";
            this.cmbXSLFiles.Size = new System.Drawing.Size(121, 21);
            this.cmbXSLFiles.TabIndex = 3;
            this.cmbXSLFiles.SelectedValueChanged += new System.EventHandler(this.cmbXSLFiles_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Format:";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "(*.html)|*.html";
            // 
            // frmTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 489);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbXSLFiles);
            this.Controls.Add(this.web);
            this.Controls.Add(this.btnTransform);
            this.Name = "frmTransform";
            this.Text = "Transfrom Xml";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransform;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.ComboBox cmbXSLFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

