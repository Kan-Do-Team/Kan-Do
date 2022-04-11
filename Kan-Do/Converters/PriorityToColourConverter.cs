using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Kan_Do.WPF.Converters
{
    public class PriorityToColourConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case 0:
                    return "#C4C4C4";
                    break;
                case 1:
                    return "#1A9988";
                    break;
                case 2:
                    return "#C4C4C4";
                    break;
                case 3:
                    return "#EB5600";
                    break;
                default:
                    break;
            
            }
            return "#C4C4C4";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
