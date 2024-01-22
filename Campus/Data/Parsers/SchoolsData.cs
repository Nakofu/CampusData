using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class SchoolsData
{
    public static IEnumerable<Schools> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/schools.json");
        
        return JsonConvert.DeserializeObject<List<Schools>>(jsonFile.ReadToEnd());
    }
}