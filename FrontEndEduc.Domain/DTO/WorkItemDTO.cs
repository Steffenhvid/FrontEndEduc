using FrontEndEduc.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEndEduc.Domain.DTO
{
    public class WorkItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public WorkItemState State { get; set; }
    }
}