using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.DbEntities
{
    [Table("dbo.tbl_Task")]
    public class DbTask
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Priority { get; set; }

        public string TimeToComplete { get; set; }

        public bool IsCompleted { get; set; }
    }
}