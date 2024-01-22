using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class RegionsData
{
    public static IEnumerable<Regions> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/regions.json");
        
        return JsonConvert.DeserializeObject<List<Regions>>(jsonFile.ReadToEnd());
    }
}