using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Entities
{
    public class Task
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string TimeToComplete { get; set; }

        public bool IsCompleted { get; set; }
    }
}
