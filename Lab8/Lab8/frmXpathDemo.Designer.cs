namespace Lab8
{
    partial class frmXpathDemo
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
            this.cboElement = new System.Windows.Forms.ComboBox();
            this.cboElementValues = new System.Windows.Forms.ComboBox();
            this.lblElement = new System.Windows.Forms.Label();
            this.lblElementValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.web = new System.Windows.Forms.WebBrowser();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboElement
            // 
            this.cboElement.FormattingEnabled = true;
            this.cboElement.Items.AddRange(new object[] {
            "Language",
            "Intended Use",
            "Standard"});
            this.cboElement.Location = new System.Drawing.Point(149, 43);
            this.cboElement.Name = "cboElement";
            this.cboElement.Size = new System.Drawing.Size(193, 21);
            this.cboElement.TabIndex = 0;
            this.cboElement.SelectedIndexChanged += new System.EventHandler(this.cboElement_SelectedIndexChanged);
            // 
            // cboElementValues
            // 
            this.cboElementValues.FormattingEnabled = true;
            this.cboElementValues.Location = new System.Drawing.Point(495, 43);
            this.cboElementValues.Name = "cboElementValues";
            this.cboElementValues.Size = new System.Drawing.Size(153, 21);
            this.cboElementValues.TabIndex = 0;
            this.cboElementValues.SelectedIndexChanged += new System.EventHandler(this.cboElementValues_SelectedIndexChanged);
            // 
            // lblElement
            // 
            this.lblElement.AutoSize = true;
            this.lblElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElement.Location = new System.Drawing.Point(40, 45);
            this.lblElement.Name = "lblElement";
            this.lblElement.Size = new System.Drawing.Size(87, 17);
            this.lblElement.TabIndex = 1;
            this.lblElement.Text = "Select From:";
            // 
            // lblElementValue
            // 
            this.lblElementValue.AutoSize = true;
            this.lblElementValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElementValue.Location = new System.Drawing.Point(417, 45);
            this.lblElementValue.Name = "lblElementValue";
            this.lblElementValue.Size = new System.Drawing.Size(51, 17);
            this.lblElementValue.TabIndex = 1;
            this.lblElementValue.Text = "Select:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selected Language(s):";
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(33, 98);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(774, 333);
            this.web.TabIndex = 3;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(40, 78);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(152, 17);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "Selected Language(s):";
            // 
            // frmXpathDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 482);
            this.Controls.Add(this.web);
            this.Controls.Add(this.lblElementValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblElement);
            this.Controls.Add(this.cboElementValues);
            this.Controls.Add(this.cboElement);
            this.Name = "frmXpathDemo";
            this.Text = " ITS 46200 - Lab8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboElement;
        private System.Windows.Forms.ComboBox cboElementValues;
        private System.Windows.Forms.Label lblElement;
        private System.Windows.Forms.Label lblElementValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Label lblData;
    }
}

