using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class HonoursData
{
    public static IEnumerable<Honours> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/honours.json");
        
        return JsonConvert.DeserializeObject<List<Honours>>(jsonFile.ReadToEnd());
    }
}