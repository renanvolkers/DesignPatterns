namespace Composite.Domain
{
    public class Company
    {
        public string Execurte()
        {
            var msg = "";
            Developer dev1 = new Developer(100, "Lokesh Sharma", "Pro Developer");
            Developer dev2 = new Developer(101, "Vinay Sharma", "Developer");
            CompanyDirectory engDirectory = new CompanyDirectory();
            engDirectory.AddEmployee(dev1);
            engDirectory.AddEmployee(dev2);

            Manager man1 = new Manager(200, "Kushagra Garg", "SEO Manager");
            Manager man2 = new Manager(201, "Vikram Sharma ", "Kushagra's Manager");

            CompanyDirectory accDirectory = new CompanyDirectory();
            accDirectory.AddEmployee(man1);
            accDirectory.AddEmployee(man2);

            CompanyDirectory directory = new CompanyDirectory();
            directory.AddEmployee(engDirectory);
            directory.AddEmployee(accDirectory);
            msg = directory.ShowEmployeeDetails();

            return msg;
        }
    }
}
