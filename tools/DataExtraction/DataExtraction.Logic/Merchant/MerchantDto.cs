namespace DataExtraction.Logic.Merchant
{
    public class MerchantDto
    {
        public string Src { get; set; }
        public string Name { get; set; }
        public object[] Quests { get; set; }

        public MerchantDto(string name, string src)
        {
            Name = name;
            Src = src;
        }
    }
}
