namespace Composite.Domain
{

    //Leaf
    public class Developer : Employee
    {
        private String name;
        private long empId;
        private String position;

        public Developer(long empId, String name, String position)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
        }
        public string ShowEmployeeDetails()
        {
            return empId + " " + name ;
        }
    }
}
