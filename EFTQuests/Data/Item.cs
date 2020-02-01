using System.ComponentModel.DataAnnotations.Schema;
using System.Windows.Documents;

namespace EFTQuests.Data
{
    [Table("Item")]
    public class Item : Entity
    {
        public string Name { get; set; }

        public string ShortName { get; set; }

        public string IconName { get; set; }
    }
}
