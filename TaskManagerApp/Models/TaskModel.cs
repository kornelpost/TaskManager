using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerApp.Models
{
    [Table("Tasks")]
    public class TaskModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Task Name")]
        [Required(ErrorMessage ="Field required")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Task Description")]
        [MaxLength(200)]
        public string Description { get; set; }
        public bool Done { get; set; }
    }
}
