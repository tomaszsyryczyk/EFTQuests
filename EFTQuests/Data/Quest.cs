using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFTQuests.Data
{

    [Table("Quest")]
    public class Quest : Entity
    {
        public string Name { get; set; }

        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        [Column("Merchant_Id")]
        public int MerchantId { get; set; }
        public bool Done { get; set; }

        public ICollection<Objective> Objectives { get; set; }

        public ICollection<ItemObjective> ItemObjectives { get; set; }
    }
}
