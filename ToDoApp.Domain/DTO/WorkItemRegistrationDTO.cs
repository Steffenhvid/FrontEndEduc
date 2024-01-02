using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ToDoApp.Domain.DTO
{
    public class WorkItemRegistrationDTO
    {
        public int Id { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public int UserStory { get; set; }
        public int Task { get; set; }

        [MaxLength(255)]
        public string? Description { get; set; }

        public TimeSpan Duration => EndTime - StartTime;
        public int Week => ISOWeek.GetWeekOfYear(RegistrationDate.ToDateTime(new TimeOnly(0, 0, 0)));
    }
}