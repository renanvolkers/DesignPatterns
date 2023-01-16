using System.Text.Json.Serialization;

namespace AbstractFactory.Exemple_2.Domain
{
    public class Product
    {
        [JsonIgnore]
        public int Id       { get; set; }
        public string? Name {get;set;}
    }
}
