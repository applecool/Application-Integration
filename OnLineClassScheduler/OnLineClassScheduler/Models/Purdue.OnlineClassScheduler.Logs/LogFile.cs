using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Purdue.OnlineClassScheduler.Logs
{
    public class LogFile
    {
        private string sLogFormat;
        private string sErrorTime;

        public LogFile()
        {
            sLogFormat = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
            string sYear = DateTime.Now.Year.ToString();
            string sMonth = DateTime.Now.Month.ToString();
            string sDay = DateTime.Now.Day.ToString();
            sErrorTime = sYear + sMonth + sDay;
        }

        public void Create(string errMsg)
        {
            FileStream filestream = new FileStream(Directory.GetCurrentDirectory() + sErrorTime + ".txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter streamWriter = new StreamWriter(filestream);
            streamWriter.WriteLine(sLogFormat + errMsg);
            streamWriter.Flush();
            streamWriter.Close();
          
            filestream.Close();
        }
    }
}
