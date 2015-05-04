using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.BAL.BusinessEntities
{
   public class Building
    {
        private int buildingId;

        public int BuildingId
        {
            get { return buildingId; }
            set { buildingId = value; }
        }
        private string buildingName;
      

        public string BuildingName
        {
            get { return buildingName; }
            set { buildingName = value; }
        }
        //Default constructor
        public Building(){
        }

        public Building(string buildingName)
        {
           
            this.buildingName = buildingName;
        }
        
       
    }
}
