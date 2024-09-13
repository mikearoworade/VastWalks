using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VastWalks.API.Controllers
{
    //https:localhost:7214/api/Students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        //GET: https://localhost:7214/api/Students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            String[] studentsNames = new String[] { "John", "Jane", "Mark", "Emily", "David" };

            return Ok(studentsNames);
        }
      
    }
}
