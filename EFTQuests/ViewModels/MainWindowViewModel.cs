using System.Collections.Generic;
using EFTQuests.Models;

namespace EFTQuests.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel()
        {
            GetUserSheets();
        }

        public IList<Sheet> UserSheets { get; set; }

        private void GetUserSheets()
        {
            UserSheets = new List<Sheet>()
            {
                new Sheet()
                {
                    Name = "Test 1",
                    Path = "Path to test 1"
                },
                new Sheet()
                {
                    Name = "Test 2",
                    Path = "path to test 2222"
                }
            };
        }
    }
}
