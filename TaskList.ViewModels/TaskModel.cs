namespace TaskList.ViewModels
{
    public class TaskModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Priority { get; set; }

        public string TimeToComplete { get; set; }

        public bool IsCompleted { get; set; }
    }
}