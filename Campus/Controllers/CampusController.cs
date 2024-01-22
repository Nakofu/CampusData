using System.Text;
using Campus.Data;
using Campus.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Campus.Controllers;

[ApiController]
public class CampusController : ControllerBase
{
    /*
    private readonly ApplicationsContext _applicationsContext;
    private readonly AttendanceMobileContext _attendanceMobileContext;
    private readonly AttendanceWebContext _attendanceWebContext;
    private readonly FundBonusContext _fundBonusContext;
    private readonly FundPrivilegeContext _fundPrivilegeContext;
    private readonly FundStipendContext _fundStipendContext;
    private readonly HonoursContext _honoursContext;
    private readonly MajorsContext _majorsContext;
    private readonly PagesContext _pagesContext;
    private readonly ParticipantsContext _participantsContext;
    private readonly RegionsContext _regionsContext;
    private readonly SchoolsContext _schoolsContext;
    
    public CampusController(ParticipantsContext participantsContext, 
        ApplicationsContext applicationsContext, 
        AttendanceMobileContext attendanceMobileContext, 
        AttendanceWebContext attendanceWebContext, 
        FundBonusContext fundBonusContext, 
        FundPrivilegeContext fundPrivilegeContext, 
        FundStipendContext fundStipendContext, 
        HonoursContext honoursContext, 
        MajorsContext majorsContext, 
        PagesContext pagesContext, 
        RegionsContext regionsContext, 
        SchoolsContext schoolsContext)
    {
        _participantsContext = participantsContext;
        _applicationsContext = applicationsContext;
        _attendanceMobileContext = attendanceMobileContext;
        _attendanceWebContext = attendanceWebContext;
        _fundBonusContext = fundBonusContext;
        _fundPrivilegeContext = fundPrivilegeContext;
        _fundStipendContext = fundStipendContext;
        _honoursContext = honoursContext;
        _majorsContext = majorsContext;
        _pagesContext = pagesContext;
        _regionsContext = regionsContext;
        _schoolsContext = schoolsContext;
    }
*/
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