namespace EFT_Hud.DAL.Entities.SeedData
{
    class ItemsSeedData
    {
        internal class Ids
        {
            internal static int Roubles = 15;
            internal static int Euro = 16;
            internal static int Dollars = 17;
            internal static int Marker = 28;
        }

        public static readonly Item[] Items = {
            new Item  { Id = 1, Name = "Old firesteel"},
            new Item  { Id = 2, Name = "Antique axe"},
            new Item  { Id = 3, Name = "Battered antique Book"},
            new Item  { Id = 4, Name = "FireKlean gun lube"},
            new Item  { Id = 5, Name = "Golden rooster"},
            new Item  { Id = 6, Name = "Silver Badge"},
            new Item  { Id = 7, Name = "Deadlyslob's beard oil"},
            new Item  { Id = 8, Name = "Golden 1GPhone"},
            new Item  { Id = 9, Name = "Jar of DevilDog mayo"},
            new Item  { Id = 10, Name = "Can of sprats"},
            new Item  { Id = 11, Name = "Fake mustache"},
            new Item  { Id = 12, Name = "Kotton beanie"},
            new Item  { Id = 13, Name = "Secure container Kappa"},
            new Item  { Id = 14, Name = "MP-133 pump-action shotguns"},
            new Item  { Id = Ids.Roubles, Name = "Roubles"},
            new Item  { Id = Ids.Euro, Name = "Euro"},
            new Item  { Id = Ids.Dollars, Name = "Dollars"},
            new Item  { Id = 18, Name = "PM 9x18PM pistol"},
            new Item  { Id = 19, Name = "90-93 9x18PM Magazine, for 8 PM rounds"},
            new Item  { Id = 20, Name = "bronze pocket watch"},
            new Item  { Id = 21, Name = "TT pistol 7.62x25 TT"},
            new Item  { Id = 22, Name = "TT-105 7.62x25 TT Magazine"},
            new Item  { Id = 23, Name = "Kalashnikov AKS-74U 5.45x39"},
            new Item  { Id = 24, Name = "6L20 30-round 5.45x39 magazine for AK-74 and compatible weapons"},
            new Item  { Id = 25, Name = "Saiga 12ga ver. 10 12/76 shotgun"},
            new Item  { Id = 26, Name = "Sb.5 5-round 12/76 magazine for SOK-12 and compatible weapons"},
            new Item  { Id = 27, Name = "RGD-5 hand grenade"},
            new Item  { Id = Ids.Marker, Name = "Marker 2000"},



        };
    }
}
