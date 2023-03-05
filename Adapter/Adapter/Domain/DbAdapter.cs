namespace Adapter.Domain
{
    public interface DbAdapter
    {
        public void Insert();
        public void Update();
        public void Delete();
        public void ConectionDb();
    }
}
