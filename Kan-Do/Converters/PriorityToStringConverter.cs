using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Kan_Do.WPF.Converters
{
    internal class PriorityToStringConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case 0:
                    return "NO PRIORITY";
                    break;
                case 1:
                    return "LOW";
                    break;
                case 2:
                    return "MEDIUM";
                    break;
                case 3:
                    return "HIGH";
                    break;
                default:
                    break;

            }
            return "NO PRIORITY";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
