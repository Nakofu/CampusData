using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class ParticipantsData
{
    public static IEnumerable<Participants> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/participants.json");
        
        return JsonConvert.DeserializeObject<List<Participants>>(jsonFile.ReadToEnd());
    }
}