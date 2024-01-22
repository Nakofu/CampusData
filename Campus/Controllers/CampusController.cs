using System.Text;
using Campus.Data;
using Campus.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Campus.Controllers;

[ApiController]
public class CampusController : ControllerBase
{
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

    [EnableCors("AllowAny")]
    [HttpGet("/getInfo")]
    public async Task<string> GetStuff()
    {
        var strBuilder = new StringBuilder();
        
        strBuilder.Append("{\n");
        strBuilder.Append("  \"participants\": [\n");
        for (var i = 0; i < _participantsContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_participantsContext.Values.ToList()[i]);
            strBuilder.Append(i == _participantsContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"attendanceMobile\": [\n");
        for (var i = 0; i < _attendanceMobileContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_attendanceMobileContext.Values.ToList()[i]);
            strBuilder.Append(i == _attendanceMobileContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"attendanceWeb\": [\n");
        for (var i = 0; i < _attendanceWebContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_attendanceWebContext.Values.ToList()[i]);
            strBuilder.Append(i == _attendanceWebContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"honours\": [\n");
        for (var i = 0; i < _honoursContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_honoursContext.Values.ToList()[i]);
            strBuilder.Append(i == _honoursContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"applications\": [\n");
        for (var i = 0; i < _applicationsContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_applicationsContext.Values.ToList()[i]);
            strBuilder.Append(i == _applicationsContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"fundStipend\": [\n");
        for (var i = 0; i < _fundStipendContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_fundStipendContext.Values.ToList()[i]);
            strBuilder.Append(i == _fundStipendContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"fundPrivilege\": [\n");
        for (var i = 0; i < _fundPrivilegeContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_fundPrivilegeContext.Values.ToList()[i]);
            strBuilder.Append(i == _fundPrivilegeContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");

        strBuilder.Append("  \"fundBonus\": [\n");
        for (var i = 0; i < _fundBonusContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_fundBonusContext.Values.ToList()[i]);
            strBuilder.Append(i == _fundBonusContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"schools\": [\n");
        for (var i = 0; i < _schoolsContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_schoolsContext.Values.ToList()[i]);
            strBuilder.Append(i == _schoolsContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"majors\": [\n");
        for (var i = 0; i < _majorsContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_majorsContext.Values.ToList()[i]);
            strBuilder.Append(i == _majorsContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");
        
        strBuilder.Append("  \"pages\": [\n");
        for (var i = 0; i < _pagesContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_pagesContext.Values.ToList()[i]);
            strBuilder.Append(i == _pagesContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ],\n");

        strBuilder.Append("  \"regions\": [\n");
        for (var i = 0; i < _regionsContext.Values.ToList().Count; i++)
        {
            strBuilder.Append(_regionsContext.Values.ToList()[i]);
            strBuilder.Append(i == _regionsContext.Values.ToList().Count - 1 ? "\n" : ",\n");
        }
        strBuilder.Append("  ]\n");
        strBuilder.Append("}");

        return await Task.FromResult(strBuilder.ToString());
    }
    
    [HttpPost("/addParticipations")]
    public async Task<ActionResult<Participants>> AddParticipations(IEnumerable<Participants> participants)
    {
        foreach (var partic in participants)
            _participantsContext.Add(partic);
        await _participantsContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddParticipations), 0);
    }
    
    [HttpPost("/addApplications")]
    public async Task<ActionResult<Participants>> AddApplicationsContext(IEnumerable<Applications> applications)
    {
        foreach (var app in applications)
            _applicationsContext.Add(app);
        await _applicationsContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddApplicationsContext), 0);
    }

    [HttpPost("/addAttendanceMobile")]
    public async Task<ActionResult<Participants>> AddAttendanceMobileContext(IEnumerable<AttendanceMobile> attendanceMobiles)
    {
        foreach (var attendanceMobile in attendanceMobiles)
            _attendanceMobileContext.Add(attendanceMobile);
        await _attendanceMobileContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddAttendanceMobileContext), 0);
    }
    
    [HttpPost("/addAttendanceWeb")]
    public async Task<ActionResult<Participants>> AddAttendanceWebContext(IEnumerable<AttendanceWeb> items)
    {
        foreach (var item in items)
            _attendanceWebContext.Add(item);
        await _attendanceWebContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddAttendanceWebContext), 0);
    }
    
    [HttpPost("/addFundBonus")]
    public async Task<ActionResult<Participants>> AddFundBonusContext(IEnumerable<FundBonus> items)
    {
        foreach (var item in items)
            _fundBonusContext.Add(item);
        await _fundBonusContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddFundBonusContext), 0);
    }
    
    [HttpPost("/addFundPrivilege")]
    public async Task<ActionResult<Participants>> AddFundPrivilegeContext(IEnumerable<FundPrivilege> items)
    {
        foreach (var item in items)
            _fundPrivilegeContext.Add(item);
        await _fundPrivilegeContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddFundPrivilegeContext), 0);
    }
    
    [HttpPost("/addFundStipend")]
    public async Task<ActionResult<Participants>> AddFundStipendContext(IEnumerable<FundStipend> items)
    {
        foreach (var item in items)
            _fundStipendContext.Add(item);
        await _fundStipendContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddFundStipendContext), 0);
    }
    
    [HttpPost("/addHonours")]
    public async Task<ActionResult<Participants>> AddHonoursContext(IEnumerable<Honours> items)
    {
        foreach (var item in items)
            _honoursContext.Add(item);
        await _honoursContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddHonoursContext), 0);
    }
    
    [HttpPost("/addMajors")]
    public async Task<ActionResult<Participants>> AddMajorsContext(IEnumerable<Majors> items)
    {
        foreach (var item in items)
            _majorsContext.Add(item);
        await _majorsContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddMajorsContext), 0);
    }
    
    [HttpPost("/addPages")]
    public async Task<ActionResult<Participants>> AddPagesContext(IEnumerable<Pages> items)
    {
        foreach (var item in items)
            _pagesContext.Add(item);
        await _pagesContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddPagesContext), 0);
    }
    
    [HttpPost("/addRegions")]
    public async Task<ActionResult<Participants>> AddRegionsContext(IEnumerable<Regions> items)
    {
        foreach (var item in items)
            _regionsContext.Add(item);
        await _regionsContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddRegionsContext), 0);
    }
    
    [HttpPost("/addSchools")]
    public async Task<ActionResult<Participants>> AddSchoolsContext(IEnumerable<Schools> items)
    {
        foreach (var item in items)
            _schoolsContext.Add(item);
        await _schoolsContext.SaveChangesAsync();

        return CreatedAtAction(nameof(AddSchoolsContext), 0);
    }
}