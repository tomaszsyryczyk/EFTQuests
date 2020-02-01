using System.ComponentModel.DataAnnotations.Schema;

namespace EFTQuests.Data
{
    [Table("Objective")]
    public class Objective : Entity
    {
        public string Description { get; set; }

        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }

        [Column("Quest_Id")]
        public int QuestId { get; set; }

        

    }
}
