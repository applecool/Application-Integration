namespace Lab5
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxUses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxStandards = new System.Windows.Forms.ListBox();
            this.chkdListProperties = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_loadInDB = new System.Windows.Forms.Button();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Language :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IntendedUses";
            // 
            // listBoxUses
            // 
            this.listBoxUses.FormattingEnabled = true;
            this.listBoxUses.Location = new System.Drawing.Point(86, 80);
            this.listBoxUses.Name = "listBoxUses";
            this.listBoxUses.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxUses.Size = new System.Drawing.Size(154, 56);
            this.listBoxUses.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Standard";
            // 
            // listBoxStandards
            // 
            this.listBoxStandards.FormattingEnabled = true;
            this.listBoxStandards.Location = new System.Drawing.Point(86, 154);
            this.listBoxStandards.Name = "listBoxStandards";
            this.listBoxStandards.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxStandards.Size = new System.Drawing.Size(154, 56);
            this.listBoxStandards.TabIndex = 2;
            // 
            // chkdListProperties
            // 
            this.chkdListProperties.CheckOnClick = true;
            this.chkdListProperties.FormattingEnabled = true;
            this.chkdListProperties.Items.AddRange(new object[] {
            "Imperative",
            "Object-Oriented",
            "Functional",
            "Procedural",
            "Generic",
            "Reflective",
            "Event-Driven"});
            this.chkdListProperties.Location = new System.Drawing.Point(86, 223);
            this.chkdListProperties.MultiColumn = true;
            this.chkdListProperties.Name = "chkdListProperties";
            this.chkdListProperties.Size = new System.Drawing.Size(246, 64);
            this.chkdListProperties.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Applies :";
            // 
            // btn_loadInDB
            // 
            this.btn_loadInDB.Location = new System.Drawing.Point(116, 316);
            this.btn_loadInDB.Name = "btn_loadInDB";
            this.btn_loadInDB.Size = new System.Drawing.Size(75, 23);
            this.btn_loadInDB.TabIndex = 4;
            this.btn_loadInDB.Text = "Load in DB";
            this.btn_loadInDB.UseVisualStyleBackColor = true;
            this.btn_loadInDB.Click += new System.EventHandler(this.btn_loadInDB_Click);
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(86, 31);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(154, 21);
            this.cmbLanguage.TabIndex = 6;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(21, 299);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 347);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btn_loadInDB);
            this.Controls.Add(this.chkdListProperties);
            this.Controls.Add(this.listBoxStandards);
            this.Controls.Add(this.listBoxUses);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Load Languages";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxUses;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxStandards;
        private System.Windows.Forms.CheckedListBox chkdListProperties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_loadInDB;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lblError;
    }
}

