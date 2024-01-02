using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApp.Domain.Entities
{
    public class WorkItemRegistrationEntity
    {
        [Key]
        public int Id { get; set; }

        public DateOnly RegistrationDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int UserStory { get; set; }
        public int Task { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }
    }
}