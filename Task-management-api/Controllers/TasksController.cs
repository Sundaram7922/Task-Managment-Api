using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Task_management_api.Data;
using Task_management_api.Models;

namespace Task_management_api.Controllers
{
    [ApiController]
    [Route("tasks")]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _context;
        public TasksController(AppDbContext context) => _context = context;

        [HttpPost]
        [Authorize]
        public IActionResult CreateTask([FromBody] TaskItem task)
        {
            _context.Tasks.Add(task);
            _context.SaveChanges();
            return Ok(task);
        }

        [HttpGet("{id}")]
        [Authorize]
        public IActionResult GetTask(int id)
        {
            var task = _context.Tasks.Find(id);
            return task == null ? NotFound() : Ok(task);
        }

        [HttpGet("user/{userId}")]
        [Authorize]
        public IActionResult GetTasksByUser(int userId)
        {
            var tasks = _context.Tasks.Where(t => t.AssignedUserId == userId).ToList();
            return Ok(tasks);
        }
    }
}
