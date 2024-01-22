using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class ParticipantsData
{
    public static IEnumerable<Participants> Aa()
    {
        using var r = new StreamReader(Directory.GetCurrentDirectory() + "participants.json");
        
        var onj = JsonConvert.DeserializeObject<List<Participants>>(r.ReadToEnd());
        return onj;
    }
}