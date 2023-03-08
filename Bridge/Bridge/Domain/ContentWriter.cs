namespace Bridge.Domain
{
    /// <summary>
    /// This abstract class represents the Abstraction from the pattern and have different method 
    /// than that of Implementor interface.
    /// </summary>
    public abstract class ContentWriter
    {
        protected IFileWriter fileWriter;

        public ContentWriter(IFileWriter fileWriter)
        {
            this.fileWriter = fileWriter;
        }

        public virtual void WriteContent(Employee employee)
        {
            fileWriter.WriteFile(employee);
        }
    }
}
