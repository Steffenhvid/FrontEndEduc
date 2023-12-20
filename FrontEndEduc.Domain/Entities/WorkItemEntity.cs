using FrontEndEduc.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Domain.Entities
{
    public class WorkItemEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public WorkItemState State { get; set; }
    }
}