using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarManager.WPF.Controls
{
    public class CarTabItem : TabItem
    {
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(Geometry),
                typeof(CarTabItem),
                new PropertyMetadata(null));

        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register(
                nameof(IconSize),
                typeof(double),
                typeof(CarTabItem),
                new PropertyMetadata(20.0));

        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }
    }
}
