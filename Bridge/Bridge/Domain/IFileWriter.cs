namespace Bridge.Domain
{
    /// <summary>
    /// The interface represents the Implementor interface from the design pattern and exposes a single method 
    /// to write a given employee details to a file
    /// </summary>
    public interface IFileWriter
    {
        void WriteFile(Employee employee);
    }
}
