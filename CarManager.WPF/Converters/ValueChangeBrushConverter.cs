using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Data;

namespace CarManager.WPF.Converters
{
    public sealed class ValueChangeBrushConverter : IValueConverter
    {
        public object Convert(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
        {
            if (value is not decimal change)
                return DependencyProperty.UnsetValue;

            return change switch
            {
                > 0 => Application.Current.FindResource("Brush.Value.Positive"),
                < 0 => Application.Current.FindResource("Brush.Value.Negative"),
                _ => Application.Current.FindResource("Brush.Text.Secondary")
            };
        }

        public object ConvertBack(
            object value,
            Type targetType,
            object parameter,
            CultureInfo culture)
            => throw new NotSupportedException();
    }
}
