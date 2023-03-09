namespace Bridge.Domain
{
    public class Application
    {
        public string FileEmployee(Employee employee,TypeFile file)
        {
            SalaryCalculator salaryCalculator;
            if (TypeFile.Xml == file)
            {
                salaryCalculator = new SalaryCalculator(new XMLWriter());
                salaryCalculator.ProcessEmployeeSalary(employee);
                employee.Incentive = 2500;
                
            }
            else
            {
                salaryCalculator = new SalaryCalculator(new JSONWriter());
                salaryCalculator.ProcessEmployeeSalary(employee);
            }

            return salaryCalculator.FileName();

        }

    }
}
