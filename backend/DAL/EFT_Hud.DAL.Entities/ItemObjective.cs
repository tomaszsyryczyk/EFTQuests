using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    [Table("ItemObjective")]
    public class ItemObjective : Entity
    {
        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }

        [Column("Quest_Id")]
        public int QuestId { get; set; }

        public int Count { get; set; }

        public bool FindInRaid { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        [Column("Item_Id")]
        public int ItemId { get; set; }
    }
}
