namespace TaskList.Repositories.Entities
{
    public class DbTask
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string TimeToComplete { get; set; }

        public bool IsCompleted { get; set; }
    }
}
