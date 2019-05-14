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
                new ToDoItem { Id = 4, Name = "Item 4" },
                new ToDoItem { Id = 5, Name = "Item 5" },
                new ToDoItem { Id = 5, Name = "Item 6" },
                new ToDoItem { Id = 7, Name = "Item 7" },
                new ToDoItem { Id = 8, Name = "Item 8" },
                new ToDoItem { Id = 9, Name = "Item 9" },
                new ToDoItem { Id = 10, Name = "Item 10" },
                new ToDoItem { Id = 11, Name = "Item 11" },
            };

            return Ok(todoList);
        }
    }
}
