namespace ToDoApp.Domain.Enums
{
    public enum WorkItemState
    {
        /// <summary>
        /// IS used as the Tasks Null value, should never happen
        /// </summary>
        None,

        /// <summary>
        /// Work is not started
        /// </summary>
        ToDo,

        /// <summary>
        /// Work is started/in process
        /// </summary>
        Doing,

        /// <summary>
        /// Work is done
        /// </summary>
        Done
    }
}