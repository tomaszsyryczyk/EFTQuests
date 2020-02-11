using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
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
