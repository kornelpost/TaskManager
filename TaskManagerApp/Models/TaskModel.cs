using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerApp.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }
        [DisplayName("Task Name")]
        public string Name { get; set; }
        [DisplayName("Task Description")]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
