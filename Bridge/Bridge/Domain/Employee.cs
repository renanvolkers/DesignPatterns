namespace Bridge.Domain
{
    /// <summary>
    /// This class represent an Employee
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public decimal Incentive { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
