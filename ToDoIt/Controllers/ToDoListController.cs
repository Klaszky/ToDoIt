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
    public class ToDoListController : Controller
    {
        private readonly ILogger<ToDoListController> _logger;

        public ToDoListController(ILogger<ToDoListController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getToDo")]
        public IEnumerable<ToDoListItem> GetToDo()
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
