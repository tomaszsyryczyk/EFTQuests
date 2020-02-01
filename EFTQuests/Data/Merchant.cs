using System.ComponentModel.DataAnnotations.Schema;

namespace EFTQuests.Data
{
    [Table("Merchant")]
    public class Merchant : Entity
    {
        public string Name { get; set; }

        public string IconName { get; set; }
    }
}
