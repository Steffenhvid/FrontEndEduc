using ToDoApp.Domain.Enums;

namespace ToDoApp.Domain.DTO
{
    public class WorkItemDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public WorkItemState State { get; set; }
    }
}