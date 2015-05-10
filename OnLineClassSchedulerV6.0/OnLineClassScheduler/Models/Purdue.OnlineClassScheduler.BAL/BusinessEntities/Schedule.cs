using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
	public class Schedule
	{
		private int scheduleTypeId;

		public int ScheduleTypeId
		{
			get
			{
				return scheduleTypeId;
			}
			set
			{
				scheduleTypeId = value;
			}
		}

		private string scheduleType;

		public string ScheduleType
		{
			get
			{
				return scheduleType;
			}
			set
			{
				scheduleType = value;
			}
		}

		//Default constructor
		public Schedule()
		{
		}

		public Schedule(int scheduleTypeId, string scheduleType)
		{
			// TODO: Complete member initialization
			this.scheduleTypeId = scheduleTypeId;
			this.scheduleType = scheduleType;
		}

	}
}
