using System.Xml.Linq;

namespace Composite.Domain
{
    //Leaf

    public class Manager : Employee
    {

        public Manager(int empId,string name, string position)
        {
            this.Name = name;
            this.EmpId = EmpId;
            this.Position = position;
        }

        private string? Name { get; set; }
        private long EmpId { get; set; }
        private string? Position { get; set; }
        public string ShowEmployeeDetails()
        {
            return "/n "+EmpId + " " + Name + " " + Position;
        }
    }
}
