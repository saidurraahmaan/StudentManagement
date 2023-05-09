using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    public class StudentController :MainApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
