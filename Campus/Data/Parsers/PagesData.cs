using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class PagesData
{
    public static IEnumerable<Pages> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/pages.json");
        
        return JsonConvert.DeserializeObject<List<Pages>>(jsonFile.ReadToEnd());
    }
}