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
                new ToDoItem { Id = 1, Name = "Item 1" },
                new ToDoItem { Id = 2, Name = "Item 2" },
                new ToDoItem { Id = 3, Name = "Item 3" },
            };

            return Ok(todoList);
        }
    }
}