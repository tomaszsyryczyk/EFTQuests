using EFT_Hud.DAL.Entities;

namespace EFT_Hud.Quests.Services.Dto
{
    public class ObjectiveDto
    {
        public int Id { get; set; }
        public string ObjectiveType { get; set; }
        public int Count { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public string Using { get; set; }
        public int CountDone { get; set; }
        public bool Done { get; set; }
        public bool Optional { get; set; }
    }
}
