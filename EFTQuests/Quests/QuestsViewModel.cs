using System.Collections.Generic;
using System.Windows.Input;
using EFTQuests.Data;
using EFTQuests.Helper_Classes;
using EFTQuests.Services;

namespace EFTQuests.Quests
{
    public class QuestsViewModel : ObservableObject, IPageViewModel
    {
        private List<Merchant> _merchants;
        private ICommand _selectMerchant;
        private ICommand _checkQuest;
        public string Name => "Quests";

        public List<Merchant> Merchants
        {
            get
            {
                if (_merchants == null)
                    _merchants = MerchantService.GetMerchants();

                return _merchants;
            }
        }
        public ICommand CheckQuest
        {
            get
            {
                if (_checkQuest == null)
                {
                    _checkQuest = new RelayCommand(
                        p => SaveQuest((Quest)p),
                        p => p is Quest);
                }

                return _checkQuest;
            }
        }

        public ICommand SelectMerchant
        {
            get
            {
                if (_selectMerchant == null)
                {
                    _selectMerchant = new RelayCommand(
                        p => ChangeMerchant((Merchant)p),
                        p => p is Merchant);
                }

                return _selectMerchant;
            }
        }

        private Merchant _currentMerchant; 

        public Merchant CurrentMerchant
        {
            get => _currentMerchant;
            set
            {
                if (_currentMerchant != value)
                {
                    _currentMerchant = value;
                    ReloadQuests(value);
                    OnPropertyChanged("CurrentMerchant");
                }
            }
        }

        private void ReloadQuests(Merchant value)
        {
            Quests = QuestService.GetQuest(value);
        }

        private List<Quest> _quests;

        public List<Quest> Quests
        {
            get => _quests;
            set
            {
                if (_quests != value)
                {
                    _quests = value;
                    OnPropertyChanged("Quests");
                }
            }
        }
        

        private void SaveQuest(Quest newData)
        {
            newData.Done = !newData.Done;
            QuestService.Save(newData);
            ReloadQuests(CurrentMerchant);
        }

        private void ChangeMerchant(Merchant newCurrentMerchant)
        {
            CurrentMerchant = newCurrentMerchant;
        }
    }
}
