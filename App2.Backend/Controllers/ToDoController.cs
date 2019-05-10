using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace App2.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        [HttpGet("Items")]
        public IActionResult GetTodoItems()
        {
            var todoList = new List<ToDoItem>()
            {
                new ToDoItem { Id = 1, Name = "Item 1" }
            };

            return Ok(todoList);
        }
    }
}