using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    [Table("Objective")]
    public class Objective : Entity
    {
        public string Description { get; set; } 

        public ObjectiveType Type { get; set; }

        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }

        public int QuestId { get; set; }

        public int? LocationId { get; set; }
        [ForeignKey("LocationId")]
        public Location Location { get; set; }

        public int? ItemId { get; set; }
        [ForeignKey("ItemId")]
        public Item Item { get; set; }

        public int? UsingItemId { get; set; }
        [ForeignKey("UsingItemId")]
        public Item UsingItem { get; set; }

        public int Count { get; set; }

        public int CountDone { get; set; }

        public bool Done { get; set; }

        public bool Optional { get; set; }
    }

    public enum ObjectiveType
    {
        Other = 0,
        Handover = 1,
        Find=2,
        FindInRaid=3,
        Elimination=4,
        Discover=5,
        Skill=6,
        Exit=7,
        Mark=8,
        Deliver=9,
        Kill=10
        
    }
}
