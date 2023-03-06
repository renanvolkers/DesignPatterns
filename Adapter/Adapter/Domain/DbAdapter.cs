namespace Adapter.Domain
{
    public interface DbAdapter
    {
        public string Insert();
        public string Update();
        public string Delete();
        public string ConectionDb();
    }
}
