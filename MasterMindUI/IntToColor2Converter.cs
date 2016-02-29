using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindUI
{
    public class IntToColor2Converter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color2 = Brushes.Gray;
            int? x = value as int?;
            switch (x)
            {
                case -1:
                    color2 = Brushes.Black;
                    break;
                case -2:
                    color2 = Brushes.White;
                    break;
            }
            return color2;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
