namespace Composite.Domain
{

    //Leaf
    public class Developer : Employee
    {
        private String Name { get; set; }
        private long EmpId { get; set; }
        private String Position { get; set; }

        public Developer(long empId, String name, String position)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Position = position;
        }
        public string ShowEmployeeDetails()
        {
            return " /n " +EmpId + " " + Name + "" + Position;
        }
    }
}
