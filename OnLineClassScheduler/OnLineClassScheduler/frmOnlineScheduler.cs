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
        public Repository cs;
        Term term; Subject subject; Building building; Instructor instructor;
        List<Subject> subjects;

        private void frmOnlineScheduler_Load(object sender, EventArgs e)
        {
            cs = new Repository();
            tabControl1.SelectedIndex = tabindex;
            loadTerms();
            loadSubjects();
            loadLocations();
            loadInstructors();
            loadSchedules();
            setDefault();
        }

        private void loadSchedules()
        {
            foreach (Schedule schedule in cs.getSchedule())
            {
                cboCrsTypes.Items.Add(schedule.ScheduleType);
            }
        }

        private void loadInstructors()
        {
            foreach (Instructor instructor in cs.getInstructors())
            {
                cboInstructor.Items.Add(instructor.FirstName + " " + instructor.LastName);
                cboInstructors3.Items.Add(instructor.FirstName + " " + instructor.LastName);
            }
        }

        private void loadLocations()
        {
            foreach (Building location in cs.getLocations())
            {
                cboLocations.Items.Add(location.BuildingName);
                cboLocations3.Items.Add(location.BuildingName);
            }
        }

        private void loadSubjects()
        {
            foreach (Subject subject in cs.getSubjects())
            {
                lstSubjects.Items.Add(subject.SubjectName);
            }
        }

        private void loadTerms()
        {
            foreach (Term term in cs.getTerms())
            {
                cboTerms.Items.Add(term.Quarter + " " + term.Year);
                cboTerms2.Items.Add(term.Quarter + " " + term.Year);
                cboTerms3.Items.Add(term.Quarter + " " + term.Year);
                cboTerms4.Items.Add(term.Quarter + " " + term.Year);
            }
        }

        private void setDefault()
        {
            cboTerms.SelectedIndex = 0;
            cboCourse.SelectedIndex = 0;
            txtCourseNo.Text = "ALL";
            cboLocations.Items.Add("ALL");
            cboLocations.SelectedItem = "ALL";
            cboInstructor.Items.Add("ALL");
            cboInstructor.SelectedItem = "ALL";
            rdbtnInclude.Checked = true;
        }

        private bool validateSearchInputs(ComboBox cboTerm, ComboBox cboStartTime, ComboBox cboEndTime)
        {
            /*validate term is choosen */
            if (cboTerm.SelectedIndex == -1)
            {
                MessageBox.Show("Term must be selected");
                return false;
            }
            /*validate start time */
            if (cboStartTime.SelectedIndex >= 0 || cboEndTime.SelectedIndex >= 0)
                if (cboStartTime.SelectedIndex >= cboEndTime.SelectedIndex)
                {
                    MessageBox.Show("Select a validate start time range ");
                    return false;
                }

            /*validate Credit Hours  */
            if (tabControl1.SelectedIndex == 0)
                if (cboCreditHrs1.SelectedIndex >= 0 || cboCreditHrs2.SelectedIndex >= 0)
                    if (cboCreditHrs1.SelectedIndex >= cboCreditHrs2.SelectedIndex)
                    {
                        MessageBox.Show("Select a validate  Credit Hours range ");
                        return false;
                    }

            /*validate Instructor is choosen */
            if (tabControl1.SelectedIndex == 1)
                if (cboInstructors3.SelectedIndex == -1)
                {
                    MessageBox.Show("Instructor must be selected");
                    return false;
                }
            return true;

        }

        private bool validateSearchInputs(ComboBox cboStartTime5, ComboBox cboEndTime5)
        {
            /*validate location is choosen */
            if (cboLocations3.SelectedIndex == -1)
            {
                MessageBox.Show("Location must be selected");
                return false;
            }
            /*validate start time */
            if (cboStartTime5.SelectedIndex >= 0 || cboEndTime5.SelectedIndex >= 0)
                if (cboStartTime5.SelectedIndex >= cboEndTime5.SelectedIndex)
                {
                    MessageBox.Show("Select a validate start time range ");
                    return false;
                }
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            setDefault();
        }

        private void btnClearBasicSearch_Click(object sender, EventArgs e)
        {
            cboTerms2.SelectedIndex = -1;
            cboSubjects.SelectedIndex = -1;
            cboLocations2.SelectedIndex = -1;
            cboInstructors2.SelectedIndex = -1;
            cboCrsTypes.SelectedIndex = -1;
            cboStartTime2.SelectedIndex = -1;
            cboEndTime2.SelectedIndex = -1;
            cboCreditHrs1.SelectedIndex = -1;
            cboCreditHrs2.SelectedIndex = -1;
            txtCourseNo.Text = "";
            cboStatus.SelectedIndex = -1;
            txtTitle.Text = "";
            resetCheckBoxes(pnlDays2);
        }

        private void btnClearInstructorSearch_Click(object sender, EventArgs e)
        {
            cboTerms3.SelectedIndex = -1;
            cboInstructors3.SelectedIndex = -1;
            cboStartTime3.SelectedIndex = -1;
            cboEndTime3.SelectedIndex = -1;
            resetCheckBoxes(pnlDays3);
        }

        private void btnClearKeywordSearch_Click(object sender, EventArgs e)
        {
            cboTerms4.SelectedIndex = -1;
            cboStartTime4.SelectedIndex = -1;
            cboEndTime4.SelectedIndex = -1;
            txtKeyword.Text = "";
            resetCheckBoxes(pnlDays4);
        }

        private void btnClearClassesSearch_Click(object sender, EventArgs e)
        {
            cboLocations3.SelectedIndex = -1;
            cboStartTime5.SelectedIndex = -1;
            cboEndTime5.SelectedIndex = -1;
            txtRoomNo.Text = "";
            resetCheckBoxes(pnlDays5);
        }

        private void resetCheckBoxes(Panel panel1)
        {
            foreach (Control c in panel1.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    ((CheckBox)c).Checked = false;
            }
        }

        private string getDays(Panel panel1)
        {
            string days = "";
            foreach (Control c in panel1.Controls)
            {
                if ((c is CheckBox) && ((CheckBox)c).Checked)
                    days += "'" + ((CheckBox)c).Text + "',";
            }
            if (days.Length > 0)
                return days.Remove(days.Length - 1);
            else return days;
        }

        private void populateResults()
        {

            if (cboInstructors2.SelectedIndex >= 0)
            {
                string[] name = cboInstructors2.SelectedItem.ToString().Split(' ');
                instructor = new Instructor(name[0], name[1]);
            }
            string CourseType = "", CourseStatus = "", Days = "", startTime = "", startTime1 = "", CreditHrs1 = "", CreditHrs2 = "";
            if (courseTypeSelected) CourseType = cboCourse.SelectedItem.ToString();
            if (courseStatusSelected) CourseStatus = cboCrsTypes.SelectedItem.ToString();
            if (daySelected) Days = getDays(pnlDays2);
            if (timingProvided) { startTime = cboStartTime2.SelectedItem.ToString(); startTime1 = cboEndTime2.SelectedItem.ToString(); }
            if (creditHoursProvided) { CreditHrs1 = cboCreditHrs1.SelectedItem.ToString(); CreditHrs2 = cboCreditHrs2.SelectedItem.ToString(); }
            DataSet ds = new DataSet();
            ds = cs.findCourses(term, subject, building, instructor, txtCrsNo.Text, CourseType, CourseStatus, Days, txtTitle.Text, startTime, startTime1, CreditHrs1, CreditHrs2);
            var resultsForm = new frmResults(ds, term);
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();
        }

        private void populateResults2()
        {

            if (cboInstructors3.SelectedIndex >= 0)
            {
                string[] name = cboInstructors3.SelectedItem.ToString().Split(' ');
                instructor = new Instructor(name[0], name[1]);
            }
            string Days = "", startTime = "", startTime1 = "";
            Days = getDays(pnlDays3);
            if (timingProvided) { startTime = cboStartTime3.SelectedItem.ToString(); startTime1 = cboEndTime3.SelectedItem.ToString(); }

            DataSet ds = new DataSet();
            ds = cs.findCoursesbyInstructor(term,instructor, Days,  startTime, startTime1);

            var resultsForm = new frmResults(ds, term);
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();
        }

        private void populateResults3()
        {
            if (txtKeyword.Text.Contains(' '))
            {
                string[] name = txtKeyword.Text.Split(' ');
                instructor = new Instructor(name[0], name[1]);
            }
            else instructor = new Instructor(txtKeyword.Text, txtKeyword.Text);
            string Days = "", startTime = "", startTime1 = "";
            Days = getDays(pnlDays4);
            if (timingProvided) { startTime = cboStartTime4.SelectedItem.ToString(); startTime1 = cboEndTime4.SelectedItem.ToString(); }

            DataSet ds = new DataSet();
            ds = cs.findCoursesbyKeyword(term, instructor, txtKeyword.Text, Days, startTime, startTime1);
            var resultsForm = new frmResults(ds, term);
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();
        }

        private void populateResults4()
        {


            string Days = "", startTime = "", startTime1 = "";
            Days = getDays(pnlDays5);
            if (timingProvided) { startTime = cboStartTime5.SelectedItem.ToString(); startTime1 = cboEndTime5.SelectedItem.ToString(); }

            DataSet ds = new DataSet();
            ds = cs.findClasses(new Building(cboLocations3.SelectedItem.ToString()), txtRoomNo.Text, Days, startTime, startTime1);
            var resultsForm = new frmResults(ds, new Term("", DateTime.Now.Year));
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();
        }

        private void getSelections5()
        {
            if (cboTerms.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTerms.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }
            if (lstSubjects.SelectedIndex >= 0)
            {

                subjects = new List<Subject>();
                foreach (string str in lstSubjects.SelectedItems)
                {
                    subjects.Add(new Subject(str));
                }
            }
            if (cboLocations.SelectedIndex >= 0)
            {
                locationSelected = true;

                building = new Building(cboLocations.SelectedItem.ToString());
            }
            if (cboInstructor.SelectedIndex >= 0)
            {
                string[] name;
                InstructorSelected = true;
                if (!cboInstructor.SelectedItem.ToString().Equals("ALL"))
                {
                    name = cboInstructor.SelectedItem.ToString().Split(' ');
                    instructor = new Instructor(name[0], name[1]);
                }
                else instructor = new Instructor(cboInstructor.SelectedItem.ToString(), cboInstructor.SelectedItem.ToString());
            }
            if (cbxDistanceLearning.Checked == true)
                distanceLearning = true;
            if (rdbtnCourseOffer.Checked == true)
                creditcoursesprovided = true;
            if (rdbtnCreditCourses.Checked == true)
                courseOfferings = true;
            if (rdbtnInclude.Checked == true)
                exclude = false;
            if (rdbtnExclude.Checked == true)
                exclude = true;

        }

        private void getSelections()
        {
            if (cboTerms2.SelectedIndex >= 0)
                termSelected = true;
            if (cboSubjects.SelectedIndex >= 0)
                subjectSelected = true;
            if (cboLocations2.SelectedIndex >= 0)
                locationSelected = true;
            if (cboInstructors2.SelectedIndex >= 0)
                InstructorSelected = true;
            if (txtCrsNo.Text != "")
                creditHrsProvided = true;
            if (cboCrsTypes.SelectedIndex >= 0)
                courseTypeSelected = true;
            if (cboStatus.SelectedIndex >= 0)
                courseStatusSelected = true;
            if (cbxMonday.Checked == true || cbxFriday.Checked == true || cbxSaturday.Checked == true || cbxSunday.Checked == true || cbxThursday.Checked == true || cbxTuesday.Checked == true || cbxWednesday.Checked == true)
                daySelected = true;
            if (cboStartTime2.SelectedIndex >= 0)
                timingProvided = true;
            if (cboCreditHrs1.SelectedIndex >= 0)
                creditHoursProvided = true;

        }

        private void getSelections2()
        {

            if (cboTerms3.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTerms3.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }

            if (cboInstructors3.SelectedIndex >= 0)
                InstructorSelected = true;


            if (cboStartTime3.SelectedIndex >= 0)
                timingProvided = true;


        }

        private void getSelections3()
        {

            if (cboTerms4.SelectedIndex >= 0)
            {
                termSelected = true;
                string[] terms = cboTerms4.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
            }




            if (cboStartTime4.SelectedIndex >= 0)
                timingProvided = true;


        }

        private void getSelections4()
        {

            if (cboLocations3.SelectedIndex >= 0)
                locationSelected = true;

            if (cboStartTime5.SelectedIndex >= 0)
                timingProvided = true;


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            getSelections5();


            DataSet ds = new DataSet();
            ds = cs.findCourses(term, subjects, cboCourse.SelectedItem.ToString(), txtCourseNo.Text, building, instructor, txtCreditHours.Text, exclude, distanceLearning, creditcoursesprovided, courseOfferings);
            tabindex = tabControl1.SelectedIndex;
            var resultsForm = new frmResults(ds, term);
            resultsForm.Show();
            resultsForm.Activate();
            this.Hide();

        }

        private void btnBasicSearch_Click(object sender, EventArgs e)
        {
            if (validateSearchInputs(cboTerms2, cboStartTime2, cboEndTime2))
            {
                getSelections(); tabindex = tabControl1.SelectedIndex;
                populateResults();
            }
        }

        private void SearchByInstructor_Click(object sender, EventArgs e)
        {
            if (validateSearchInputs(cboTerms3, cboStartTime3, cboEndTime3))
            {
                tabindex = tabControl1.SelectedIndex;
                getSelections2();
                populateResults2();
            }
        }

        private void btnKeywordSearch_Click(object sender, EventArgs e)
        {
            if (validateSearchInputs(cboTerms4, cboStartTime4, cboEndTime4))
            {
                tabindex = tabControl1.SelectedIndex;
                getSelections3();
                populateResults3();
            }
        }

        private void btnSearchClasses_Click(object sender, EventArgs e)
        {
            if (validateSearchInputs(cboStartTime5, cboEndTime5))
            {
                tabindex = tabControl1.SelectedIndex;
                getSelections4();
                populateResults4();
            }
        }

        private void cboTerms2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTerms2.SelectedIndex >= 0)
            {
                string[] terms = cboTerms2.SelectedItem.ToString().Split(' ');
                term = new Term(terms[0], Int32.Parse(terms[1]));
                foreach (Subject subject in cs.getSubjectsbyTerm(term))
                {
                    cboSubjects.Items.Add(subject.SubjectName);
                }
            }
        }

        private void cboSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSubjects.SelectedIndex >= 0)
            {
                subject = new Subject(cboSubjects.SelectedItem.ToString());
                foreach (Building location in cs.getLocations(term, subject))
                {

                    cboLocations2.Items.Add(location.BuildingName);

                }
            }
        }

        private void cboLocation2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLocations2.SelectedIndex >= 0)
            {

                building = new Building(cboLocations2.SelectedItem.ToString());
                foreach (Instructor instructor in cs.getInstructor(term, subject, building))
                {

                    cboInstructors2.Items.Add(instructor.FirstName + " " + instructor.LastName);

                }
            }
        }

    }
}
