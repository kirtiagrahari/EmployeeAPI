using Microsoft.AspNetCore.Mvc;

namespace employeeapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "John" },
                new { Id = 2, Name = "Alice" }
            });
        }
    }
}