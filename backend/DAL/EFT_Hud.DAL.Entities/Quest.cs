using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{

    [Table("Quest")]
    public class Quest : Entity
    {
        public string Name { get; set; }

        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public int MerchantId { get; set; }
        public ObjectiveStatus Status { get; set; }
        public ICollection<Objective> Objectives { get; set; }

        public ICollection<Reward> Rewards { get; set; }
    }

    public enum ObjectiveStatus
    {
        New,
        Active,
        Completed,
        Failed
    }
}
