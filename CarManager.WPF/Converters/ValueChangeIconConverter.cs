using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace CarManager.WPF.Converters
{
    public sealed class ValueChangeIconConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value is not decimal percent)
                return DependencyProperty.UnsetValue;

            return percent >= 0
                ? Application.Current.FindResource("Icon.ArrowUp")
                : Application.Current.FindResource("Icon.ArrowDown");
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
            => throw new NotSupportedException();
    }
}
