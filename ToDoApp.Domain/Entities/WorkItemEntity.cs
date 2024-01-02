using ToDoApp.Domain.Enums;

namespace ToDoApp.Domain.Entities
{
    public class WorkItemEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public WorkItemState State { get; set; }
    }
}