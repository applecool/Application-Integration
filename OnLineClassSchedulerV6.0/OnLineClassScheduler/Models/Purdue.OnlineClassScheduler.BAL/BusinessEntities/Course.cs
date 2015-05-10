using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
	class Course
	{
		private int courseId;

		public int CourseId
		{
			get
			{
				return courseId;
			}
			set
			{
				courseId = value;
			}
		}

		private string courseNum;

		public string CourseNum
		{
			get
			{
				return courseNum;
			}
			set
			{
				courseNum = value;
			}
		}

		private string crn;

		public string Crn
		{
			get
			{
				return crn;
			}
			set
			{
				crn = value;
			}
		}

		private string credits;

		public string Credits
		{
			get
			{
				return credits;
			}
			set
			{
				credits = value;
			}
		}

		//Default constructor
		public Course()
		{
		}

	}
}
