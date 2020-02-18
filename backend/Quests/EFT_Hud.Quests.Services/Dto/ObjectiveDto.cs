using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Quests.Services.Dto
{
    public class ObjectiveDto
    {
        public string Description { get; set; }

        public ObjectiveType Type { get; set; }

        public int QuestId { get; set; }

        public LocationDto Location { get; set; }

        public ItemDto Item { get; set; }

        public int Count { get; set; }

        public int CountDone { get; set; }
    }
}
