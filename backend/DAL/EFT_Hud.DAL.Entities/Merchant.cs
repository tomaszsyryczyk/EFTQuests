using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    [Table("Merchant")]
    public class Merchant : Entity
    {
        public string Name { get; set; }

        public string IconName { get; set; }

        public ICollection<Quest> Quests { get; set; }
    }
}
