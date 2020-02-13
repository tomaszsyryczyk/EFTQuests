namespace EFT_Hud.DAL.Entities
{
    public class LocationToQuest
    {
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int QuestId { get; set; }
        public Quest Quest { get; set; }
    }
}
