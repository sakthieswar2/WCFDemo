using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace HelloService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string SayHello(string name)
        {
            string result = "";
            var hour = DateTime.Now.Hour;
            if (hour > 4 && hour < 12)
                result = "good morning " + name;
            else if(hour > 12 && hour < 16)
                result = "good afternoon " + name;
            else if (hour > 16 && hour < 19)
                result = "good evening " + name;
            else
                result = "good night " + name;
            return result;
        }

        public string TodayProgram(string name)
        {
            string result = "";
            var day = DateTime.Now.DayOfWeek.ToString();
            if (day == "Saturday" || day == "Saturday")
                result = "Happy weekend " + name;
            else
                result = "Enjoy Working day " + name;
            return result;
        }
    }
}
