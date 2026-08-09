using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using CarManager.Core.Enums;

namespace CarManager.UI.Converters
{
    public class CarStatusToBrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not CarStatus status)
                return DependencyProperty.UnsetValue;

            bool background = parameter is string parameterValue && parameterValue.Equals("Background", StringComparison.OrdinalIgnoreCase);

            string resourceKey = background ? $"Brush.Status.{status}.Background" : $"Brush.Status.{status}";

            if (Application.Current.TryFindResource(resourceKey) is Brush brush)
                return brush;

            return background ? Brushes.Transparent : Brushes.Gray;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotSupportedException();
    }
}
