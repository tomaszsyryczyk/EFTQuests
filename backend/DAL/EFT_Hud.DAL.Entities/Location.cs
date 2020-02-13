using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    public class Location : Entity
    {
        public string Name { get; set; }

        [ForeignKey("QuestId")]
        public ICollection<LocationToQuest> Quests { get; set; }
    }
}
