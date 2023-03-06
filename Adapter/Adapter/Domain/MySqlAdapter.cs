namespace Adapter.Domain
{
    public class MySqlAdapter : DbAdapter
    {
        private MySqlCommands SqlCommand { get; set; }
         public MySqlAdapter(MySqlCommands _sqlCommand)
        {
            this.SqlCommand = _sqlCommand;
        }
        public string Delete()
        {
           return this.SqlCommand.DeleteMySql();
        }

        public string Insert()
        {
            return this.SqlCommand.InsertMySql();
        }

        public string Update()
        {
            return this.SqlCommand.UpdateMySql();
        }

        public string ConectionDb()
        {
            return this.SqlCommand.ConectionMySql();
        }
    }
}
