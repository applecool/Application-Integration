using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
    class Course
    {
        //Default constructor
        public Course(){
        }

        Subject subject;
        private int courseId;

        public int CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        private string courseNum;

        public string CourseNum
        {
            get { return courseNum; }
            set { courseNum = value; }
        }
        private string crn;

        public string Crn
        {
            get { return crn; }
            set { crn = value; }
        }
        private int credits; // this should be int why text?

        public int Credits
        {
            get { return credits; }
            set { credits = value; }
        }



        
    }
}
