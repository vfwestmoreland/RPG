using System.Text.Json.Serialization;

namespace RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,

        Mage = 2,

        Healer = 3,

        Hulk = 4,

        Kraken = 5
    }
}
