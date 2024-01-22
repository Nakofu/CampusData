using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class FundStipendData
{
    public static IEnumerable<FundStipend> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/fundStipend.json");
        
        return JsonConvert.DeserializeObject<List<FundStipend>>(jsonFile.ReadToEnd());
    }
}