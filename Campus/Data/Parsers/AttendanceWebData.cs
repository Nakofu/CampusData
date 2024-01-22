using System.Net.Mime;
using System.Text.Json;
using System.Text.Json.Serialization;
using Campus.Models;
using Newtonsoft.Json;

namespace Campus.Data;

public class AttendanceWebData
{
    public static IEnumerable<AttendanceWeb> GetData()
    {
        using var jsonFile = new StreamReader(Directory.GetCurrentDirectory() + "/Data/Mockup/attendanceWeb.json");
        
        return JsonConvert.DeserializeObject<List<AttendanceWeb>>(jsonFile.ReadToEnd());
    }
}