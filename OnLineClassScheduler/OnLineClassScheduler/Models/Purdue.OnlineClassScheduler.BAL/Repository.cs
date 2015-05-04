using Purdue.OnlineClassScheduler.BAL.BusinessEntities;
using Purdue.OnlineClassScheduler.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessRepositery
{
    public class Repository
    {

        public List<Term> getTerms()
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Term> lstterms = new List<Term>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader("SELECT DISTINCT  termId, quarter, year  FROM Terms");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstterms.Add(new Term(dr.GetString(1), Int32.Parse(dr.GetString(2))));
                }
            }
            return lstterms;
        }

        public List<Subject> getSubjects()
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Subject> lstSubjects = new List<Subject>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader("SELECT subject FROM   Subjects");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstSubjects.Add(new Subject(dr.GetString(0)));
                }
            }
            return lstSubjects;
        }

        public List<Subject> getSubjectsbyTerm(Term term)
        {
            String query = "SELECT Subjects.subject FROM  Courses INNER JOIN " +
                          "Sections ON Courses.courseId = Sections.courseId INNER JOIN " +
                          "Subjects ON Courses.subjectId = Subjects.subjectId INNER JOIN " +
                          "Terms term ON Sections.termId = term.termId " +
                          "WHERE  (term.quarter = '" + term.Quarter + "') AND (term.year =" + term.Year + ")";
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Subject> lstSubjects = new List<Subject>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader(query);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstSubjects.Add(new Subject(dr.GetString(0)));
                }
            }
            return lstSubjects;
        }

        public List<Building> getLocations()
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Building> lstBuildings = new List<Building>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader("SELECT building FROM  Buildings");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstBuildings.Add(new Building(dr.GetString(0)));
                }
            }
            return lstBuildings;
        }

        public List<Building> getLocations(Term term, Subject subject)
        {
            String query = "SELECT  Buildings.building FROM  Buildings INNER JOIN " +
                         "SectionLocations ON Buildings.buildingId = SectionLocations.buildingId INNER JOIN " +
                         "Sections ON SectionLocations.sectionId = Sections.sectionId INNER JOIN " +
                         "Courses ON Sections.courseId = Courses.courseId INNER JOIN " +
                         "Subjects ON Courses.subjectId = Subjects.subjectId INNER JOIN " +
                         "Terms ON Sections.termId = Terms.termId " +
                         "WHERE (Terms.quarter = '" + term.Quarter + "') AND (Subjects.subject = '" + subject.SubjectName + "') AND (Terms.year =" + term.Year + ")";
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Building> lstBuildings = new List<Building>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader(query);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstBuildings.Add(new Building(dr.GetString(0)));
                }
            }
            return lstBuildings;
        }

        public List<Instructor> getInstructors()
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Instructor> lstInstructors = new List<Instructor>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader("SELECT   firstName, lastName FROM   Instructors");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstInstructors.Add(new Instructor(dr.GetString(0), dr.GetString(1)));
                }
            }
            return lstInstructors;
        }

        public List<Instructor> getInstructor(Term term, Subject subject, Building building)
        {
            String query = "SELECT   Instructors.firstName, Instructors.lastName FROM  Instructors INNER JOIN " +
                           "Sections ON Instructors.instructorId = Sections.instructorId INNER JOIN " +
                           "Courses ON Sections.courseId = Courses.courseId INNER JOIN " +
                           "Subjects ON Courses.subjectId = Subjects.subjectId INNER JOIN " +
                           "Terms ON Sections.termId = Terms.termId INNER JOIN " +
                           "SectionLocations ON Sections.sectionId = SectionLocations.sectionId INNER JOIN " +
                           "Buildings ON SectionLocations.buildingId = Buildings.buildingId " +
                           "WHERE (Terms.quarter = '" + term.Quarter + "') AND " +
                           "(Subjects.subject = '" + subject.SubjectName + "') AND (Terms.year =" + term.Year + ") " +
                           " AND (Buildings.Building ='" + building.BuildingName + "')";
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Instructor> lstInstructors = new List<Instructor>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader(query);
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstInstructors.Add(new Instructor(dr.GetString(0), dr.GetString(1)));
                }
            }
            return lstInstructors;
        }

        public List<Schedule> getSchedule()
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            List<Schedule> lstSchedules = new List<Schedule>();
            SQLiteDataReader dr = DataAccessEntity1.ExecReader("SELECT   scheduleTypeId, scheduleType FROM     ScheduleTypes");
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstSchedules.Add(new Schedule(dr.GetInt16(0), dr.GetString(1)));
                }
            }
            return lstSchedules;
        }

        public DataSet findCourses(Term term, Subject subject, Building building, Instructor instructor, string CourseNo, string CourseType, string CourseStatus, string Days, string title, string startTime, string startTime1, string CreditHrs1, string CreditHrs2)
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            string query = "SELECT  C.CRN, S.subject AS [Subj.], C.courseNum AS [#], SC.sectionId AS Section, " +
                           "C.credits AS [Cr Hrs], SC.[enrlCap ] + '/' + SC.enrlAct AS [EnrollmentTaken/Avail], " +
                           "SC.waitCap || '/' || SC.waitAct AS [WaitlistTaken/Avail], SC.title AS Title, SC.[meetingStart ] || '-' ||SC.meetingEnd AS [Section Meeting Dates],  " +
                           "STP.scheduleType AS Type,  coalescE(ST.day, '-')  AS Days , ST.timeStart || '-' || ST.timeEnd AS Times, B.building || '-' || SL.roomNum AS [Building - Room],  " +
                           " case  WHEN (I.firstName)  is null  then  'To Be Announced' ELSE ( I.firstName || ' ' ||  I.lastName) END AS [Instructor], " +
                           " SC.notes AS [Important comments about the section]   " +
                           " FROM  Sections SC INNER JOIN" +
                           " Courses C ON SC.courseId = C.courseId LEFT OUTER JOIN" +
                           " SectionTimes ST ON SC.sectionId = ST.sectionId INNER JOIN" +
                           " Subjects S ON C.subjectId = S.subjectId INNER JOIN" +
                           " ScheduleTypes STP ON SC.scheduleTypeId = STP.scheduleTypeId INNER JOIN" +
                           " SectionLocations SL ON SC.sectionId = SL.sectionId INNER JOIN" +
                           " Buildings B ON B.buildingId = SL.buildingId LEFT OUTER JOIN" +
                           " Instructors I ON SC.instructorId = I.instructorId INNER JOIN" +
                           " Terms T ON SC.termId = T.termId " +
                           "WHERE T.quarter = '" + term.Quarter + "' AND T.[YEAR]='" + term.Year + "' ";
            if (subject != null)
                query += " AND S.SUBJECT='" + subject.SubjectName + "'";
            if (building != null)
                query += "AND B.building='" + building.BuildingName + "' ";
            if (instructor != null)
                query += " AND I.FIRSTNAME='" + instructor.FirstName + "' AND I.LASTNAME='" + instructor.LastName + "' ";
            if (!CourseNo.Equals(""))
                query += "AND C.courseNum like '%" + CourseNo + "%' ";
            if (!CourseType.Equals(""))
                query += "AND stP.SCHEDULETYPE ='" + CourseType + "' ";
            //if (!CourseStatus.Equals(""))
            //    query += "AND stP.SCHEDULETYPE ='" + CourseStatus + "' ";
            if (!Days.Equals(""))
                query += " AND ST.DAY IN(" + Days + ") ";
            if (!title.Equals(""))
                query += "AND SC.TITLE LIKE '%" + title + "%' ";
            switch (CourseStatus)
            {
                case "Cancel":
                    query += "AND SC.isCanceled=1 ";
                    break;
            }
            if (!startTime.Equals(""))
                query += "AND ST.TIMESTART >= '" + startTime + "' AND ST.TIMEEND <= '" + startTime1 + "' ";
            if (!CreditHrs1.Equals(""))
                query += "AND C.credits BETWEEN '" + CreditHrs1 + "' AND '" + CreditHrs2 + "' ";
            return DataAccessEntity1.Execute(query);

        }
        public DataSet findCoursesbyInstructor(Term term,  Instructor instructor,string Days, string startTime, string startTime1)
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            string query = "SELECT  C.CRN, S.subject AS [Subj.], C.courseNum AS [#], SC.sectionId AS Section, " +
                           "C.credits AS [Cr Hrs], SC.[enrlCap ] + '/' + SC.enrlAct AS [EnrollmentTaken/Avail], " +
                           "SC.waitCap || '/' || SC.waitAct AS [WaitlistTaken/Avail], SC.title AS Title, SC.[meetingStart ] || '-' ||SC.meetingEnd AS [Section Meeting Dates],  " +
                           "STP.scheduleType AS Type,  coalescE(ST.day, '-')  AS Days , ST.timeStart || '-' || ST.timeEnd AS Times, B.building || '-' || SL.roomNum AS [Building - Room],  " +
                           " case  WHEN (I.firstName)  is null  then  'To Be Announced' ELSE ( I.firstName || ' ' ||  I.lastName) END AS [Instructor], " +
                           " SC.notes AS [Important comments about the section]   " +
                           " FROM  Sections SC INNER JOIN" +
                           " Courses C ON SC.courseId = C.courseId inner JOIN" +
                           " SectionTimes ST ON SC.sectionId = ST.sectionId INNER JOIN" +
                           " Subjects S ON C.subjectId = S.subjectId INNER JOIN" +
                           " ScheduleTypes STP ON SC.scheduleTypeId = STP.scheduleTypeId INNER JOIN" +
                           " SectionLocations SL ON SC.sectionId = SL.sectionId INNER JOIN" +
                           " Buildings B ON B.buildingId = SL.buildingId LEFT OUTER JOIN" +
                           " Instructors I ON SC.instructorId = I.instructorId INNER JOIN" +
                           " Terms T ON SC.termId = T.termId " +
                           "WHERE T.quarter = '" + term.Quarter + "' AND T.[YEAR]='" + term.Year + "' ";
            
            if (instructor != null)
                query += " AND I.FIRSTNAME='" + instructor.FirstName + "' AND I.LASTNAME='" + instructor.LastName + "' ";
           
            //if (!CourseStatus.Equals(""))
            //    query += "AND stP.SCHEDULETYPE ='" + CourseStatus + "' ";
            if (!Days.Equals(""))
                query += " AND ST.DAY IN(" + Days + ") ";
            
           
            if (!startTime.Equals(""))
                query += "AND ST.TIMESTART >= '" + startTime + "' AND ST.TIMEEND <= '" + startTime1 + "' ";
            
            return DataAccessEntity1.Execute(query);

        }

        public DataSet findCourses(Term term, List<Subject> subjects, string courseOperator, string CourseNo, Building building, Instructor instructor, string creditHrs, bool exclude, bool distanceLearning, bool creditcoursesprovided, bool courseOfferings)
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            string query = "SELECT  C.CRN, S.subject AS [Subj.], C.courseNum AS [#], SC.sectionId AS Section, " +
                            " C.credits AS [Cr Hrs], SC.[enrlCap ] + '/' + SC.enrlAct AS [EnrollmentTaken/Avail], " +
                            " SC.waitCap || '/' || SC.waitAct AS [WaitlistTaken/Avail], SC.title AS Title, SC.[meetingStart ] || '-' ||SC.meetingEnd AS [Section Meeting Dates],  " +
                            " STP.scheduleType AS Type,  coalescE(ST.day, '-')  AS Days, ST.timeStart || '-' || ST.timeEnd AS Times, B.building || '-' || SL.roomNum AS [Building - Room],  " +
                            " case  WHEN (I.firstName)  is null  then  'To Be Announced' ELSE ( I.firstName || ' ' ||  I.lastName) END AS [Instructor], " +
                            " SC.notes AS [Important comments about the section]   " +
                            " FROM  Sections SC INNER JOIN" +
                            " Courses C ON SC.courseId = C.courseId LEFT OUTER JOIN" +
                            " SectionTimes ST ON SC.sectionId = ST.sectionId INNER JOIN" +
                            " Subjects S ON C.subjectId = S.subjectId INNER JOIN" +
                            " ScheduleTypes STP ON SC.scheduleTypeId = STP.scheduleTypeId INNER JOIN" +
                            " SectionLocations SL ON SC.sectionId = SL.sectionId INNER JOIN" +
                            " Buildings B ON B.buildingId = SL.buildingId LEFT OUTER JOIN" +
                            " Instructors I ON SC.instructorId = I.instructorId INNER JOIN" +
                            " Terms T ON SC.termId = T.termId " +
                           "WHERE T.quarter = '" + term.Quarter + "' AND T.[YEAR]='" + term.Year + "' ";
            if (subjects != null)
            {

                query += " AND S.SUBJECT in(";
                foreach (Subject subject in subjects)
                    query += "'" + subject.SubjectName + "',";
                query = query.TrimEnd(',');
                query += ") ";
            }
            if (!building.BuildingName.Equals("ALL"))
                query += "AND B.building='" + building.BuildingName + "' ";
            if (!instructor.FirstName.Equals("ALL"))
                query += " AND I.FIRSTNAME='" + instructor.FirstName + "' AND I.LASTNAME='" + instructor.LastName + "' ";
            if (!CourseNo.Equals("ALL"))
            {
                switch (courseOperator.Substring(0, 1))
                {
                    case "e":
                        query += "AND C.courseNum = " + CourseNo + " ";
                        break;
                    case "g":
                        query += "AND C.courseNum >=" + CourseNo + " ";
                        break;
                    case "l":
                        query += "AND C.courseNum <=" + CourseNo + " ";
                        break;
                }
            }
            if (exclude)
                query += "AND sc.isCanceled =0 ";
            if (distanceLearning)
                query += "AND sc.isOnline =1 ";
            if (courseOfferings)
                query += "AND sc.isEXL =1 ";
            if (creditcoursesprovided)
                query += "AND sc.isETIE =1 ";
            if (!creditHrs.Equals(""))
                query += "AND C.credits = " + creditHrs;
            return DataAccessEntity1.Execute(query);
        }

        public DataSet findCoursesbyKeyword(Term term, Instructor instructor, string keyword, string Days, string startTime, string startTime1)
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            string query = "SELECT  C.CRN, S.subject AS [Subj.], C.courseNum AS [#], SC.sectionId AS Section, " +
                           " C.credits AS [Cr Hrs], SC.[enrlCap ] + '/' + SC.enrlAct AS [EnrollmentTaken/Avail], " +
                           " SC.waitCap || '/' || SC.waitAct AS [WaitlistTaken/Avail], SC.title AS Title, SC.[meetingStart ] || '-' ||SC.meetingEnd AS [Section Meeting Dates],  " +
                           " STP.scheduleType AS Type,  coalescE(ST.day, '-')  AS Days , ST.timeStart || '-' || ST.timeEnd AS Times, B.building || '-' || SL.roomNum AS [Building - Room],  " +
                           " case  WHEN (I.firstName)  is null  then  'To Be Announced' ELSE ( I.firstName || ' ' ||  I.lastName) END AS [Instructor], "+ 
                           " SC.notes AS [Important comments about the section]   " +
                           " FROM  Sections SC INNER JOIN" +
                           " Courses C ON SC.courseId = C.courseId LEFT OUTER JOIN" +
                           " SectionTimes ST ON SC.sectionId = ST.sectionId LEFT OUTER JOIN" +
                           " Subjects S ON C.subjectId = S.subjectId LEFT OUTER JOIN" +
                           " ScheduleTypes STP ON SC.scheduleTypeId = STP.scheduleTypeId LEFT OUTER JOIN" +
                           " SectionLocations SL ON SC.sectionId = SL.sectionId INNER JOIN" +
                           " Buildings B ON B.buildingId = SL.buildingId LEFT OUTER JOIN" +
                           " Instructors I ON SC.instructorId = I.instructorId INNER JOIN" +
                           " Terms T ON SC.termId = T.termId " +
                           " WHERE (T.quarter = '" + term.Quarter + "' AND T.[YEAR]='" + term.Year + "') " +
                           " and  (S.SUBJECT like '%" + keyword + "%' " +
                           " or B.building like '%" + keyword + "%' " +
                           " or I.FIRSTNAME like '%" + instructor.FirstName + "%'  or I.LASTNAME like '%" + instructor.LastName + "%' " +
                           "or C.courseNum like '%" + keyword + "%' or stP.SCHEDULETYPE like '%" + keyword + "%' " +
                           "or SC.TITLE LIKE '%" + keyword + "%' " +
                           "or sl.roomNum LIKE '%" + keyword + "%' ";

            if (!Days.Equals(""))
                query += " AND ST.DAY IN(" + Days + ") ";


            if (!startTime.Equals(""))
                query += "AND ST.TIMESTART >= '" + startTime + "' AND ST.TIMEEND <= '" + startTime1 + "' ";
            query += ")";
            return DataAccessEntity1.Execute(query);

        }

        public DataSet findClasses(Building building, string roomNum, string Days, string startTime, string startTime1)
        {
            DataAccessEntity DataAccessEntity1 = new DataAccessEntity();
            string query = "SELECT B.building AS Building, SL.roomNum AS Room, ST.day AS Days, " +
                            " ST.timeStart, ST.timeEnd AS Times,  " +
                            "I.firstName, I.lastName, C.courseNum, S.subject, STP.scheduleType" +
                           " FROM  Sections SC INNER JOIN" +
                            " Courses C ON SC.courseId = C.courseId INNER JOIN" +
                            " SectionTimes ST ON SC.sectionId = ST.sectionId INNER JOIN" +
                             " Subjects S ON C.subjectId = S.subjectId INNER JOIN" +
                             " ScheduleTypes STP ON SC.scheduleTypeId = STP.scheduleTypeId INNER JOIN" +
                             " SectionLocations SL ON SC.sectionId = SL.sectionId INNER JOIN" +
                             " Buildings B ON B.buildingId = SL.buildingId INNER JOIN" +
                             " Instructors I ON SC.instructorId = I.instructorId INNER JOIN" +
                             " Terms T ON SC.termId = T.termId " +
                            "WHERE T.year=" + DateTime.Now.Year + " and B.building = '" + building.BuildingName + "' " +
                             "or sl.roomNum LIKE '%" + roomNum + "%' ";

            if (!Days.Equals(""))
                query += " AND ST.DAY IN(" + Days + ") ";


            if (!startTime.Equals(""))
                query += "AND ST.TIMESTART >= '" + startTime + "' AND ST.TIMEEND <= '" + startTime1 + "' ";

            return DataAccessEntity1.Execute(query);
        }


    }
}
