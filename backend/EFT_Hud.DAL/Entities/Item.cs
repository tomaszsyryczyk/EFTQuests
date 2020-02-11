using System.ComponentModel.DataAnnotations.Schema;

namespace EFT_Hud.DAL.Entities
{
    [Table("Item")]
    public class Item : Entity
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string IconName { get; set; }
    }
}
