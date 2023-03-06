
namespace Adapter.Domain
{
    public class OracleCommands : DbAdapter
    {
        public string ConectionDb()
        {
           return "Conection Oracle";
        }

        public string Delete()
        {
            return "Delete Oracle";
        }

        public string Insert()
        {
            return "Insert Oracle";
        }

        public string Update()
        {
            return "Update Oracle";
        }
    }
}
