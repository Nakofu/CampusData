using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class FundPrivilegeData
{
    public static IEnumerable<FundPrivilege> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/fundPrivilege.json");
        
        return JsonConvert.DeserializeObject<List<FundPrivilege>>(jsonFile.ReadToEnd());
    }
}