using Microsoft.AspNetCore.Mvc;
using StudentManagement.API.Model;

namespace StudentManagement.API.Controllers
{
    
    public class DepartmentController : MainApiController
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
    public static class DepartmentStatic
    {
        private static List<Department> AllDeparment { get; set; } = new List<Department>();

        public static Department InsertDepartment(Department department)
        {
            AllDeparment.Add(department);
            return department;
        }

        public static Department GetDepartment(string code) 
        {
            return AllDeparment.FirstOrDefault(x => x.Code == code);
        }

        public static Department UpdateDepartment(string code, Department department)
        {
            foreach (var item in AllDeparment)
            {
                if(code == item.Code)
                {
                    item.Name = department.Name;
                }
            }
            return department;
        }


    }
}
