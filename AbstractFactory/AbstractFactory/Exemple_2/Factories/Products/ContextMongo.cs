using AbstractFactory.Exemple_2.Domain;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace AbstractFactory.Exemple_2.Factories.Products
{
    public class ContextMongo : DbContext, ContextDataBase
    {
        public string? ConnectionString { get; set; }
        public string? DatabaseName { get; set; }
        public bool IsSSL { get; set; }
        private IMongoDatabase? _database { get; set; }

        public void OnConfiguring()
        {
            try
            {
                MongoClientSettings settings = MongoClientSettings.FromUrl(new MongoUrl(ConnectionString));
                if (IsSSL)
                {
                    settings.SslSettings = new SslSettings { EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12 };
                }
                var mongoClient = new MongoClient(settings);
                _database = mongoClient.GetDatabase(DatabaseName);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar com o servidor.", ex);
            }
        }

        public IQueryable<Product> Get(Expression<Func<Product, bool>> predicate)
        {
            throw new NotImplementedException();
        }
    }
}
