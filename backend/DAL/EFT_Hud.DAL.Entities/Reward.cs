﻿using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    [Table("Reward")]
    public class Reward : Entity
    {
        public RewardType Type { get; set; }

        public string Description { get; set; }

        public int Count { get; set; }

        [ForeignKey("QuestId")]
        public Quest Quest { get; set; }

        [Column("Quest_Id")]
        public int QuestId { get; set; }
    }

    public enum RewardType
    {

    }
}
