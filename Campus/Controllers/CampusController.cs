using System.Text;
using Campus.Data;
using Campus.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Campus.Controllers;

[ApiController]
public class CampusController : ControllerBase
{
    [EnableCors("AllowAny")]
    [HttpGet("/getInfo")]
    public async Task<string> GetStuff()
    {
        var strBuilder = new StringBuilder();
        
        strBuilder.Append("{\n");
        
        AddToOutput(strBuilder, ParticipantsData.GetData().ToList(), "participants");
        AddToOutput(strBuilder, AttendanceMobileData.GetData().ToList(), "attendanceMobile");
        AddToOutput(strBuilder, AttendanceWebData.GetData().ToList(), "attendanceWeb");
        AddToOutput(strBuilder, HonoursData.GetData().ToList(), "honours");
        AddToOutput(strBuilder, ApplicationsData.GetData().ToList(), "applications");
        AddToOutput(strBuilder, FundStipendData.GetData().ToList(), "fundStipend");
        AddToOutput(strBuilder, FundPrivilegeData.GetData().ToList(), "fundPrivilege");
        AddToOutput(strBuilder, FundBonusData.GetData().ToList(), "fundBonus");
        AddToOutput(strBuilder, SchoolsData.GetData().ToList(), "schools");
        AddToOutput(strBuilder, MajorsData.GetData().ToList(), "majors");
        AddToOutput(strBuilder, PagesData.GetData().ToList(), "pages");
        AddToOutput(strBuilder, RegionsData.GetData().ToList(), "regions");
        
        strBuilder.Append("}");

        return await Task.FromResult(strBuilder.ToString());
    }

    private void AddToOutput<T>(StringBuilder strBuilder, List<T> data, string title)
    {
        var dataCount = data.Count;
        
        strBuilder.Append($"  \"{title}\": [\n");
        for (var i = 0; i < dataCount; i++)
        {
            strBuilder.Append(data[i]);
            strBuilder.Append(i == dataCount - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ]\n");
    }
}