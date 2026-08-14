using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarManager.WPF.Controls
{
    public partial class CarSummaryItem : UserControl
    {
        public CarSummaryItem()
        {
            InitializeComponent();
        }

        // Icon
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(
                nameof(Icon),
                typeof(Geometry),
                typeof(CarSummaryItem),
                new PropertyMetadata(null));

        public Geometry Icon
        {
            get => (Geometry)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        // Icon Size
        public static readonly DependencyProperty IconSizeProperty =
            DependencyProperty.Register(
                nameof(IconSize),
                typeof(double),
                typeof(CarSummaryItem),
                new PropertyMetadata(30.0));

        public double IconSize
        {
            get => (double)GetValue(IconSizeProperty);
            set => SetValue(IconSizeProperty, value);
        }

        // Value
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(CarSummaryItem),
                new PropertyMetadata(string.Empty));

        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        // Label
        public static readonly DependencyProperty LabelProperty =
            DependencyProperty.Register(
                nameof(Label),
                typeof(string),
                typeof(CarSummaryItem),
                new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }
    }
}
