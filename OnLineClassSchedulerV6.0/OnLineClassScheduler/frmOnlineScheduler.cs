using Purdue.OnlineClassScheduler.BAL.BusinessEntities;
using Purdue.OnlineClassScheduler.BAL.BusinessRepositery;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnLineClassScheduler
{
    public partial class frmOnlineScheduler : Form
    {
        public static int tabindex;
        bool termSelected, subjectSelected, courseNoProvided, locationSelected, creditcoursesprovided, courseTypeSelected, InstructorSelected, creditHrsProvided;
        bool distanceLearning, courseOfferings, ctl, exclude, courseStatusSelected, daySelected, timingProvided, creditHoursProvided;
        public frmOnlineScheduler()
        {
            InitializeComponent();
            tabControl1.SelectedIndex = tabindex;
        }
        public Repository repository;

        DataSet ds;
        Term term;
        Subject subject;
        Building building;
        Instructor instructor;
        List<Subject> subjects;

        private void frmOnlineScheduler_Load(object sender, EventArgs e)
        {
            repository = new Repository();
            tabControl1.SelectedIndex = tabindex;
            loadTerms();
            loadSubjects();
            loadLocations();
            loadInstructors();
            loadSchedules();
            setDefaultsInAdhocSearchTab();
        }

        #region loading the controls

        private void loadTerms()
        {
			clearItems(cboTermsAS);
			clearItems(cboTermsBS);
			clearItems(cboTermsKS);
			clearItems(cboTermsSC);

            foreach (Term term in repository.getTerms())
            {
                cboTermsAS.Items.Add(term.Quarter + " " + term.Year);
                cboTermsBS.Items.Add(term.Quarter + " " + term.Year);
                cboTermsKS.Items.Add(term.Quarter + " " + term.Year);
                cboTermsSC.Items.Add(term.Quarter + " " + term.Year);
            }
        }

        private void loadSubjects()
        {
			lstSubjectsAS.Items.Clear();
            foreach (Subject subject in repository.getSubjects())
            {
                lstSubjectsAS.Items.Add(subject.SubjectName);
            }
        }

        private void loadLocations()
        {
			clearItems(cboLocationsAS);
			clearItems(cboLocationsSC);

            foreach (Building location in repository.getLocations())
            {
                cboLocationsAS.Items.Add(location.BuildingName);
                cboLocationsSC.Items.Add(location.BuildingName);
            }
        }

        private void loadInstructors()
        {
			clearItems(cboInstructorAS);
			clearItems(cboInstructorsSI);

            foreach (Instructor instructor in repository.getInstructors())
            {
                cboInstructorAS.Items.Add(instructor.FirstName + " " + instructor.LastName);
                cboInstructorsSI.Items.Add(instructor.FirstName + " " + instructor.LastName);
            }
        }

        private void loadSchedules()
        {
			clearItems(cboCrsTypesBS);

            foreach (Schedule schedule in repository.getSchedule())
            {
                cboCrsTypesBS.Items.Add(schedule.ScheduleType);
            }
        }


		private void clearItems(ComboBox cbo)
		{
			cbo.Items.Clear();
            cbo.ResetText();
		}

        #endregion

        #region setting defaults for Adhoc Search Tab

        private void setDefaultsInAdhocSearchTab()
        {
            cboTermsAS.SelectedIndex = 0;
            cboCourseAS.SelectedIndex = 0;
            lstSubjectsAS.SelectedIndex =-1;
            txtCourseNoAS.Text = "ALL";
            cboLocationsAS.Items.Add("ALL");
            cboLocationsAS.SelectedItem = "ALL";
            cboInstructorAS.Items.Add("ALL");
            cboInstructorAS.SelectedItem = "ALL";
            rdbtnIncludeAS.Checked = true;
        }

        #endregion

        #region loading the comboboxes based on selections

        private void cboTermsBS_SelectedIndexChanged(object sender, EventArgs e)
        {
			clearItems(cboSubjectsBS);
            clearItems(cboLocationsBS);
            clearItems(cboInstructorsBS);

            if (cboTermsBS.SelectedIndex >= 0)
            {
                string[] terms = cboTermsBS.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
                foreach (Subject subject in repository.getSubjects(term))
                {
                    cboSubjectsBS.Items.Add(subject.SubjectName);
                }
            }
        }

        private void cboSubjectsBS_SelectedIndexChanged(object sender, EventArgs e)
        {
			clearItems(cboLocationsBS);
            clearItems(cboInstructorsBS);
            if (cboSubjectsBS.SelectedIndex >= 0)
            {
                subject = new Subject(cboSubjectsBS.SelectedItem.ToString());
                foreach (Building location in repository.getLocations(term, subject))
                {
                    cboLocationsBS.Items.Add(location.BuildingName);
                }
            }
        }

        private void cboLocationBS_SelectedIndexChanged(object sender, EventArgs e)
        {
			clearItems(cboInstructorsBS);

            if (cboLocationsBS.SelectedIndex >= 0)
            {
                building = new Building(cboLocationsBS.SelectedItem.ToString());
                foreach (Instructor instructor in repository.getInstructor(term, subject, building))
                {
                    cboInstructorsBS.Items.Add(instructor.FirstName + " " + instructor.LastName);
                }
            }
        }

        private void cboLocationsSC_SelectedIndexChanged(object sender, EventArgs e)
        {
			clearItems(cboRoomSC);

			if (cboLocationsSC.SelectedIndex >= 0)
            {
                foreach (string roomno in repository.getRooms(term, cboLocationsSC.SelectedItem.ToString()))
                {
                    cboRoomSC.Items.Add(roomno);
                }
            }
        }

        private void cboTermsSC_SelectedIndexChanged(object sender, EventArgs e)
        {
			clearItems(cboLocationsSC);

            if (cboTermsSC.SelectedIndex >= 0)
            {
                string[] terms = cboTermsSC.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
                foreach (Building location in repository.getLocations(term, null))
                {
                    cboLocationsSC.Items.Add(location.BuildingName);
                }
            }

        }

        #endregion

        #region Handling Reset Buttons with respect to each tab

        private void btnClearbtnAdhocSearch_Click(object sender, EventArgs e)
        {
            setDefaultsInAdhocSearchTab();
        }

        private void btnClearBasicSearch_Click(object sender, EventArgs e)
        {
            cboTermsBS.SelectedIndex = -1;
            cboTermsBS.ResetText();
            cboSubjectsBS.SelectedIndex = -1;
            cboSubjectsBS.ResetText();
            cboLocationsBS.SelectedIndex = -1;
            cboLocationsBS.ResetText();
            cboInstructorsBS.SelectedIndex = -1;
            cboInstructorsBS.ResetText();
            cboCrsTypesBS.SelectedIndex = -1;
            cboCrsTypesBS.ResetText();
            cboStartTimeBS.SelectedIndex = -1;
            cboStartTimeBS.ResetText();
            cboEndTimeBS.SelectedIndex = -1;
            cboEndTimeBS.ResetText();
            cboCreditHrs1BS.SelectedIndex = -1;
            cboCreditHrs1BS.ResetText();
            cboCreditHrs2BS.SelectedIndex = -1;
            cboCreditHrs2BS.ResetText();
            txtCourseNoAS.Text = "";
            cboStatusBS.SelectedIndex = -1;
            cboStatusBS.ResetText();
            txtTitleBS.Text = "";
            resetCheckBoxes(pnlDaysBS);
        }

        private void btnClearInstructorSearch_Click(object sender, EventArgs e)
        {
           
            cboInstructorsSI.SelectedIndex = -1;
            cboInstructorsSI.ResetText();
            cboStartTimeSI.SelectedIndex = -1;
           cboStartTimeSI.ResetText();
            cboEndTimeSI.SelectedIndex = -1;
            cboEndTimeSI.ResetText();
            resetCheckBoxes(pnlDays3);
        }

        private void btnClearKeywordSearch_Click(object sender, EventArgs e)
        {
            cboTermsKS.SelectedIndex = -1;
            cboTermsKS.ResetText();
            cboStartTimeKS.SelectedIndex = -1;
            cboStartTimeKS.ResetText();
            cboStartTimeKS.SelectedIndex = -1;
            cboStartTimeKS.ResetText();
            txtKeywordKS.Text = "";
            resetCheckBoxes(pnlDaysKS);
        }

        private void btnClearClassesSearch_Click(object sender, EventArgs e)
        {
            cboTermsSC.SelectedIndex = -1;
            cboTermsSC.ResetText();
            cboLocationsSC.SelectedIndex = -1;
            cboLocationsSC.ResetText();
            cboStartTimeSC.SelectedIndex = -1;
            cboStartTimeSC.ResetText();
            cboEndTimeSC.SelectedIndex = -1;
            cboEndTimeSC.ResetText();
            cboRoomSC.SelectedIndex = -1;
            cboRoomSC.ResetText();
            resetCheckBoxes(pnlDaysSC);
        }

        private void resetCheckBoxes(Panel panel)
        {
            foreach (Control c in panel.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    ((CheckBox)c).Checked = false;
            }
        }

        #endregion

        #region Handling Submit Buttons with respect to each tab

        private void btnBasicSearch_Click(object sender, EventArgs e)
        {
            if (validateInputs(cboTermsBS, cboStartTimeBS, cboEndTimeBS))
            {
                getBasicSearchSelections();

                string CourseType = "", CourseStatus = "", startTime = "", startTime1 = "", CreditHrs1 = "", CreditHrs2 = "";
                List<string> Days= new List<string>();
                if (cboInstructorsBS.SelectedIndex >= 0)
                {
                    string[] name = cboInstructorsBS.SelectedItem.ToString().Split(' ');
                    instructor = new Instructor(name[0], name[1]);
                }
                if (courseTypeSelected)
                    CourseType = cboCrsTypesBS.SelectedItem.ToString();
                if (courseStatusSelected)
                    CourseStatus = cboStatusBS.SelectedItem.ToString();
                if (daySelected)
                    Days = getDays(pnlDaysBS);
                if (timingProvided)
                {
                    startTime = cboStartTimeBS.SelectedItem.ToString();
                    startTime1 = cboEndTimeBS.SelectedItem.ToString();
                }
                if (creditHoursProvided)
                {
                    CreditHrs1 = cboCreditHrs1BS.SelectedItem.ToString();
                    CreditHrs2 = cboCreditHrs2BS.SelectedItem.ToString();
                }
                
                ds = repository.findCourses(term, subject, building, instructor, txtCrsNoBS.Text, CourseType, CourseStatus, Days, txtTitleBS.Text, startTime, startTime1, CreditHrs1, CreditHrs2);
				courseTypeSelected = false;
				courseStatusSelected = false;
				daySelected = false;
				timingProvided = false;
				creditHoursProvided = false;
                populateSearchResults(ds);
            }
        }

        private void getBasicSearchSelections()
        {
            if (cboTermsBS.SelectedIndex >= 0)
                termSelected = true;
            if (cboSubjectsBS.SelectedIndex >= 0)
                subjectSelected = true;
            if (cboLocationsBS.SelectedIndex >= 0)
                locationSelected = true;
            if (cboInstructorsBS.SelectedIndex >= 0)
                InstructorSelected = true;
            if (txtCrsNoBS.Text != "")
                creditHrsProvided = true;
            if (cboCrsTypesBS.SelectedIndex >= 0)
                courseTypeSelected = true;
            if (cboStatusBS.SelectedIndex >= 0)
                courseStatusSelected = true;
            if (cbxMBS.Checked == true || cbxFBS.Checked == true || cbxSBS.Checked == true || cbxUBS.Checked == true || cbxRBS.Checked == true || cbxTBS.Checked == true || cbxWBS.Checked == true)
                daySelected = true;
            if (cboStartTimeBS.SelectedIndex >= 0)
                timingProvided = true;
            if (cboCreditHrs1BS.SelectedIndex >= 0)
                creditHoursProvided = true;

        }

        private void SearchByInstructor_Click(object sender, EventArgs e)
        {
            if (validateInputs(null, cboStartTimeSI, cboEndTimeSI))
            {
                getSearchByInstructorSelections();

                if (cboInstructorsSI.SelectedIndex >= 0)
                {
                    string[] name = cboInstructorsSI.SelectedItem.ToString().Split(' ');
                    instructor = new Instructor(name[0], name[1]);
                }

                string startTime = "", startTime1 = "";
                List<string> Days= new List<string>();;
                Days = getDays(pnlDays3);

                if (timingProvided)
                {
                    startTime = cboStartTimeSI.SelectedItem.ToString();
                    startTime1 = cboEndTimeSI.SelectedItem.ToString();
                }

                ds = repository.findCoursesbyInstructor( instructor, Days, startTime, startTime1);
				timingProvided = false;
                populateSearchResults(ds);
            }
        }

        private void getSearchByInstructorSelections()
        {

           if (cboInstructorsSI.SelectedIndex >= 0)
                InstructorSelected = true;


            if (cboStartTimeSI.SelectedIndex >= 0)
                timingProvided = true;


        }

        private void btnKeywordSearch_Click(object sender, EventArgs e)
        {
            if (validateInputs(cboTermsKS, cboStartTimeKS, cboEndTimeKS))
            {
                getKeywordSearchSelections();

                if (txtKeywordKS.Text.Contains(' '))
                {
                    string[] name = txtKeywordKS.Text.Split(' ');
                    instructor = new Instructor(name[0], name[1]);
                }
                else
                    instructor = new Instructor(txtKeywordKS.Text, txtKeywordKS.Text);

                string  startTime = "", startTime1 = "";
                List<string> Days= new List<string>();;
                Days = getDays(pnlDaysKS);

                if (timingProvided)
                {
                    startTime = cboStartTimeKS.SelectedItem.ToString();
                    startTime1 = cboEndTimeKS.SelectedItem.ToString();
                }

                ds = repository.findCoursesbyKeyword(term, instructor, txtKeywordKS.Text, Days, startTime, startTime1);
				timingProvided = false;
                populateSearchResults(ds);
            }
        }

        private void getKeywordSearchSelections()
        {

            if (cboTermsKS.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTermsKS.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }




            if (cboStartTimeKS.SelectedIndex >= 0)
                timingProvided = true;


        }

        private void btnAdhocSearch_Click(object sender, EventArgs e)
        {
            getAdhocSearchSelections();

            ds = repository.findCourses(term, subjects, cboCourseAS.SelectedItem.ToString(), txtCourseNoAS.Text, building, instructor, txtCreditHoursAS.Text, exclude, distanceLearning, creditcoursesprovided, courseOfferings);

            populateSearchResults(ds);
        }

        private void getAdhocSearchSelections()
        {
            if (cboTermsAS.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTermsAS.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }
            if (lstSubjectsAS.SelectedIndex >= 0)
            {

                subjects = new List<Subject>();
                foreach (string str in lstSubjectsAS.SelectedItems)
                {
                    subjects.Add(new Subject(str));
                }
            }
            if (cboLocationsAS.SelectedIndex >= 0)
            {
                locationSelected = true;

                building = new Building(cboLocationsAS.SelectedItem.ToString());
            }
            if (cboInstructorAS.SelectedIndex >= 0)
            {
                string[] name;
                InstructorSelected = true;
                if (!cboInstructorAS.SelectedItem.ToString().Equals("ALL"))
                {
                    name = cboInstructorAS.SelectedItem.ToString().Split(' ');
                    instructor = new Instructor(name[0], name[1]);
                }
                else
                    instructor = new Instructor(cboInstructorAS.SelectedItem.ToString(), cboInstructorAS.SelectedItem.ToString());
            }
            if (cbxDistanceLearningAS.Checked == true)
                distanceLearning = true;
            if (rdbtnCourseOfferAS.Checked == true)
                creditcoursesprovided = true;
            if (rdbtnCreditCoursesAS.Checked == true)
                courseOfferings = true;
            if (rdbtnIncludeAS.Checked == true)
                exclude = false;
            if (rdbtnExcludeAS.Checked == true)
                exclude = true;

        }

        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            if (validateInputs(cboTermsSC, cboStartTimeSC, cboEndTimeSC))
            {
                getSearchClassesSelections();
                
                string  startTime = "", startTime1 = "";
                List<string> Days= new List<string>();;
                Days = getDays(pnlDaysSC);

                if (timingProvided)
                {
                    startTime = cboStartTimeSC.SelectedItem.ToString();
                    startTime1 = cboEndTimeSC.SelectedItem.ToString();
                }

                ds = repository.findClasses(term, new Building(cboLocationsSC.SelectedItem.ToString()), cboRoomSC.SelectedItem.ToString(), Days, startTime, startTime1);
				timingProvided = false;
                populateSearchResults(ds);
            }
        }

        private void getSearchClassesSelections()
        {
            if (cboTermsSC.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTermsSC.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }
            if (cboLocationsSC.SelectedIndex >= 0)
                locationSelected = true;
            if (cboStartTimeSC.SelectedIndex >= 0)
                timingProvided = true;
        }

        #endregion

        #region send the Resultset to Results Screen

        private void populateSearchResults(DataSet ds)
        {
            tabindex = tabControl1.SelectedIndex;
            var resultsForm = new frmResults(ds, term);
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();
        }

        #endregion

        #region Validation of Inputs

        private bool validateInputs(ComboBox cboTerm, ComboBox cboStartTime, ComboBox cboEndTime)
        {
            /*validate term is choosen */
            if(tabControl1.SelectedIndex!=1)
            if (cboTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Term must be selected");
                return false;
            }


            /*validate start time */
            if (cboStartTime.SelectedIndex >= 0 || cboEndTime.SelectedIndex >= 0)
            {
                if (cboStartTime.SelectedIndex >= cboEndTime.SelectedIndex || cboStartTime.SelectedIndex < 0 || cboEndTime.SelectedIndex < 0)
                {
                    MessageBox.Show("Select a validate start time range ");
                    return false;
                }
            }

            /*validate Credit Hours  */
            if (tabControl1.SelectedIndex == 0)
            {
                if (cboCreditHrs1BS.SelectedIndex >= 0 || cboCreditHrs2BS.SelectedIndex >= 0)
                {
                    if (cboCreditHrs1BS.SelectedIndex >= cboCreditHrs2BS.SelectedIndex || cboCreditHrs1BS.SelectedIndex < 0 || cboCreditHrs2BS.SelectedIndex < 0)
                    {
                        MessageBox.Show("Select a validate  Credit Hours range ");
                        return false;
                    }
                }
            }

            /*validate Instructor is choosen */
            if (tabControl1.SelectedIndex == 1)
                if (cboInstructorsSI.SelectedIndex == -1)
                {
                    MessageBox.Show("Instructor must be selected");
                    return false;
                }

            /*validate location is choosen */
            if (tabControl1.SelectedIndex == 4)
                if (cboLocationsSC.SelectedIndex == -1)
                {
                    MessageBox.Show("Location must be selected");
                    return false;
                }

            /*validate location is choosen */
            if (tabControl1.SelectedIndex == 2)
                if (txtKeywordKS.Text.Equals(""))
                {
                    MessageBox.Show("Keyword must be provided");
                    return false;
                }
			/*validate room is choosen */
			if (tabControl1.SelectedIndex == 4)
				if (cboRoomSC.Text.Equals(""))
				{
					MessageBox.Show("Room must be provided");
					return false;
				}

            return true;
        }

        #endregion

        #region Get the selected Days in a Panel

        private List<string> getDays(Panel panel)
        {
            List<string> days = new List<string>(); 

            foreach (Control c in panel.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    days.Add(((CheckBox)c).Text);
            }          
                return days;
        }

        #endregion

      
    }
}
