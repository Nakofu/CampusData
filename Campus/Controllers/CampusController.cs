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
        var participants = ParticipantsData.GetData().ToList();
        var attendanceMobile = AttendanceMobileData.GetData().ToList();
        var attendanceWeb = AttendanceWebData.GetData().ToList();
        var honours = HonoursData.GetData().ToList();
        var applications = ApplicationsData.GetData().ToList();
        var fundBonus = FundBonusData.GetData().ToList();
        var fundPrivilege = FundPrivilegeData.GetData().ToList();
        var fundStipend = FundStipendData.GetData().ToList();
        var majors = MajorsData.GetData().ToList();
        var pages = PagesData.GetData().ToList();
        var regions = RegionsData.GetData().ToList();
        var schools = SchoolsData.GetData().ToList();
        
        var strBuilder = new StringBuilder();
        
        strBuilder.Append("{\n");
        
        AddToOutput(strBuilder, participants, "participants");
        AddToOutput(strBuilder, attendanceMobile, "attendanceMobile");
        AddToOutput(strBuilder, attendanceWeb, "attendanceWeb");
        AddToOutput(strBuilder, honours, "honours");
        AddToOutput(strBuilder, applications, "applications");
        AddToOutput(strBuilder, fundStipend, "fundStipend");
        AddToOutput(strBuilder, fundPrivilege, "fundPrivilege");
        AddToOutput(strBuilder, fundBonus, "fundBonus");
        AddToOutput(strBuilder, schools, "schools");
        AddToOutput(strBuilder, majors, "majors");
        AddToOutput(strBuilder, pages, "pages");
        AddToOutput(strBuilder, regions, "regions");
        
        strBuilder.Append("}");

        return await Task.FromResult(strBuilder.ToString());
    }

    private void AddToOutput<T>(StringBuilder strBuilder, List<T> data, string title)
    {
        strBuilder.Append($"  \"{title}\": [\n");
        for (var i = 0; i < data.Count; i++)
        {
            strBuilder.Append(data[i]);
            strBuilder.Append(i == data.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ]\n");
    }
}