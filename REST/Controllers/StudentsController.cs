using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using REST.Data;
using REST.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAttendanceApi.Controllers
{
    [Route("api/attendance")]
    [ApiController]
    public class AttendanceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AttendanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpPost]
        //[Route("add")]
     /*   public async Task<IActionResult> AddAttendance([FromBody] StudentAttendence model)
        {
            if (model != null)
            {
                _context.StudentAttendances.Add(model);
                await _context.SaveChangesAsync();
                return Ok($"Attendance for {model.MonthName} added successfully");
            }
            else
            {
                return BadRequest("Invalid request data");
            }
        }*/

/*        [HttpGet]
        [Route("get/{month}")]
        public async Task<IActionResult> GetAttendance(string month)
        {
            var attendance = await _context.StudentAttendances.FirstOrDefaultAsync(a => a.MonthName == month);

            if (attendance != null)
            {
                return Ok(attendance);
            }
            else
            {
                return NotFound($"No attendance data found for {month}");
            }
        }*/

        [HttpGet]
        [Route("getall")]
        public async Task<IActionResult> GetAllAttendance()
        {
            var allAttendance = await _context.StudentAttendances.ToListAsync();
            return Ok(allAttendance);
        }
    }
}
