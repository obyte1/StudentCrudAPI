using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentCrud.Domain.Implementation;
using StudentCrud.Dto;
using StudentCrud.Model;

namespace StudentCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentManager _studentManager;
        public StudentController(IStudentManager _studentManager)
        {
            this._studentManager = _studentManager;
        }

        [HttpPost("students")]
        public async Task<IActionResult> Register([FromBody] studentrequest request)
        {
            var response = await _studentManager.Register(request);
            if(response.Status) return Ok(response);
            return BadRequest(response);
        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateStudent([FromBody] studentrequest request)
        {
            var response = await _studentManager.UpdateStudent(request);
            if (response.Status) return Ok(response);
            return BadRequest(response);           
        }

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteStudent(Guid studentId)
        {
            var response = await _studentManager.DeleteStudent(studentId);
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }


        [HttpGet("AllStudents")]
        public async Task<IActionResult> GetallStudent()
        {
            var response = await _studentManager.getAllStudents();
            if (response.Status) return Ok(response);
            return BadRequest(response);
        }
    }
}
