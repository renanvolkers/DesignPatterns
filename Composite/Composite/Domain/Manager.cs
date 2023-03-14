using System.Xml.Linq;

namespace Composite.Domain
{
    public class Manager : Employee
    {
        private String name;
        private long empId;
        public string ShowEmployeeDetails()
        {
            return empId + " " + name;
        }
    }
}
