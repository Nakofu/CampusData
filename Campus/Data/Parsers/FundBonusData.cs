using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class FundBonusData
{
    public static IEnumerable<FundBonus> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/fundBonus.json");
        
        return JsonConvert.DeserializeObject<List<FundBonus>>(jsonFile.ReadToEnd());
    }
}