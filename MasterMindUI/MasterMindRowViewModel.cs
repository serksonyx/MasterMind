using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System.Threading.Tasks;
using MasterMindLogik;
using MasterMindUI;
using Microsoft.Practices.Prism.Mvvm;

namespace MasterMindUI
{
    public class MasterMindRowViewModel : BindableBase
    {
        public MasterMindRowViewModel()
        {
            ComboboxAuswahl = new ObservableCollection<int>();
            for (int i = 0; i <= 9; i++)
            {
                ComboboxAuswahl.Add(i);
            }
            IsButtonEnabled = true;
        }

        public ObservableCollection<int> ComboboxAuswahl { get; set; }

        public int InputValue0 { get; set; }

        public int InputValue1 { get; set; }

        public int InputValue2 { get; set; }

        public int InputValue3 { get; set; }

        public int[] FindeTreffer(int[] random)
        {
            int[] input = { InputValue0, InputValue1, InputValue2, InputValue3 };
            int[] treffer = Logik.SpielLogik(random, input);
            TrefferAuswertung(treffer);

            return treffer;
        }

        private int _treffer0;
        private int _treffer1;
        private int _treffer2;
        private int _treffer3;

        public int Treffer0
        {
            get { return _treffer0; }
            set { SetProperty(ref _treffer0, value); }
        }
        public int Treffer1
        {
            get { return _treffer1; }
            set { SetProperty(ref _treffer1, value); }
        }
        public int Treffer2
        {
            get { return _treffer2; }
            set { SetProperty(ref _treffer2, value); }
        }
        public int Treffer3
        {
            get { return _treffer3; }
            set { SetProperty(ref _treffer3, value); }
        }

        private bool _isButtonEnabled;
        private bool _rowFinished;

        public bool IsButtonEnabled
        {
            get { return _isButtonEnabled; }
            set { SetProperty(ref _isButtonEnabled, value); }
        }

        public bool RowFinished
        {
            get { return _rowFinished; }
            set { SetProperty(ref _rowFinished, value); }
        }

        public void TrefferAuswertung(int[] treffer)
        {
            Treffer0 = treffer[0];
            Treffer1 = treffer[1];
            Treffer2 = treffer[2];
            Treffer3 = treffer[3];
            IsButtonEnabled = false;
            RowFinished = true;
        }
    }
}
