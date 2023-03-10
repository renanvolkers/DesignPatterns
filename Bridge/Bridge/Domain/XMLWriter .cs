using System.Xml.Serialization;

namespace Bridge.Domain
{
    /// <summary>
    /// This class represent a ConcreteImplementor and write the given Employee details to 
    /// an XML file
    /// </summary>
    public class XMLWriter : IFileWriter
    {
       const string _fileName = "EmployeeSalaryDetails.xml";
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        FileStream? fileStream;

        public string FileName()
        {
            return _fileName;
        }

        public void WriteFile(Employee employee)
        {
            fileStream = new FileStream(_fileName, FileMode.OpenOrCreate);
            xmlSerializer.Serialize(fileStream, employee);
            Console.WriteLine($"EmployeeId# : {employee.Id} salary details sucessfully written to {_fileName} ");
        }
    }
}
