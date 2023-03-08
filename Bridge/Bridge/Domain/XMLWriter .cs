using System.Xml.Serialization;

namespace Bridge.Domain
{
    /// <summary>
    /// This class represent a ConcreteImplementor and write the given Employee details to 
    /// an XML file
    /// </summary>
    public class XMLWriter : IFileWriter
    {
        string fileName = "EmployeeSalaryDetails.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        FileStream fileStream;

        public void WriteFile(Employee employee)
        {
            fileStream = new FileStream(fileName, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, employee);
            Console.WriteLine($"EmployeeId# : {employee.Id} salary details sucessfully written to {fileName} ");
        }
    }
}
