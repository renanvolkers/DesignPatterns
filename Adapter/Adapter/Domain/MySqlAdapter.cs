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
            this.SqlCommand.DeleteMySql();
        }

        public void Insert()
        {
            this.SqlCommand.InsertMySql();
        }

        public void Update()
        {
            this.SqlCommand.UpdateMySql();
        }
    }
}
