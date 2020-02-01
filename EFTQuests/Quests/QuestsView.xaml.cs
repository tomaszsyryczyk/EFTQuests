using System.Windows.Controls;

namespace EFTQuests.Quests
{
    /// <summary>
    /// Interaction logic for QuestsView.xaml
    /// </summary>
    public partial class QuestsView : UserControl
    {
        public QuestsView()
        {
            InitializeComponent();
        }

        private void DataGrid_OnLoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = (e.Row.GetIndex()).ToString();
        }
    }
}
