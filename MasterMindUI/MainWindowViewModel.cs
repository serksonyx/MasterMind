using System.Collections.ObjectModel;
using System.Windows.Input;
using MasterMindLogik;
using MasterMindUI;
using System.Windows;
using Microsoft.Practices.Prism.Mvvm;


namespace MasterMindUI
{
    public class MainWindowViewModel : BindableBase
    {
        private int[] _random;
        
        public MainWindowViewModel()
        {
            _random = Logik.RandomArray();
            SetCommand = new CommandHandler<MasterMindRowViewModel>(CommandExecute, true);
            MasterMindRows = new ObservableCollection<MasterMindRowViewModel>
            {
                new MasterMindRowViewModel {}
            };
        }

        public ObservableCollection<MasterMindRowViewModel> MasterMindRows { get; set; }

        public ICommand SetCommand { get; set; }

        private string _win;

        public string Win
        {
            get { return _win; }
            set { SetProperty(ref _win, value); }
        }

        private void CommandExecute(MasterMindRowViewModel row)
        {            
            var treffer = row.FindeTreffer(_random);
            bool isWon = Logik.Won(treffer);
             
            if(isWon)
            {
                Win = "You Win!";
                return ;
            }
            else if (MasterMindRows.Count == 10)
            {
                MasterMindRows.Add(new MasterMindRowViewModel {});
                Win = "You Loose!";
                return;
            }
            
            MasterMindRows.Add(new MasterMindRowViewModel { });
        }
    }
}
