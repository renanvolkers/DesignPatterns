using System.Text.Json;

namespace Bridge.Domain
{
    /// <summary>
    /// This class represents another ConcreteImplementor class and writes the given Employee details to 
    /// a JSON file.
    /// </summary>
    public class JSONWriter : IFileWriter
    {
        const string _fileName = "EmployeeSalaryDetails.json";

        public string FileName()
        {
            return _fileName;
        }

        public void WriteFile(Employee employee)
        {
            var serializedEmployeeData = JsonSerializer.Serialize(employee);
            File.WriteAllText(_fileName, serializedEmployeeData);
            Console.WriteLine($"EmployeeId# : {employee.Id} salary details sucessfully written to {_fileName} ");
        }
    }
}

