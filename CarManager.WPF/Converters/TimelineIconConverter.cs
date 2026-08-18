using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace CarManager.WPF.Converters
{
    public class TimelineIconConverter : IValueConverter
    {
        public object Convert(
       object value,
       Type targetType,
       object parameter,
       CultureInfo culture)
        {
            if (value is not bool isCompleted)
                return DependencyProperty.UnsetValue;

            return isCompleted
                ? Application.Current.FindResource("Icon.Circle.Check")
                : Application.Current.FindResource("Icon.Circle");
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
            => throw new NotSupportedException();
    }
}
