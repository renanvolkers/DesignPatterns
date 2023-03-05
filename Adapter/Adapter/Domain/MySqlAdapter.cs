namespace Adapter.Domain
{
    public class MySqlAdapter : DbAdapter
    {
        private MySqlCommands SqlCommand { get; set; }
         public MySqlAdapter(MySqlCommands _sqlCommand)
        {
            this.SqlCommand = _sqlCommand;
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Insert()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
