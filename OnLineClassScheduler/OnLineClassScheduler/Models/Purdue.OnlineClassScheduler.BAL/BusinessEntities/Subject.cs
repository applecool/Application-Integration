using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
   public class Subject
    {
        private int subjectId;

        public int SubjectId
        {
            get { return subjectId; }
            set { subjectId = value; }
        }
        private string subjectName;


        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        public Subject(){
        }

        public Subject( string subjectName)
        {
           
            this.subjectName = subjectName;
        }

       
       

    }
}
