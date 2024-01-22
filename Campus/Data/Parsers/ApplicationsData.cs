using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class ApplicationsData
{
    public static IEnumerable<Applications> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/applications.json");
        
        return JsonConvert.DeserializeObject<List<Applications>>(jsonFile.ReadToEnd());
    }
}