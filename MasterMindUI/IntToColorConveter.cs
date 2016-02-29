using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MasterMindUI;


namespace MasterMindUI
{
    public class IntToColorConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //BrushConverter bc = new BrushConverter();
            //Brush brush = (Brush)bc.ConvertFrom("#C7DFFC");

            var color = Brushes.Gray;
            int? x = value as int?;
            switch (x)
            {
                case 0:
                    color = Brushes.DarkRed;  
                    break;                
                case 1:
                    color = Brushes.Gainsboro ;
                    break;
                case 2:
                    color = Brushes.IndianRed;
                    break;
                case 3:
                    color = Brushes.Teal;
                    break;
                case 4:
                    color = Brushes.DarkGoldenrod;
                    break;
                case 5:
                    color = Brushes.Black;
                    break;
                case 6:
                    color = Brushes.Indigo;
                    break;
                case 7:
                    color = Brushes.MediumBlue;
                    break;
                case 8:
                    color = Brushes.DarkOrange;
                    break;
                case 9:
                    color = Brushes.OliveDrab;
                    break;

            }
            return color;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
