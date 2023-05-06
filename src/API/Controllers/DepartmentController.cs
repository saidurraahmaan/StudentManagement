using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DepartmentController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("get all student");
        }
        [HttpGet("{code}")]
        public IActionResult GetA(string code)
        {
            return Ok("get this " + code + " department data");
        }
        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("Insert new department");
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Insert new department");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Insert new department");
        }
    }
}
