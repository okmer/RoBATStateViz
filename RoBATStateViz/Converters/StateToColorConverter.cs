using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace RoBATStateViz.Converters
{
    class StateToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var result = Colors.DarkGray;
            var enabled = Colors.LightBlue;
            var disabled = Colors.LightGray;

            if (value != null && targetType == typeof(Brush))
            {
                result = System.Convert.ToInt32(value) == System.Convert.ToInt32(parameter) ? enabled : disabled;
            }

            return new SolidColorBrush(result);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
