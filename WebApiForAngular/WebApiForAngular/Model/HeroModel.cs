using Newtonsoft.Json;

namespace WebApiForAngular.Model
{
    public class HeroModel
    {
        [JsonProperty(PropertyName ="id")]
        public int Id { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
