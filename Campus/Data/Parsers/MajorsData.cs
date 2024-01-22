using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class MajorsData
{
    public static IEnumerable<Majors> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/majors.json");
        
        return JsonConvert.DeserializeObject<List<Majors>>(jsonFile.ReadToEnd());
    }
}