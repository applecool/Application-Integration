using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
    public class Instructor
    {
        private int instructorId;

        public int InstructorId
        {
            get { return instructorId; }
            set { instructorId = value; }
        }
       
        private string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        //Default constructor
        public Instructor(){
        }

        public Instructor(string firstName, string lastName)
        {
            
            this.firstName = firstName;
            this.lastName = lastName;
        }

      


    }
}
