using System.Xml.Linq;

namespace Composite.Domain
{
    public class Manager : Employee
    {
        private string? Name { get; set; }
        private long EmpId { get; set; }
        public string ShowEmployeeDetails()
        {
            return EmpId + " " + Name;
        }
    }
}
