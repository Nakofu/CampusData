using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class AttendanceMobileData
{
    public static IEnumerable<AttendanceMobile> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/attendanceMobile.json");
        
        return JsonConvert.DeserializeObject<List<AttendanceMobile>>(jsonFile.ReadToEnd());
    }
}