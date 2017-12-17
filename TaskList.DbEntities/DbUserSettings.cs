using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskList.DbEntities
{
    [Table("dbo.tbl_UserSettings")]
    public class DbUserSettings
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string DateTimeFormat { get; set; }
        
        public string Color { get; set; }
    }
}
