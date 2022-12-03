using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace AbstractFactory.Example_1.Domain.ValueObj
{
    public enum TypePizza
    {
        Cheese = 0,
        Viggie = 1,
        Clam = 2,
        Pepperoni = 4,

    }
    public enum City
    {
        NY = 0,
        Chicago = 1,
        California = 2,

    }

    [JsonConverter(typeof(string))]
    public enum MessageDestinationType
    {
        None = 0,
        [EnumMember(Value = "SMS")]
        SMS = 1,
        [EnumMember(Value = "Email")]
        Email = 2,
        PushNotification = 3,
        UXP = 4,
        IntermediaryApp = 5,
        YouthApp = 6
    }
}
