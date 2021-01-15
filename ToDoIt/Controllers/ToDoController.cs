using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ToDoIt.Models;

namespace ToDoIt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : Controller
    {
        private readonly ILogger<ToDoController> _logger;

        public ToDoController(ILogger<ToDoController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getToDos")]
        public IEnumerable<ToDoListItem> GetToDos()
        {

            var item1 = new ToDoListItem { Id = 0, IsFinished = true, Description = "Test 1"};
            var item2 = new ToDoListItem { Id = 1, IsFinished = false, Description = "Test 2" };
            var temp = new ToDoListItem[2];
            temp[0] = item1;
            temp[1] = item2;


            return temp;
        }
    }
}
