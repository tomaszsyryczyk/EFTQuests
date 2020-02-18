namespace EFT_Hud.DAL.Entities.SeedData
{
    class LocationsSeedData
    {
        internal class Ids
        {
            public static int Shoreline = 1;
            public static int Woods = 2;
            public static int Interchange = 3;
            public static int Customs = 4;
            public static int Factory = 5;
            public static int Reserve = 6;
            public static int The_Lab = 7;
        }

        public static readonly Location[] Locations = {
            new Location  { Id = Ids.Shoreline, Name = "Shoreline"},
            new Location  { Id = Ids.Woods, Name = "Woods" },
            new Location { Id = Ids.Interchange, Name = "Interchange" },
            new Location { Id = Ids.Customs, Name = "Customs" },
            new Location { Id = Ids.Factory, Name = "Factory" },
            new Location { Id = Ids.Reserve, Name = "Reserve" },
            new Location { Id = Ids.The_Lab, Name = "The Lab" }
        };
    }
}
