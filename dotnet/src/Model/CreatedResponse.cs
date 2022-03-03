namespace Tournaments.Model
{
    using System.Text.Json.Serialization;

    public class CreatedResponse
    {

        public CreatedResponse(string id)
        {
            Id = id;
        }
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}