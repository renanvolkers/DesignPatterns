namespace Composite.Domain
{
    public class CompanyDirectory : Employee
    {

        private List<Employee> EmployeeList { get; set; } = new List<Employee>();


        public string ShowEmployeeDetails()
        {
            var msg = " ";
            foreach (var emp in EmployeeList)
            {
                msg += emp.ShowEmployeeDetails();
            }
            return msg;

        }
    }

    public void AddEmployee(Employee emp)
    {
        this.EmployeeList.Add(emp);
    }

    public void RemoveEmployee(Employee emp)
    {
        EmployeeList.Remove(emp);
    }
}


