using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoIt.Models
{
    public class ToDoListItem
    {
        public int Id { get; set; }
        public bool IsFinished { get; set; }
        public string Description { get; set; }
    }
}
