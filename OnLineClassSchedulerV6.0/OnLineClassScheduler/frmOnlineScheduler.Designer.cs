namespace OnLineClassScheduler
{
    partial class frmOnlineScheduler
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOnlineScheduler));
			this.BasicSearch = new System.Windows.Forms.TabPage();
			this.btnClearAll = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.gbxDAY = new System.Windows.Forms.GroupBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.pnlDaysBS = new System.Windows.Forms.Panel();
			this.cbxUBS = new System.Windows.Forms.CheckBox();
			this.cbxSBS = new System.Windows.Forms.CheckBox();
			this.cbxFBS = new System.Windows.Forms.CheckBox();
			this.cbxRBS = new System.Windows.Forms.CheckBox();
			this.cbxWBS = new System.Windows.Forms.CheckBox();
			this.cbxTBS = new System.Windows.Forms.CheckBox();
			this.cbxMBS = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCrsNoBS = new System.Windows.Forms.TextBox();
			this.txtTitleBS = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cboInstructorsBS = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cboLocationsBS = new System.Windows.Forms.ComboBox();
			this.cboCreditHrs2BS = new System.Windows.Forms.ComboBox();
			this.cboCreditHrs1BS = new System.Windows.Forms.ComboBox();
			this.cboStartTimeBS = new System.Windows.Forms.ComboBox();
			this.cboEndTimeBS = new System.Windows.Forms.ComboBox();
			this.cboSubjectsBS = new System.Windows.Forms.ComboBox();
			this.cboCrsTypesBS = new System.Windows.Forms.ComboBox();
			this.cboStatusBS = new System.Windows.Forms.ComboBox();
			this.cboTermsBS = new System.Windows.Forms.ComboBox();
			this.lblTerm2 = new System.Windows.Forms.Label();
			this.AdhocSearch = new System.Windows.Forms.TabPage();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cboTermsAS = new System.Windows.Forms.ComboBox();
			this.lblTerm = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.rdbtnCreditCoursesAS = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rdbtnCourseOfferAS = new System.Windows.Forms.RadioButton();
			this.lblSubject = new System.Windows.Forms.Label();
			this.lstSubjectsAS = new System.Windows.Forms.ListBox();
			this.lblCourseNo = new System.Windows.Forms.Label();
			this.txtCourseNoAS = new System.Windows.Forms.TextBox();
			this.txtCreditHoursAS = new System.Windows.Forms.TextBox();
			this.cboInstructorAS = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.rdbtnExcludeAS = new System.Windows.Forms.RadioButton();
			this.rdbtnIncludeAS = new System.Windows.Forms.RadioButton();
			this.lblLocation = new System.Windows.Forms.Label();
			this.cbxDistanceLearningAS = new System.Windows.Forms.CheckBox();
			this.lblPrimaryInstructor = new System.Windows.Forms.Label();
			this.lblCreditHours = new System.Windows.Forms.Label();
			this.lblStatusOfCourse = new System.Windows.Forms.Label();
			this.lblDistanceLearning = new System.Windows.Forms.Label();
			this.lblCourseOffering = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.cboCourseAS = new System.Windows.Forms.ComboBox();
			this.cboLocationsAS = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnAdhocSearch = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SearchInstructor = new System.Windows.Forms.TabPage();
			this.clearInstructorTab = new System.Windows.Forms.Button();
			this.SearchByInstructor = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label16 = new System.Windows.Forms.Label();
			this.pnlDays3 = new System.Windows.Forms.Panel();
			this.cboUSI = new System.Windows.Forms.CheckBox();
			this.cboSSI = new System.Windows.Forms.CheckBox();
			this.cboFSI = new System.Windows.Forms.CheckBox();
			this.cboRSI = new System.Windows.Forms.CheckBox();
			this.cboWSI = new System.Windows.Forms.CheckBox();
			this.cboTSI = new System.Windows.Forms.CheckBox();
			this.cboMSI = new System.Windows.Forms.CheckBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.cboInstructorsSI = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.cboStartTimeSI = new System.Windows.Forms.ComboBox();
			this.cboEndTimeSI = new System.Windows.Forms.ComboBox();
			this.KeywordSearch = new System.Windows.Forms.TabPage();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label32 = new System.Windows.Forms.Label();
			this.txtKeywordKS = new System.Windows.Forms.TextBox();
			this.label18 = new System.Windows.Forms.Label();
			this.pnlDaysKS = new System.Windows.Forms.Panel();
			this.cbxUKS = new System.Windows.Forms.CheckBox();
			this.cbxSKS = new System.Windows.Forms.CheckBox();
			this.cbxFKS = new System.Windows.Forms.CheckBox();
			this.cbxRKS = new System.Windows.Forms.CheckBox();
			this.cbxWKS = new System.Windows.Forms.CheckBox();
			this.cbxTKS = new System.Windows.Forms.CheckBox();
			this.cbxMKS = new System.Windows.Forms.CheckBox();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.cboStartTimeKS = new System.Windows.Forms.ComboBox();
			this.cboEndTimeKS = new System.Windows.Forms.ComboBox();
			this.cboTermsKS = new System.Windows.Forms.ComboBox();
			this.label31 = new System.Windows.Forms.Label();
			this.btnKeywordSearch = new System.Windows.Forms.Button();
			this.btnResetKS = new System.Windows.Forms.Button();
			this.SearchClasses = new System.Windows.Forms.TabPage();
			this.btnReset5 = new System.Windows.Forms.Button();
			this.btnSearchClasses = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.cboRoomSC = new System.Windows.Forms.ComboBox();
			this.cboTermsSC = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.pnlDaysSC = new System.Windows.Forms.Panel();
			this.cbxUSC = new System.Windows.Forms.CheckBox();
			this.cbxSSC = new System.Windows.Forms.CheckBox();
			this.cbxFSC = new System.Windows.Forms.CheckBox();
			this.cbxRSC = new System.Windows.Forms.CheckBox();
			this.cbxWSC = new System.Windows.Forms.CheckBox();
			this.cbxMSC = new System.Windows.Forms.CheckBox();
			this.cbxTSC = new System.Windows.Forms.CheckBox();
			this.label37 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.cboLocationsSC = new System.Windows.Forms.ComboBox();
			this.label40 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.cboStartTimeSC = new System.Windows.Forms.ComboBox();
			this.cboEndTimeSC = new System.Windows.Forms.ComboBox();
			this.BasicSearch.SuspendLayout();
			this.gbxDAY.SuspendLayout();
			this.pnlDaysBS.SuspendLayout();
			this.AdhocSearch.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SearchInstructor.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.pnlDays3.SuspendLayout();
			this.KeywordSearch.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.pnlDaysKS.SuspendLayout();
			this.SearchClasses.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.pnlDaysSC.SuspendLayout();
			this.SuspendLayout();
			// 
			// BasicSearch
			// 
			this.BasicSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BasicSearch.Controls.Add(this.btnClearAll);
			this.BasicSearch.Controls.Add(this.btnSearch);
			this.BasicSearch.Controls.Add(this.gbxDAY);
			this.BasicSearch.Location = new System.Drawing.Point(4, 22);
			this.BasicSearch.Name = "BasicSearch";
			this.BasicSearch.Padding = new System.Windows.Forms.Padding(3);
			this.BasicSearch.Size = new System.Drawing.Size(822, 582);
			this.BasicSearch.TabIndex = 1;
			this.BasicSearch.Text = "Basic Search";
			// 
			// btnClearAll
			// 
			this.btnClearAll.Location = new System.Drawing.Point(429, 546);
			this.btnClearAll.Name = "btnClearAll";
			this.btnClearAll.Size = new System.Drawing.Size(75, 23);
			this.btnClearAll.TabIndex = 14;
			this.btnClearAll.Text = "Reset";
			this.btnClearAll.UseVisualStyleBackColor = true;
			this.btnClearAll.Click += new System.EventHandler(this.btnClearBasicSearch_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(319, 546);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 23);
			this.btnSearch.TabIndex = 15;
			this.btnSearch.Text = "Submit";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnBasicSearch_Click);
			// 
			// gbxDAY
			// 
			this.gbxDAY.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gbxDAY.Controls.Add(this.label13);
			this.gbxDAY.Controls.Add(this.label12);
			this.gbxDAY.Controls.Add(this.pnlDaysBS);
			this.gbxDAY.Controls.Add(this.label7);
			this.gbxDAY.Controls.Add(this.label6);
			this.gbxDAY.Controls.Add(this.label11);
			this.gbxDAY.Controls.Add(this.label10);
			this.gbxDAY.Controls.Add(this.label9);
			this.gbxDAY.Controls.Add(this.label8);
			this.gbxDAY.Controls.Add(this.label15);
			this.gbxDAY.Controls.Add(this.label14);
			this.gbxDAY.Controls.Add(this.label3);
			this.gbxDAY.Controls.Add(this.txtCrsNoBS);
			this.gbxDAY.Controls.Add(this.txtTitleBS);
			this.gbxDAY.Controls.Add(this.label1);
			this.gbxDAY.Controls.Add(this.cboInstructorsBS);
			this.gbxDAY.Controls.Add(this.label4);
			this.gbxDAY.Controls.Add(this.label5);
			this.gbxDAY.Controls.Add(this.cboLocationsBS);
			this.gbxDAY.Controls.Add(this.cboCreditHrs2BS);
			this.gbxDAY.Controls.Add(this.cboCreditHrs1BS);
			this.gbxDAY.Controls.Add(this.cboStartTimeBS);
			this.gbxDAY.Controls.Add(this.cboEndTimeBS);
			this.gbxDAY.Controls.Add(this.cboSubjectsBS);
			this.gbxDAY.Controls.Add(this.cboCrsTypesBS);
			this.gbxDAY.Controls.Add(this.cboStatusBS);
			this.gbxDAY.Controls.Add(this.cboTermsBS);
			this.gbxDAY.Controls.Add(this.lblTerm2);
			this.gbxDAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbxDAY.Location = new System.Drawing.Point(52, 6);
			this.gbxDAY.Name = "gbxDAY";
			this.gbxDAY.Size = new System.Drawing.Size(712, 532);
			this.gbxDAY.TabIndex = 13;
			this.gbxDAY.TabStop = false;
			this.gbxDAY.Text = "Search Courses";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(452, 436);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(36, 20);
			this.label13.TabIndex = 15;
			this.label13.Text = "and";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(452, 482);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(36, 20);
			this.label12.TabIndex = 15;
			this.label12.Text = "and";
			// 
			// pnlDaysBS
			// 
			this.pnlDaysBS.Controls.Add(this.cbxUBS);
			this.pnlDaysBS.Controls.Add(this.cbxSBS);
			this.pnlDaysBS.Controls.Add(this.cbxFBS);
			this.pnlDaysBS.Controls.Add(this.cbxRBS);
			this.pnlDaysBS.Controls.Add(this.cbxWBS);
			this.pnlDaysBS.Controls.Add(this.cbxTBS);
			this.pnlDaysBS.Controls.Add(this.cbxMBS);
			this.pnlDaysBS.Location = new System.Drawing.Point(286, 342);
			this.pnlDaysBS.Name = "pnlDaysBS";
			this.pnlDaysBS.Size = new System.Drawing.Size(308, 29);
			this.pnlDaysBS.TabIndex = 14;
			// 
			// cbxUBS
			// 
			this.cbxUBS.AutoSize = true;
			this.cbxUBS.Location = new System.Drawing.Point(261, 3);
			this.cbxUBS.Name = "cbxUBS";
			this.cbxUBS.Size = new System.Drawing.Size(38, 21);
			this.cbxUBS.TabIndex = 0;
			this.cbxUBS.Text = "U";
			this.cbxUBS.UseVisualStyleBackColor = true;
			// 
			// cbxSBS
			// 
			this.cbxSBS.AutoSize = true;
			this.cbxSBS.Location = new System.Drawing.Point(218, 3);
			this.cbxSBS.Name = "cbxSBS";
			this.cbxSBS.Size = new System.Drawing.Size(37, 21);
			this.cbxSBS.TabIndex = 0;
			this.cbxSBS.Text = "S";
			this.cbxSBS.UseVisualStyleBackColor = true;
			// 
			// cbxFBS
			// 
			this.cbxFBS.AutoSize = true;
			this.cbxFBS.Location = new System.Drawing.Point(180, 3);
			this.cbxFBS.Name = "cbxFBS";
			this.cbxFBS.Size = new System.Drawing.Size(36, 21);
			this.cbxFBS.TabIndex = 0;
			this.cbxFBS.Text = "F";
			this.cbxFBS.UseVisualStyleBackColor = true;
			// 
			// cbxRBS
			// 
			this.cbxRBS.AutoSize = true;
			this.cbxRBS.Location = new System.Drawing.Point(134, 3);
			this.cbxRBS.Name = "cbxRBS";
			this.cbxRBS.Size = new System.Drawing.Size(38, 21);
			this.cbxRBS.TabIndex = 0;
			this.cbxRBS.Text = "R";
			this.cbxRBS.UseVisualStyleBackColor = true;
			// 
			// cbxWBS
			// 
			this.cbxWBS.AutoSize = true;
			this.cbxWBS.Location = new System.Drawing.Point(91, 3);
			this.cbxWBS.Name = "cbxWBS";
			this.cbxWBS.Size = new System.Drawing.Size(41, 21);
			this.cbxWBS.TabIndex = 0;
			this.cbxWBS.Text = "W";
			this.cbxWBS.UseVisualStyleBackColor = true;
			// 
			// cbxTBS
			// 
			this.cbxTBS.AutoSize = true;
			this.cbxTBS.Location = new System.Drawing.Point(49, 3);
			this.cbxTBS.Name = "cbxTBS";
			this.cbxTBS.Size = new System.Drawing.Size(37, 21);
			this.cbxTBS.TabIndex = 0;
			this.cbxTBS.Text = "T";
			this.cbxTBS.UseVisualStyleBackColor = true;
			// 
			// cbxMBS
			// 
			this.cbxMBS.AutoSize = true;
			this.cbxMBS.Location = new System.Drawing.Point(4, 3);
			this.cbxMBS.Name = "cbxMBS";
			this.cbxMBS.Size = new System.Drawing.Size(39, 21);
			this.cbxMBS.TabIndex = 0;
			this.cbxMBS.Text = "M";
			this.cbxMBS.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(73, 298);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(60, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Status:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(73, 252);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 20);
			this.label6.TabIndex = 12;
			this.label6.Text = "Course Type:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(73, 482);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(169, 20);
			this.label11.TabIndex = 12;
			this.label11.Text = "Credit Hours Between:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(73, 436);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(153, 20);
			this.label10.TabIndex = 12;
			this.label10.Text = "Start Time Between:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(73, 344);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(41, 20);
			this.label9.TabIndex = 12;
			this.label9.Text = "Day:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(73, 390);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(42, 20);
			this.label8.TabIndex = 12;
			this.label8.Text = "Title:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(475, 25);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(71, 15);
			this.label15.TabIndex = 12;
			this.label15.Text = "*(Required)";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(475, 209);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(0, 15);
			this.label14.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(73, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Course Number:";
			// 
			// txtCrsNoBS
			// 
			this.txtCrsNoBS.Location = new System.Drawing.Point(286, 205);
			this.txtCrsNoBS.Name = "txtCrsNoBS";
			this.txtCrsNoBS.Size = new System.Drawing.Size(172, 23);
			this.txtCrsNoBS.TabIndex = 13;
			// 
			// txtTitleBS
			// 
			this.txtTitleBS.Location = new System.Drawing.Point(286, 389);
			this.txtTitleBS.Name = "txtTitleBS";
			this.txtTitleBS.Size = new System.Drawing.Size(308, 23);
			this.txtTitleBS.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(73, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Subject(s):";
			// 
			// cboInstructorsBS
			// 
			this.cboInstructorsBS.FormattingEnabled = true;
			this.cboInstructorsBS.Location = new System.Drawing.Point(286, 158);
			this.cboInstructorsBS.Name = "cboInstructorsBS";
			this.cboInstructorsBS.Size = new System.Drawing.Size(308, 24);
			this.cboInstructorsBS.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(73, 114);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(74, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Location:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(73, 160);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(145, 20);
			this.label5.TabIndex = 7;
			this.label5.Text = "Name of Instructor:";
			// 
			// cboLocationsBS
			// 
			this.cboLocationsBS.FormattingEnabled = true;
			this.cboLocationsBS.Location = new System.Drawing.Point(286, 112);
			this.cboLocationsBS.Name = "cboLocationsBS";
			this.cboLocationsBS.Size = new System.Drawing.Size(308, 24);
			this.cboLocationsBS.TabIndex = 10;
			this.cboLocationsBS.SelectedIndexChanged += new System.EventHandler(this.cboLocationBS_SelectedIndexChanged);
			// 
			// cboCreditHrs2BS
			// 
			this.cboCreditHrs2BS.FormattingEnabled = true;
			this.cboCreditHrs2BS.Items.AddRange(new object[] {
            " 00.0",
            " 00.1",
            " 00.5",
            " 01.0",
            "01.5",
            "02.0",
            "02.5",
            "03.0",
            "03.5",
            "04.0",
            "05.0",
            "06.0",
            "07.0",
            "08.0",
            "09.0",
            "10.0",
            "12.0",
            "16.0"});
			this.cboCreditHrs2BS.Location = new System.Drawing.Point(515, 480);
			this.cboCreditHrs2BS.Name = "cboCreditHrs2BS";
			this.cboCreditHrs2BS.Size = new System.Drawing.Size(143, 24);
			this.cboCreditHrs2BS.TabIndex = 2;
			// 
			// cboCreditHrs1BS
			// 
			this.cboCreditHrs1BS.FormattingEnabled = true;
			this.cboCreditHrs1BS.Items.AddRange(new object[] {
            " 00.0",
            " 00.1",
            " 00.5",
            " 01.0",
            "01.5",
            "02.0",
            "02.5",
            "03.0",
            "03.5",
            "04.0",
            "05.0",
            "06.0",
            "07.0",
            "08.0",
            "09.0",
            "10.0",
            "12.0",
            "16.0"});
			this.cboCreditHrs1BS.Location = new System.Drawing.Point(286, 480);
			this.cboCreditHrs1BS.Name = "cboCreditHrs1BS";
			this.cboCreditHrs1BS.Size = new System.Drawing.Size(143, 24);
			this.cboCreditHrs1BS.TabIndex = 2;
			// 
			// cboStartTimeBS
			// 
			this.cboStartTimeBS.FormattingEnabled = true;
			this.cboStartTimeBS.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboStartTimeBS.Location = new System.Drawing.Point(286, 434);
			this.cboStartTimeBS.Name = "cboStartTimeBS";
			this.cboStartTimeBS.Size = new System.Drawing.Size(143, 24);
			this.cboStartTimeBS.TabIndex = 2;
			// 
			// cboEndTimeBS
			// 
			this.cboEndTimeBS.FormattingEnabled = true;
			this.cboEndTimeBS.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboEndTimeBS.Location = new System.Drawing.Point(515, 434);
			this.cboEndTimeBS.Name = "cboEndTimeBS";
			this.cboEndTimeBS.Size = new System.Drawing.Size(143, 24);
			this.cboEndTimeBS.TabIndex = 2;
			// 
			// cboSubjectsBS
			// 
			this.cboSubjectsBS.FormattingEnabled = true;
			this.cboSubjectsBS.Location = new System.Drawing.Point(286, 66);
			this.cboSubjectsBS.Name = "cboSubjectsBS";
			this.cboSubjectsBS.Size = new System.Drawing.Size(308, 24);
			this.cboSubjectsBS.TabIndex = 2;
			this.cboSubjectsBS.SelectedIndexChanged += new System.EventHandler(this.cboSubjectsBS_SelectedIndexChanged);
			// 
			// cboCrsTypesBS
			// 
			this.cboCrsTypesBS.FormattingEnabled = true;
			this.cboCrsTypesBS.Location = new System.Drawing.Point(286, 252);
			this.cboCrsTypesBS.Name = "cboCrsTypesBS";
			this.cboCrsTypesBS.Size = new System.Drawing.Size(172, 24);
			this.cboCrsTypesBS.TabIndex = 2;
			// 
			// cboStatusBS
			// 
			this.cboStatusBS.FormattingEnabled = true;
			this.cboStatusBS.Items.AddRange(new object[] {
            "Open",
            "Cancelled and Closed"});
			this.cboStatusBS.Location = new System.Drawing.Point(286, 296);
			this.cboStatusBS.Name = "cboStatusBS";
			this.cboStatusBS.Size = new System.Drawing.Size(172, 24);
			this.cboStatusBS.TabIndex = 2;
			// 
			// cboTermsBS
			// 
			this.cboTermsBS.FormattingEnabled = true;
			this.cboTermsBS.Location = new System.Drawing.Point(286, 20);
			this.cboTermsBS.Name = "cboTermsBS";
			this.cboTermsBS.Size = new System.Drawing.Size(172, 24);
			this.cboTermsBS.TabIndex = 2;
			this.cboTermsBS.SelectedIndexChanged += new System.EventHandler(this.cboTermsBS_SelectedIndexChanged);
			// 
			// lblTerm2
			// 
			this.lblTerm2.AutoSize = true;
			this.lblTerm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTerm2.Location = new System.Drawing.Point(73, 22);
			this.lblTerm2.Name = "lblTerm2";
			this.lblTerm2.Size = new System.Drawing.Size(49, 20);
			this.lblTerm2.TabIndex = 0;
			this.lblTerm2.Text = "Term:";
			// 
			// AdhocSearch
			// 
			this.AdhocSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.AdhocSearch.Controls.Add(this.groupBox1);
			this.AdhocSearch.Controls.Add(this.groupBox2);
			this.AdhocSearch.Controls.Add(this.btnReset);
			this.AdhocSearch.Controls.Add(this.btnAdhocSearch);
			this.AdhocSearch.Location = new System.Drawing.Point(4, 22);
			this.AdhocSearch.Name = "AdhocSearch";
			this.AdhocSearch.Padding = new System.Windows.Forms.Padding(3);
			this.AdhocSearch.Size = new System.Drawing.Size(822, 582);
			this.AdhocSearch.TabIndex = 0;
			this.AdhocSearch.Text = "Adhoc Search";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox1.Controls.Add(this.cboTermsAS);
			this.groupBox1.Controls.Add(this.lblTerm);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(55, 34);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(718, 100);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Please Select a Term";
			// 
			// cboTermsAS
			// 
			this.cboTermsAS.FormattingEnabled = true;
			this.cboTermsAS.Location = new System.Drawing.Point(371, 41);
			this.cboTermsAS.Name = "cboTermsAS";
			this.cboTermsAS.Size = new System.Drawing.Size(172, 24);
			this.cboTermsAS.TabIndex = 2;
			// 
			// lblTerm
			// 
			this.lblTerm.AutoSize = true;
			this.lblTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTerm.Location = new System.Drawing.Point(210, 41);
			this.lblTerm.Name = "lblTerm";
			this.lblTerm.Size = new System.Drawing.Size(49, 20);
			this.lblTerm.TabIndex = 0;
			this.lblTerm.Text = "Term:";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox2.Controls.Add(this.panel3);
			this.groupBox2.Controls.Add(this.panel2);
			this.groupBox2.Controls.Add(this.lblSubject);
			this.groupBox2.Controls.Add(this.lstSubjectsAS);
			this.groupBox2.Controls.Add(this.lblCourseNo);
			this.groupBox2.Controls.Add(this.txtCourseNoAS);
			this.groupBox2.Controls.Add(this.txtCreditHoursAS);
			this.groupBox2.Controls.Add(this.cboInstructorAS);
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Controls.Add(this.lblLocation);
			this.groupBox2.Controls.Add(this.cbxDistanceLearningAS);
			this.groupBox2.Controls.Add(this.lblPrimaryInstructor);
			this.groupBox2.Controls.Add(this.lblCreditHours);
			this.groupBox2.Controls.Add(this.lblStatusOfCourse);
			this.groupBox2.Controls.Add(this.lblDistanceLearning);
			this.groupBox2.Controls.Add(this.lblCourseOffering);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.cboCourseAS);
			this.groupBox2.Controls.Add(this.cboLocationsAS);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(55, 140);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(718, 401);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Select From Any";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.rdbtnCreditCoursesAS);
			this.panel3.Location = new System.Drawing.Point(372, 348);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 32);
			this.panel3.TabIndex = 8;
			// 
			// rdbtnCreditCoursesAS
			// 
			this.rdbtnCreditCoursesAS.AutoSize = true;
			this.rdbtnCreditCoursesAS.Location = new System.Drawing.Point(3, 10);
			this.rdbtnCreditCoursesAS.Name = "rdbtnCreditCoursesAS";
			this.rdbtnCreditCoursesAS.Size = new System.Drawing.Size(14, 13);
			this.rdbtnCreditCoursesAS.TabIndex = 5;
			this.rdbtnCreditCoursesAS.TabStop = true;
			this.rdbtnCreditCoursesAS.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rdbtnCourseOfferAS);
			this.panel2.Location = new System.Drawing.Point(372, 317);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(200, 26);
			this.panel2.TabIndex = 7;
			// 
			// rdbtnCourseOfferAS
			// 
			this.rdbtnCourseOfferAS.AutoSize = true;
			this.rdbtnCourseOfferAS.Location = new System.Drawing.Point(3, 10);
			this.rdbtnCourseOfferAS.Name = "rdbtnCourseOfferAS";
			this.rdbtnCourseOfferAS.Size = new System.Drawing.Size(14, 13);
			this.rdbtnCourseOfferAS.TabIndex = 5;
			this.rdbtnCourseOfferAS.TabStop = true;
			this.rdbtnCourseOfferAS.UseVisualStyleBackColor = true;
			// 
			// lblSubject
			// 
			this.lblSubject.AutoSize = true;
			this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSubject.Location = new System.Drawing.Point(17, 40);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(85, 20);
			this.lblSubject.TabIndex = 0;
			this.lblSubject.Text = "Subject(s):";
			// 
			// lstSubjectsAS
			// 
			this.lstSubjectsAS.FormattingEnabled = true;
			this.lstSubjectsAS.ItemHeight = 16;
			this.lstSubjectsAS.Location = new System.Drawing.Point(372, 22);
			this.lstSubjectsAS.Name = "lstSubjectsAS";
			this.lstSubjectsAS.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lstSubjectsAS.Size = new System.Drawing.Size(308, 52);
			this.lstSubjectsAS.TabIndex = 1;
			// 
			// lblCourseNo
			// 
			this.lblCourseNo.AutoSize = true;
			this.lblCourseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCourseNo.Location = new System.Drawing.Point(17, 90);
			this.lblCourseNo.Name = "lblCourseNo";
			this.lblCourseNo.Size = new System.Drawing.Size(124, 20);
			this.lblCourseNo.TabIndex = 0;
			this.lblCourseNo.Text = "Course Number:";
			// 
			// txtCourseNoAS
			// 
			this.txtCourseNoAS.Location = new System.Drawing.Point(558, 89);
			this.txtCourseNoAS.Name = "txtCourseNoAS";
			this.txtCourseNoAS.Size = new System.Drawing.Size(122, 23);
			this.txtCourseNoAS.TabIndex = 3;
			// 
			// txtCreditHoursAS
			// 
			this.txtCreditHoursAS.Location = new System.Drawing.Point(372, 206);
			this.txtCreditHoursAS.Name = "txtCreditHoursAS";
			this.txtCreditHoursAS.Size = new System.Drawing.Size(100, 23);
			this.txtCreditHoursAS.TabIndex = 3;
			// 
			// cboInstructorAS
			// 
			this.cboInstructorAS.FormattingEnabled = true;
			this.cboInstructorAS.Location = new System.Drawing.Point(372, 169);
			this.cboInstructorAS.Name = "cboInstructorAS";
			this.cboInstructorAS.Size = new System.Drawing.Size(308, 24);
			this.cboInstructorAS.TabIndex = 2;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rdbtnExcludeAS);
			this.panel1.Controls.Add(this.rdbtnIncludeAS);
			this.panel1.Location = new System.Drawing.Point(372, 241);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(233, 30);
			this.panel1.TabIndex = 6;
			// 
			// rdbtnExcludeAS
			// 
			this.rdbtnExcludeAS.AutoSize = true;
			this.rdbtnExcludeAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtnExcludeAS.Location = new System.Drawing.Point(99, 5);
			this.rdbtnExcludeAS.Name = "rdbtnExcludeAS";
			this.rdbtnExcludeAS.Size = new System.Drawing.Size(75, 21);
			this.rdbtnExcludeAS.TabIndex = 5;
			this.rdbtnExcludeAS.Text = "Exclude";
			this.rdbtnExcludeAS.UseVisualStyleBackColor = true;
			// 
			// rdbtnIncludeAS
			// 
			this.rdbtnIncludeAS.AutoSize = true;
			this.rdbtnIncludeAS.Checked = true;
			this.rdbtnIncludeAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rdbtnIncludeAS.Location = new System.Drawing.Point(3, 5);
			this.rdbtnIncludeAS.Name = "rdbtnIncludeAS";
			this.rdbtnIncludeAS.Size = new System.Drawing.Size(71, 21);
			this.rdbtnIncludeAS.TabIndex = 5;
			this.rdbtnIncludeAS.TabStop = true;
			this.rdbtnIncludeAS.Text = "Include";
			this.rdbtnIncludeAS.UseVisualStyleBackColor = true;
			// 
			// lblLocation
			// 
			this.lblLocation.AutoSize = true;
			this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLocation.Location = new System.Drawing.Point(17, 132);
			this.lblLocation.Name = "lblLocation";
			this.lblLocation.Size = new System.Drawing.Size(74, 20);
			this.lblLocation.TabIndex = 0;
			this.lblLocation.Text = "Location:";
			// 
			// cbxDistanceLearningAS
			// 
			this.cbxDistanceLearningAS.AutoSize = true;
			this.cbxDistanceLearningAS.Location = new System.Drawing.Point(372, 288);
			this.cbxDistanceLearningAS.Name = "cbxDistanceLearningAS";
			this.cbxDistanceLearningAS.Size = new System.Drawing.Size(15, 14);
			this.cbxDistanceLearningAS.TabIndex = 4;
			this.cbxDistanceLearningAS.UseVisualStyleBackColor = true;
			// 
			// lblPrimaryInstructor
			// 
			this.lblPrimaryInstructor.AutoSize = true;
			this.lblPrimaryInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPrimaryInstructor.Location = new System.Drawing.Point(17, 169);
			this.lblPrimaryInstructor.Name = "lblPrimaryInstructor";
			this.lblPrimaryInstructor.Size = new System.Drawing.Size(137, 20);
			this.lblPrimaryInstructor.TabIndex = 0;
			this.lblPrimaryInstructor.Text = "Primary Instructor:";
			// 
			// lblCreditHours
			// 
			this.lblCreditHours.AutoSize = true;
			this.lblCreditHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCreditHours.Location = new System.Drawing.Point(17, 206);
			this.lblCreditHours.Name = "lblCreditHours";
			this.lblCreditHours.Size = new System.Drawing.Size(243, 20);
			this.lblCreditHours.TabIndex = 0;
			this.lblCreditHours.Text = "Credit Hours (Leave blank for all):";
			// 
			// lblStatusOfCourse
			// 
			this.lblStatusOfCourse.AutoSize = true;
			this.lblStatusOfCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblStatusOfCourse.Location = new System.Drawing.Point(17, 243);
			this.lblStatusOfCourse.Name = "lblStatusOfCourse";
			this.lblStatusOfCourse.Size = new System.Drawing.Size(227, 20);
			this.lblStatusOfCourse.TabIndex = 0;
			this.lblStatusOfCourse.Text = "Canceled and Closed Courses:";
			// 
			// lblDistanceLearning
			// 
			this.lblDistanceLearning.AutoSize = true;
			this.lblDistanceLearning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDistanceLearning.Location = new System.Drawing.Point(17, 280);
			this.lblDistanceLearning.Name = "lblDistanceLearning";
			this.lblDistanceLearning.Size = new System.Drawing.Size(177, 20);
			this.lblDistanceLearning.TabIndex = 0;
			this.lblDistanceLearning.Text = "Distance Learning Only:";
			// 
			// lblCourseOffering
			// 
			this.lblCourseOffering.AutoSize = true;
			this.lblCourseOffering.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCourseOffering.Location = new System.Drawing.Point(17, 317);
			this.lblCourseOffering.Name = "lblCourseOffering";
			this.lblCourseOffering.Size = new System.Drawing.Size(203, 20);
			this.lblCourseOffering.TabIndex = 0;
			this.lblCourseOffering.Text = "EXL Course Offerings Only:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(17, 354);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(339, 20);
			this.label2.TabIndex = 0;
			this.label2.Text = "Transfer Indiana CTL and Dual Credit Courses:";
			// 
			// cboCourseAS
			// 
			this.cboCourseAS.FormattingEnabled = true;
			this.cboCourseAS.Items.AddRange(new object[] {
            "equals",
            "greater than or equal to",
            "less than or equal to"});
			this.cboCourseAS.Location = new System.Drawing.Point(372, 88);
			this.cboCourseAS.Name = "cboCourseAS";
			this.cboCourseAS.Size = new System.Drawing.Size(150, 24);
			this.cboCourseAS.TabIndex = 2;
			// 
			// cboLocationsAS
			// 
			this.cboLocationsAS.FormattingEnabled = true;
			this.cboLocationsAS.Location = new System.Drawing.Point(372, 130);
			this.cboLocationsAS.Name = "cboLocationsAS";
			this.cboLocationsAS.Size = new System.Drawing.Size(308, 24);
			this.cboLocationsAS.TabIndex = 2;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(452, 547);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 10;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnClearbtnAdhocSearch_Click);
			// 
			// btnAdhocSearch
			// 
			this.btnAdhocSearch.Location = new System.Drawing.Point(342, 547);
			this.btnAdhocSearch.Name = "btnAdhocSearch";
			this.btnAdhocSearch.Size = new System.Drawing.Size(75, 23);
			this.btnAdhocSearch.TabIndex = 11;
			this.btnAdhocSearch.Text = "Submit";
			this.btnAdhocSearch.UseVisualStyleBackColor = true;
			this.btnAdhocSearch.Click += new System.EventHandler(this.btnAdhocSearch_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.BasicSearch);
			this.tabControl1.Controls.Add(this.SearchInstructor);
			this.tabControl1.Controls.Add(this.KeywordSearch);
			this.tabControl1.Controls.Add(this.AdhocSearch);
			this.tabControl1.Controls.Add(this.SearchClasses);
			this.tabControl1.Location = new System.Drawing.Point(0, 3);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(830, 608);
			this.tabControl1.TabIndex = 0;
			// 
			// SearchInstructor
			// 
			this.SearchInstructor.BackColor = System.Drawing.Color.WhiteSmoke;
			this.SearchInstructor.Controls.Add(this.clearInstructorTab);
			this.SearchInstructor.Controls.Add(this.SearchByInstructor);
			this.SearchInstructor.Controls.Add(this.groupBox4);
			this.SearchInstructor.Location = new System.Drawing.Point(4, 22);
			this.SearchInstructor.Name = "SearchInstructor";
			this.SearchInstructor.Padding = new System.Windows.Forms.Padding(3);
			this.SearchInstructor.Size = new System.Drawing.Size(822, 582);
			this.SearchInstructor.TabIndex = 2;
			this.SearchInstructor.Text = "Search By Instructor";
			// 
			// clearInstructorTab
			// 
			this.clearInstructorTab.Location = new System.Drawing.Point(429, 417);
			this.clearInstructorTab.Name = "clearInstructorTab";
			this.clearInstructorTab.Size = new System.Drawing.Size(75, 23);
			this.clearInstructorTab.TabIndex = 18;
			this.clearInstructorTab.Text = "Reset";
			this.clearInstructorTab.UseVisualStyleBackColor = true;
			this.clearInstructorTab.Click += new System.EventHandler(this.btnClearInstructorSearch_Click);
			// 
			// SearchByInstructor
			// 
			this.SearchByInstructor.Location = new System.Drawing.Point(319, 417);
			this.SearchByInstructor.Name = "SearchByInstructor";
			this.SearchByInstructor.Size = new System.Drawing.Size(75, 23);
			this.SearchByInstructor.TabIndex = 19;
			this.SearchByInstructor.Text = "Submit";
			this.SearchByInstructor.UseVisualStyleBackColor = true;
			this.SearchByInstructor.Click += new System.EventHandler(this.SearchByInstructor_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox4.Controls.Add(this.label16);
			this.groupBox4.Controls.Add(this.pnlDays3);
			this.groupBox4.Controls.Add(this.label21);
			this.groupBox4.Controls.Add(this.label22);
			this.groupBox4.Controls.Add(this.label33);
			this.groupBox4.Controls.Add(this.cboInstructorsSI);
			this.groupBox4.Controls.Add(this.label29);
			this.groupBox4.Controls.Add(this.cboStartTimeSI);
			this.groupBox4.Controls.Add(this.cboEndTimeSI);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(55, 25);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(712, 356);
			this.groupBox4.TabIndex = 14;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Search Courses";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(452, 185);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(36, 20);
			this.label16.TabIndex = 15;
			this.label16.Text = "and";
			// 
			// pnlDays3
			// 
			this.pnlDays3.Controls.Add(this.cboUSI);
			this.pnlDays3.Controls.Add(this.cboSSI);
			this.pnlDays3.Controls.Add(this.cboFSI);
			this.pnlDays3.Controls.Add(this.cboRSI);
			this.pnlDays3.Controls.Add(this.cboWSI);
			this.pnlDays3.Controls.Add(this.cboTSI);
			this.pnlDays3.Controls.Add(this.cboMSI);
			this.pnlDays3.Location = new System.Drawing.Point(286, 118);
			this.pnlDays3.Name = "pnlDays3";
			this.pnlDays3.Size = new System.Drawing.Size(308, 29);
			this.pnlDays3.TabIndex = 14;
			// 
			// cboUSI
			// 
			this.cboUSI.AutoSize = true;
			this.cboUSI.Location = new System.Drawing.Point(261, 3);
			this.cboUSI.Name = "cboUSI";
			this.cboUSI.Size = new System.Drawing.Size(38, 21);
			this.cboUSI.TabIndex = 0;
			this.cboUSI.Text = "U";
			this.cboUSI.UseVisualStyleBackColor = true;
			// 
			// cboSSI
			// 
			this.cboSSI.AutoSize = true;
			this.cboSSI.Location = new System.Drawing.Point(218, 3);
			this.cboSSI.Name = "cboSSI";
			this.cboSSI.Size = new System.Drawing.Size(37, 21);
			this.cboSSI.TabIndex = 0;
			this.cboSSI.Text = "S";
			this.cboSSI.UseVisualStyleBackColor = true;
			// 
			// cboFSI
			// 
			this.cboFSI.AutoSize = true;
			this.cboFSI.Location = new System.Drawing.Point(180, 3);
			this.cboFSI.Name = "cboFSI";
			this.cboFSI.Size = new System.Drawing.Size(36, 21);
			this.cboFSI.TabIndex = 0;
			this.cboFSI.Text = "F";
			this.cboFSI.UseVisualStyleBackColor = true;
			// 
			// cboRSI
			// 
			this.cboRSI.AutoSize = true;
			this.cboRSI.Location = new System.Drawing.Point(134, 3);
			this.cboRSI.Name = "cboRSI";
			this.cboRSI.Size = new System.Drawing.Size(38, 21);
			this.cboRSI.TabIndex = 0;
			this.cboRSI.Text = "R";
			this.cboRSI.UseVisualStyleBackColor = true;
			// 
			// cboWSI
			// 
			this.cboWSI.AutoSize = true;
			this.cboWSI.Location = new System.Drawing.Point(91, 3);
			this.cboWSI.Name = "cboWSI";
			this.cboWSI.Size = new System.Drawing.Size(41, 21);
			this.cboWSI.TabIndex = 0;
			this.cboWSI.Text = "W";
			this.cboWSI.UseVisualStyleBackColor = true;
			// 
			// cboTSI
			// 
			this.cboTSI.AutoSize = true;
			this.cboTSI.Location = new System.Drawing.Point(48, 4);
			this.cboTSI.Name = "cboTSI";
			this.cboTSI.Size = new System.Drawing.Size(37, 21);
			this.cboTSI.TabIndex = 0;
			this.cboTSI.Text = "T";
			this.cboTSI.UseVisualStyleBackColor = true;
			// 
			// cboMSI
			// 
			this.cboMSI.AutoSize = true;
			this.cboMSI.Location = new System.Drawing.Point(4, 3);
			this.cboMSI.Name = "cboMSI";
			this.cboMSI.Size = new System.Drawing.Size(39, 21);
			this.cboMSI.TabIndex = 0;
			this.cboMSI.Text = "M";
			this.cboMSI.UseVisualStyleBackColor = true;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label21.Location = new System.Drawing.Point(73, 185);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(153, 20);
			this.label21.TabIndex = 12;
			this.label21.Text = "Start Time Between:";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label22.Location = new System.Drawing.Point(73, 122);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(41, 20);
			this.label22.TabIndex = 12;
			this.label22.Text = "Day:";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label33.Location = new System.Drawing.Point(599, 52);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(71, 15);
			this.label33.TabIndex = 12;
			this.label33.Text = "*(Required)";
			// 
			// cboInstructorsSI
			// 
			this.cboInstructorsSI.FormattingEnabled = true;
			this.cboInstructorsSI.Location = new System.Drawing.Point(285, 49);
			this.cboInstructorsSI.Name = "cboInstructorsSI";
			this.cboInstructorsSI.Size = new System.Drawing.Size(308, 24);
			this.cboInstructorsSI.TabIndex = 9;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label29.Location = new System.Drawing.Point(73, 51);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(145, 20);
			this.label29.TabIndex = 7;
			this.label29.Text = "Name of Instructor:";
			// 
			// cboStartTimeSI
			// 
			this.cboStartTimeSI.FormattingEnabled = true;
			this.cboStartTimeSI.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboStartTimeSI.Location = new System.Drawing.Point(286, 183);
			this.cboStartTimeSI.Name = "cboStartTimeSI";
			this.cboStartTimeSI.Size = new System.Drawing.Size(143, 24);
			this.cboStartTimeSI.TabIndex = 2;
			// 
			// cboEndTimeSI
			// 
			this.cboEndTimeSI.FormattingEnabled = true;
			this.cboEndTimeSI.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboEndTimeSI.Location = new System.Drawing.Point(515, 183);
			this.cboEndTimeSI.Name = "cboEndTimeSI";
			this.cboEndTimeSI.Size = new System.Drawing.Size(143, 24);
			this.cboEndTimeSI.TabIndex = 2;
			// 
			// KeywordSearch
			// 
			this.KeywordSearch.BackColor = System.Drawing.Color.WhiteSmoke;
			this.KeywordSearch.Controls.Add(this.groupBox5);
			this.KeywordSearch.Controls.Add(this.btnKeywordSearch);
			this.KeywordSearch.Controls.Add(this.btnResetKS);
			this.KeywordSearch.Location = new System.Drawing.Point(4, 22);
			this.KeywordSearch.Name = "KeywordSearch";
			this.KeywordSearch.Size = new System.Drawing.Size(822, 582);
			this.KeywordSearch.TabIndex = 3;
			this.KeywordSearch.Text = "Keyword Search";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox5.Controls.Add(this.label32);
			this.groupBox5.Controls.Add(this.txtKeywordKS);
			this.groupBox5.Controls.Add(this.label18);
			this.groupBox5.Controls.Add(this.pnlDaysKS);
			this.groupBox5.Controls.Add(this.label25);
			this.groupBox5.Controls.Add(this.label26);
			this.groupBox5.Controls.Add(this.label27);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.cboStartTimeKS);
			this.groupBox5.Controls.Add(this.cboEndTimeKS);
			this.groupBox5.Controls.Add(this.cboTermsKS);
			this.groupBox5.Controls.Add(this.label31);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(55, 25);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(712, 353);
			this.groupBox5.TabIndex = 15;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Search Courses";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label32.Location = new System.Drawing.Point(608, 135);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(71, 15);
			this.label32.TabIndex = 19;
			this.label32.Text = "*(Required)";
			// 
			// txtKeywordKS
			// 
			this.txtKeywordKS.Location = new System.Drawing.Point(286, 129);
			this.txtKeywordKS.Name = "txtKeywordKS";
			this.txtKeywordKS.Size = new System.Drawing.Size(307, 23);
			this.txtKeywordKS.TabIndex = 18;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(452, 266);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(36, 20);
			this.label18.TabIndex = 15;
			this.label18.Text = "and";
			// 
			// pnlDaysKS
			// 
			this.pnlDaysKS.Controls.Add(this.cbxUKS);
			this.pnlDaysKS.Controls.Add(this.cbxSKS);
			this.pnlDaysKS.Controls.Add(this.cbxFKS);
			this.pnlDaysKS.Controls.Add(this.cbxRKS);
			this.pnlDaysKS.Controls.Add(this.cbxWKS);
			this.pnlDaysKS.Controls.Add(this.cbxTKS);
			this.pnlDaysKS.Controls.Add(this.cbxMKS);
			this.pnlDaysKS.Location = new System.Drawing.Point(286, 199);
			this.pnlDaysKS.Name = "pnlDaysKS";
			this.pnlDaysKS.Size = new System.Drawing.Size(308, 29);
			this.pnlDaysKS.TabIndex = 14;
			// 
			// cbxUKS
			// 
			this.cbxUKS.AutoSize = true;
			this.cbxUKS.Location = new System.Drawing.Point(261, 3);
			this.cbxUKS.Name = "cbxUKS";
			this.cbxUKS.Size = new System.Drawing.Size(38, 21);
			this.cbxUKS.TabIndex = 0;
			this.cbxUKS.Text = "U";
			this.cbxUKS.UseVisualStyleBackColor = true;
			// 
			// cbxSKS
			// 
			this.cbxSKS.AutoSize = true;
			this.cbxSKS.Location = new System.Drawing.Point(218, 3);
			this.cbxSKS.Name = "cbxSKS";
			this.cbxSKS.Size = new System.Drawing.Size(37, 21);
			this.cbxSKS.TabIndex = 0;
			this.cbxSKS.Text = "S";
			this.cbxSKS.UseVisualStyleBackColor = true;
			// 
			// cbxFKS
			// 
			this.cbxFKS.AutoSize = true;
			this.cbxFKS.Location = new System.Drawing.Point(180, 3);
			this.cbxFKS.Name = "cbxFKS";
			this.cbxFKS.Size = new System.Drawing.Size(36, 21);
			this.cbxFKS.TabIndex = 0;
			this.cbxFKS.Text = "F";
			this.cbxFKS.UseVisualStyleBackColor = true;
			// 
			// cbxRKS
			// 
			this.cbxRKS.AutoSize = true;
			this.cbxRKS.Location = new System.Drawing.Point(134, 3);
			this.cbxRKS.Name = "cbxRKS";
			this.cbxRKS.Size = new System.Drawing.Size(38, 21);
			this.cbxRKS.TabIndex = 0;
			this.cbxRKS.Text = "R";
			this.cbxRKS.UseVisualStyleBackColor = true;
			// 
			// cbxWKS
			// 
			this.cbxWKS.AutoSize = true;
			this.cbxWKS.Location = new System.Drawing.Point(91, 3);
			this.cbxWKS.Name = "cbxWKS";
			this.cbxWKS.Size = new System.Drawing.Size(41, 21);
			this.cbxWKS.TabIndex = 0;
			this.cbxWKS.Text = "W";
			this.cbxWKS.UseVisualStyleBackColor = true;
			// 
			// cbxTKS
			// 
			this.cbxTKS.AutoSize = true;
			this.cbxTKS.Location = new System.Drawing.Point(48, 4);
			this.cbxTKS.Name = "cbxTKS";
			this.cbxTKS.Size = new System.Drawing.Size(37, 21);
			this.cbxTKS.TabIndex = 0;
			this.cbxTKS.Text = "T";
			this.cbxTKS.UseVisualStyleBackColor = true;
			// 
			// cbxMKS
			// 
			this.cbxMKS.AutoSize = true;
			this.cbxMKS.Location = new System.Drawing.Point(4, 3);
			this.cbxMKS.Name = "cbxMKS";
			this.cbxMKS.Size = new System.Drawing.Size(39, 21);
			this.cbxMKS.TabIndex = 0;
			this.cbxMKS.Text = "M";
			this.cbxMKS.UseVisualStyleBackColor = true;
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label25.Location = new System.Drawing.Point(73, 266);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(153, 20);
			this.label25.TabIndex = 12;
			this.label25.Text = "Start Time Between:";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label26.Location = new System.Drawing.Point(73, 203);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(41, 20);
			this.label26.TabIndex = 12;
			this.label26.Text = "Day:";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label27.Location = new System.Drawing.Point(475, 68);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(71, 15);
			this.label27.TabIndex = 12;
			this.label27.Text = "*(Required)";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label28.Location = new System.Drawing.Point(73, 132);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(91, 20);
			this.label28.TabIndex = 7;
			this.label28.Text = "Keyword(s):";
			// 
			// cboStartTimeKS
			// 
			this.cboStartTimeKS.FormattingEnabled = true;
			this.cboStartTimeKS.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboStartTimeKS.Location = new System.Drawing.Point(286, 264);
			this.cboStartTimeKS.Name = "cboStartTimeKS";
			this.cboStartTimeKS.Size = new System.Drawing.Size(143, 24);
			this.cboStartTimeKS.TabIndex = 2;
			// 
			// cboEndTimeKS
			// 
			this.cboEndTimeKS.FormattingEnabled = true;
			this.cboEndTimeKS.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboEndTimeKS.Location = new System.Drawing.Point(515, 264);
			this.cboEndTimeKS.Name = "cboEndTimeKS";
			this.cboEndTimeKS.Size = new System.Drawing.Size(143, 24);
			this.cboEndTimeKS.TabIndex = 2;
			// 
			// cboTermsKS
			// 
			this.cboTermsKS.FormattingEnabled = true;
			this.cboTermsKS.Location = new System.Drawing.Point(286, 63);
			this.cboTermsKS.Name = "cboTermsKS";
			this.cboTermsKS.Size = new System.Drawing.Size(172, 24);
			this.cboTermsKS.TabIndex = 2;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label31.Location = new System.Drawing.Point(73, 65);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(49, 20);
			this.label31.TabIndex = 0;
			this.label31.Text = "Term:";
			// 
			// btnKeywordSearch
			// 
			this.btnKeywordSearch.Location = new System.Drawing.Point(319, 417);
			this.btnKeywordSearch.Name = "btnKeywordSearch";
			this.btnKeywordSearch.Size = new System.Drawing.Size(75, 23);
			this.btnKeywordSearch.TabIndex = 17;
			this.btnKeywordSearch.Text = "Submit";
			this.btnKeywordSearch.UseVisualStyleBackColor = true;
			this.btnKeywordSearch.Click += new System.EventHandler(this.btnKeywordSearch_Click);
			// 
			// btnResetKS
			// 
			this.btnResetKS.Location = new System.Drawing.Point(439, 417);
			this.btnResetKS.Name = "btnResetKS";
			this.btnResetKS.Size = new System.Drawing.Size(75, 23);
			this.btnResetKS.TabIndex = 16;
			this.btnResetKS.Text = "Reset";
			this.btnResetKS.UseVisualStyleBackColor = true;
			this.btnResetKS.Click += new System.EventHandler(this.btnClearKeywordSearch_Click);
			// 
			// SearchClasses
			// 
			this.SearchClasses.BackColor = System.Drawing.Color.WhiteSmoke;
			this.SearchClasses.Controls.Add(this.btnReset5);
			this.SearchClasses.Controls.Add(this.btnSearchClasses);
			this.SearchClasses.Controls.Add(this.groupBox6);
			this.SearchClasses.Location = new System.Drawing.Point(4, 22);
			this.SearchClasses.Name = "SearchClasses";
			this.SearchClasses.Padding = new System.Windows.Forms.Padding(3);
			this.SearchClasses.Size = new System.Drawing.Size(822, 582);
			this.SearchClasses.TabIndex = 4;
			this.SearchClasses.Text = "Search Classes";
			// 
			// btnReset5
			// 
			this.btnReset5.Location = new System.Drawing.Point(429, 417);
			this.btnReset5.Name = "btnReset5";
			this.btnReset5.Size = new System.Drawing.Size(75, 23);
			this.btnReset5.TabIndex = 21;
			this.btnReset5.Text = "Reset";
			this.btnReset5.UseVisualStyleBackColor = true;
			this.btnReset5.Click += new System.EventHandler(this.btnClearClassesSearch_Click);
			// 
			// btnSearchClasses
			// 
			this.btnSearchClasses.Location = new System.Drawing.Point(319, 417);
			this.btnSearchClasses.Name = "btnSearchClasses";
			this.btnSearchClasses.Size = new System.Drawing.Size(75, 23);
			this.btnSearchClasses.TabIndex = 22;
			this.btnSearchClasses.Text = "Submit";
			this.btnSearchClasses.UseVisualStyleBackColor = true;
			this.btnSearchClasses.Click += new System.EventHandler(this.btnSearchClasses_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.groupBox6.Controls.Add(this.label20);
			this.groupBox6.Controls.Add(this.label17);
			this.groupBox6.Controls.Add(this.cboRoomSC);
			this.groupBox6.Controls.Add(this.cboTermsSC);
			this.groupBox6.Controls.Add(this.label19);
			this.groupBox6.Controls.Add(this.label34);
			this.groupBox6.Controls.Add(this.pnlDaysSC);
			this.groupBox6.Controls.Add(this.label37);
			this.groupBox6.Controls.Add(this.label38);
			this.groupBox6.Controls.Add(this.label39);
			this.groupBox6.Controls.Add(this.cboLocationsSC);
			this.groupBox6.Controls.Add(this.label40);
			this.groupBox6.Controls.Add(this.label41);
			this.groupBox6.Controls.Add(this.cboStartTimeSC);
			this.groupBox6.Controls.Add(this.cboEndTimeSC);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(55, 25);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(712, 353);
			this.groupBox6.TabIndex = 20;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Search Classes";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(476, 166);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(71, 15);
			this.label20.TabIndex = 22;
			this.label20.Text = "*(Required)";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(476, 55);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(71, 15);
			this.label17.TabIndex = 22;
			this.label17.Text = "*(Required)";
			// 
			// cboRoomSC
			// 
			this.cboRoomSC.FormattingEnabled = true;
			this.cboRoomSC.Location = new System.Drawing.Point(287, 163);
			this.cboRoomSC.Name = "cboRoomSC";
			this.cboRoomSC.Size = new System.Drawing.Size(172, 24);
			this.cboRoomSC.TabIndex = 21;
			// 
			// cboTermsSC
			// 
			this.cboTermsSC.FormattingEnabled = true;
			this.cboTermsSC.Location = new System.Drawing.Point(287, 50);
			this.cboTermsSC.Name = "cboTermsSC";
			this.cboTermsSC.Size = new System.Drawing.Size(172, 24);
			this.cboTermsSC.TabIndex = 21;
			this.cboTermsSC.SelectedIndexChanged += new System.EventHandler(this.cboTermsSC_SelectedIndexChanged);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(74, 52);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(49, 20);
			this.label19.TabIndex = 20;
			this.label19.Text = "Term:";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label34.Location = new System.Drawing.Point(452, 309);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(36, 20);
			this.label34.TabIndex = 15;
			this.label34.Text = "and";
			// 
			// pnlDaysSC
			// 
			this.pnlDaysSC.Controls.Add(this.cbxUSC);
			this.pnlDaysSC.Controls.Add(this.cbxSSC);
			this.pnlDaysSC.Controls.Add(this.cbxFSC);
			this.pnlDaysSC.Controls.Add(this.cbxRSC);
			this.pnlDaysSC.Controls.Add(this.cbxWSC);
			this.pnlDaysSC.Controls.Add(this.cbxMSC);
			this.pnlDaysSC.Controls.Add(this.cbxTSC);
			this.pnlDaysSC.Location = new System.Drawing.Point(286, 230);
			this.pnlDaysSC.Name = "pnlDaysSC";
			this.pnlDaysSC.Size = new System.Drawing.Size(308, 29);
			this.pnlDaysSC.TabIndex = 14;
			// 
			// cbxUSC
			// 
			this.cbxUSC.AutoSize = true;
			this.cbxUSC.Location = new System.Drawing.Point(261, 3);
			this.cbxUSC.Name = "cbxUSC";
			this.cbxUSC.Size = new System.Drawing.Size(38, 21);
			this.cbxUSC.TabIndex = 0;
			this.cbxUSC.Text = "U";
			this.cbxUSC.UseVisualStyleBackColor = true;
			// 
			// cbxSSC
			// 
			this.cbxSSC.AutoSize = true;
			this.cbxSSC.Location = new System.Drawing.Point(218, 3);
			this.cbxSSC.Name = "cbxSSC";
			this.cbxSSC.Size = new System.Drawing.Size(37, 21);
			this.cbxSSC.TabIndex = 0;
			this.cbxSSC.Text = "S";
			this.cbxSSC.UseVisualStyleBackColor = true;
			// 
			// cbxFSC
			// 
			this.cbxFSC.AutoSize = true;
			this.cbxFSC.Location = new System.Drawing.Point(180, 3);
			this.cbxFSC.Name = "cbxFSC";
			this.cbxFSC.Size = new System.Drawing.Size(36, 21);
			this.cbxFSC.TabIndex = 0;
			this.cbxFSC.Text = "F";
			this.cbxFSC.UseVisualStyleBackColor = true;
			// 
			// cbxRSC
			// 
			this.cbxRSC.AutoSize = true;
			this.cbxRSC.Location = new System.Drawing.Point(134, 3);
			this.cbxRSC.Name = "cbxRSC";
			this.cbxRSC.Size = new System.Drawing.Size(38, 21);
			this.cbxRSC.TabIndex = 0;
			this.cbxRSC.Text = "R";
			this.cbxRSC.UseVisualStyleBackColor = true;
			// 
			// cbxWSC
			// 
			this.cbxWSC.AutoSize = true;
			this.cbxWSC.Location = new System.Drawing.Point(91, 3);
			this.cbxWSC.Name = "cbxWSC";
			this.cbxWSC.Size = new System.Drawing.Size(41, 21);
			this.cbxWSC.TabIndex = 0;
			this.cbxWSC.Text = "W";
			this.cbxWSC.UseVisualStyleBackColor = true;
			// 
			// cbxMSC
			// 
			this.cbxMSC.AutoSize = true;
			this.cbxMSC.Location = new System.Drawing.Point(5, 4);
			this.cbxMSC.Name = "cbxMSC";
			this.cbxMSC.Size = new System.Drawing.Size(39, 21);
			this.cbxMSC.TabIndex = 0;
			this.cbxMSC.Text = "M";
			this.cbxMSC.UseVisualStyleBackColor = true;
			// 
			// cbxTSC
			// 
			this.cbxTSC.AutoSize = true;
			this.cbxTSC.Location = new System.Drawing.Point(48, 4);
			this.cbxTSC.Name = "cbxTSC";
			this.cbxTSC.Size = new System.Drawing.Size(37, 21);
			this.cbxTSC.TabIndex = 0;
			this.cbxTSC.Text = "T";
			this.cbxTSC.UseVisualStyleBackColor = true;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label37.Location = new System.Drawing.Point(73, 309);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(153, 20);
			this.label37.TabIndex = 12;
			this.label37.Text = "Start Time Between:";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label38.Location = new System.Drawing.Point(73, 238);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(41, 20);
			this.label38.TabIndex = 12;
			this.label38.Text = "Day:";
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label39.Location = new System.Drawing.Point(599, 99);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(71, 15);
			this.label39.TabIndex = 12;
			this.label39.Text = "*(Required)";
			// 
			// cboLocationsSC
			// 
			this.cboLocationsSC.FormattingEnabled = true;
			this.cboLocationsSC.Location = new System.Drawing.Point(285, 94);
			this.cboLocationsSC.Name = "cboLocationsSC";
			this.cboLocationsSC.Size = new System.Drawing.Size(308, 24);
			this.cboLocationsSC.TabIndex = 9;
			this.cboLocationsSC.SelectedIndexChanged += new System.EventHandler(this.cboLocationsSC_SelectedIndexChanged);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label40.Location = new System.Drawing.Point(73, 167);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(80, 20);
			this.label40.TabIndex = 7;
			this.label40.Text = "Room No:";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label41.Location = new System.Drawing.Point(73, 96);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(74, 20);
			this.label41.TabIndex = 7;
			this.label41.Text = "Location:";
			// 
			// cboStartTimeSC
			// 
			this.cboStartTimeSC.FormattingEnabled = true;
			this.cboStartTimeSC.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboStartTimeSC.Location = new System.Drawing.Point(286, 307);
			this.cboStartTimeSC.Name = "cboStartTimeSC";
			this.cboStartTimeSC.Size = new System.Drawing.Size(143, 24);
			this.cboStartTimeSC.TabIndex = 2;
			// 
			// cboEndTimeSC
			// 
			this.cboEndTimeSC.FormattingEnabled = true;
			this.cboEndTimeSC.Items.AddRange(new object[] {
            "06:00 AM",
            "08:00 AM",
            "09:00 AM",
            "10:00 AM",
            "11:00 AM",
            "12:00 PM",
            "01:00 PM",
            "02:00 PM",
            "03:00 PM",
            "04:00 PM",
            "05:00 PM",
            "06:00 PM",
            "07:00 PM",
            "08:00 PM",
            "09:00 PM",
            "10:00 PM",
            "11:00 PM"});
			this.cboEndTimeSC.Location = new System.Drawing.Point(515, 307);
			this.cboEndTimeSC.Name = "cboEndTimeSC";
			this.cboEndTimeSC.Size = new System.Drawing.Size(143, 24);
			this.cboEndTimeSC.TabIndex = 2;
			// 
			// frmOnlineScheduler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(829, 607);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmOnlineScheduler";
			this.Text = "Purdue University Calumet On-Line Class Schedule";
			this.Load += new System.EventHandler(this.frmOnlineScheduler_Load);
			this.BasicSearch.ResumeLayout(false);
			this.gbxDAY.ResumeLayout(false);
			this.gbxDAY.PerformLayout();
			this.pnlDaysBS.ResumeLayout(false);
			this.pnlDaysBS.PerformLayout();
			this.AdhocSearch.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.SearchInstructor.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.pnlDays3.ResumeLayout(false);
			this.pnlDays3.PerformLayout();
			this.KeywordSearch.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.pnlDaysKS.ResumeLayout(false);
			this.pnlDaysKS.PerformLayout();
			this.SearchClasses.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.pnlDaysSC.ResumeLayout(false);
			this.pnlDaysSC.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage BasicSearch;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbxDAY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlDaysBS;
        private System.Windows.Forms.CheckBox cbxUBS;
        private System.Windows.Forms.CheckBox cbxSBS;
        private System.Windows.Forms.CheckBox cbxFBS;
        private System.Windows.Forms.CheckBox cbxRBS;
        private System.Windows.Forms.CheckBox cbxWBS;
        private System.Windows.Forms.CheckBox cbxTBS;
        private System.Windows.Forms.CheckBox cbxMBS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrsNoBS;
        private System.Windows.Forms.TextBox txtTitleBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboInstructorsBS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLocationsBS;
        private System.Windows.Forms.ComboBox cboCreditHrs2BS;
        private System.Windows.Forms.ComboBox cboCreditHrs1BS;
        private System.Windows.Forms.ComboBox cboStartTimeBS;
        private System.Windows.Forms.ComboBox cboEndTimeBS;
        private System.Windows.Forms.ComboBox cboSubjectsBS;
        private System.Windows.Forms.ComboBox cboCrsTypesBS;
        private System.Windows.Forms.ComboBox cboStatusBS;
        private System.Windows.Forms.ComboBox cboTermsBS;
        private System.Windows.Forms.Label lblTerm2;
        private System.Windows.Forms.TabPage AdhocSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTermsAS;
        private System.Windows.Forms.Label lblTerm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ListBox lstSubjectsAS;
        private System.Windows.Forms.Label lblCourseNo;
        private System.Windows.Forms.TextBox txtCourseNoAS;
        private System.Windows.Forms.TextBox txtCreditHoursAS;
        private System.Windows.Forms.ComboBox cboInstructorAS;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbtnExcludeAS;
        private System.Windows.Forms.RadioButton rdbtnIncludeAS;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.CheckBox cbxDistanceLearningAS;
        private System.Windows.Forms.RadioButton rdbtnCourseOfferAS;
        private System.Windows.Forms.Label lblPrimaryInstructor;
        private System.Windows.Forms.RadioButton rdbtnCreditCoursesAS;
        private System.Windows.Forms.Label lblCreditHours;
        private System.Windows.Forms.Label lblStatusOfCourse;
        private System.Windows.Forms.Label lblDistanceLearning;
        private System.Windows.Forms.Label lblCourseOffering;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCourseAS;
        private System.Windows.Forms.ComboBox cboLocationsAS;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdhocSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage SearchInstructor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel pnlDays3;
        private System.Windows.Forms.CheckBox cboUSI;
        private System.Windows.Forms.CheckBox cboSSI;
        private System.Windows.Forms.CheckBox cboFSI;
        private System.Windows.Forms.CheckBox cboRSI;
        private System.Windows.Forms.CheckBox cboWSI;
        private System.Windows.Forms.CheckBox cboTSI;
        private System.Windows.Forms.CheckBox cboMSI;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cboInstructorsSI;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox cboStartTimeSI;
        private System.Windows.Forms.ComboBox cboEndTimeSI;
        private System.Windows.Forms.TabPage KeywordSearch;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnResetKS;
        private System.Windows.Forms.Button btnKeywordSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel pnlDaysKS;
        private System.Windows.Forms.CheckBox cbxUKS;
        private System.Windows.Forms.CheckBox cbxSKS;
        private System.Windows.Forms.CheckBox cbxFKS;
        private System.Windows.Forms.CheckBox cbxRKS;
        private System.Windows.Forms.CheckBox cbxWKS;
        private System.Windows.Forms.CheckBox cbxTKS;
        private System.Windows.Forms.CheckBox cbxMKS;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cboStartTimeKS;
        private System.Windows.Forms.ComboBox cboEndTimeKS;
        private System.Windows.Forms.ComboBox cboTermsKS;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtKeywordKS;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button clearInstructorTab;
        private System.Windows.Forms.Button SearchByInstructor;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage SearchClasses;
        private System.Windows.Forms.Button btnReset5;
        private System.Windows.Forms.Button btnSearchClasses;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Panel pnlDaysSC;
        private System.Windows.Forms.CheckBox cbxUSC;
        private System.Windows.Forms.CheckBox cbxSSC;
        private System.Windows.Forms.CheckBox cbxFSC;
        private System.Windows.Forms.CheckBox cbxRSC;
        private System.Windows.Forms.CheckBox cbxWSC;
        private System.Windows.Forms.CheckBox cbxTSC;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cboLocationsSC;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cboStartTimeSC;
        private System.Windows.Forms.ComboBox cboEndTimeSC;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cboTermsSC;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox cbxMSC;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox cboRoomSC;



    }
}