namespace Bridge.Domain
{
    /// <summary>
    /// This is the RefinedConcrete class, this class processes salary data and write the
    /// data on the file.
    /// </summary>
    public class SalaryCalculator : ContentWriter
    {
        /// <summary>
        /// The constructor accepts IFileWriter object, and the value is supplied during the runtime
        /// </summary>
        /// <param name="fileWriter"></param>
        public SalaryCalculator(IFileWriter fileWriter) : base(fileWriter)
        {
        }

        /// <summary>
        /// The method processes the employee's salary and internally executes the WriteFile operation 
        /// to persists the employee data to a file.
        /// </summary>
        /// <param name="employee"></param>
        public void ProcessEmployeeSalary(Employee employee)
        {
            // Some Processing
            employee.TotalSalary = employee.Basic + employee.Incentive;
            Console.WriteLine($"EmployeeId# {employee.Id} calculated salary# {employee.TotalSalary}");
            fileWriter.WriteFile(employee);
        }

    }
}
