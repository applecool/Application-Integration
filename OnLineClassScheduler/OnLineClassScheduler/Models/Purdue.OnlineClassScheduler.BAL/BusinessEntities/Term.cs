using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
    public class Term
    {
        private int termId;

        public int TermId
        {
            get { return termId; }
            set { termId = value; }
        }
        private string quarter;

        public string Quarter
        {
            get { return quarter; }
            set { quarter = value; }
        }
        private int year; // year should be int, why string?


        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        //Default constructor
        public Term()
        {
        }

        public Term(string quarter, int year)
        {
            this.quarter = quarter;
            this.year = year;
        }



    }

}
