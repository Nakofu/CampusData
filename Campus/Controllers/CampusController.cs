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
        strBuilder.Append("  \"participants\": [\n");
        for (var i = 0; i < participants.Count; i++)
        {
            strBuilder.Append(participants[i]);
            strBuilder.Append(i == participants.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"attendanceMobile\": [\n");
        for (var i = 0; i < attendanceMobile.Count; i++)
        {
            strBuilder.Append(attendanceMobile[i]);
            strBuilder.Append(i == attendanceMobile.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"attendanceWeb\": [\n");
        for (var i = 0; i < attendanceWeb.Count; i++)
        {
            strBuilder.Append(attendanceWeb[i]);
            strBuilder.Append(i == attendanceWeb.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"honours\": [\n");
        for (var i = 0; i < honours.Count; i++)
        {
            strBuilder.Append(honours[i]);
            strBuilder.Append(i == honours.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"applications\": [\n");
        for (var i = 0; i < applications.Count; i++)
        {
            strBuilder.Append(applications[i]);
            strBuilder.Append(i == applications.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"fundStipend\": [\n");
        for (var i = 0; i < fundStipend.Count; i++)
        {
            strBuilder.Append(fundStipend[i]);
            strBuilder.Append(i == fundStipend.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"fundPrivilege\": [\n");
        for (var i = 0; i < fundPrivilege.Count; i++)
        {
            strBuilder.Append(fundPrivilege[i]);
            strBuilder.Append(i == fundPrivilege.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");

        strBuilder.Append("  \"fundBonus\": [\n");
        for (var i = 0; i < fundBonus.Count; i++)
        {
            strBuilder.Append(fundBonus[i]);
            strBuilder.Append(i == fundBonus.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"schools\": [\n");
        for (var i = 0; i < schools.Count; i++)
        {
            strBuilder.Append(schools[i]);
            strBuilder.Append(i == schools.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"majors\": [\n");
        for (var i = 0; i < majors.Count; i++)
        {
            strBuilder.Append(majors[i]);
            strBuilder.Append(i == majors.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"pages\": [\n");
        for (var i = 0; i < pages.Count; i++)
        {
            strBuilder.Append(pages[i]);
            strBuilder.Append(i == pages.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");

        strBuilder.Append("  \"regions\": [\n");
        for (var i = 0; i < regions.Count; i++)
        {
            strBuilder.Append(regions[i]);
            strBuilder.Append(i == regions.Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ]\n");
        
        strBuilder.Append("}");

        return await Task.FromResult(strBuilder.ToString());
    }
}