using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarManager.UI.Controls
{
    public partial class CarCommercialMetricItem : UserControl
    {
        public CarCommercialMetricItem()
        {
            InitializeComponent();
        }

        // Value
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(CarCommercialMetricItem),
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
                typeof(CarCommercialMetricItem),
                new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        // Card Background
        public static readonly DependencyProperty CardBackgroundProperty =
            DependencyProperty.Register(
            nameof(CardBackground),
            typeof(Brush),
            typeof(CarCommercialMetricItem),
            new PropertyMetadata(null));

        public Brush? CardBackground
        {
            get => (Brush?)GetValue(CardBackgroundProperty);
            set => SetValue(CardBackgroundProperty, value);
        }

        // Info Text
        public static readonly DependencyProperty InfoTextProperty =
            DependencyProperty.Register(
                nameof(InfoText),
                typeof(string),
                typeof(CarCommercialMetricItem),
                new PropertyMetadata(string.Empty));

        public string InfoText
        {
            get => (string)GetValue(InfoTextProperty);
            set => SetValue(InfoTextProperty, value);
        }

        // Info Icon
        public static readonly DependencyProperty InfoIconProperty =
            DependencyProperty.Register(
                nameof(InfoIcon),
                typeof(Geometry),
                typeof(CarCommercialMetricItem),
                new PropertyMetadata(null));

        public Geometry InfoIcon
        {
            get => (Geometry)GetValue(InfoIconProperty);
            set => SetValue(InfoIconProperty, value);
        }

        // Info Icon Size
        public static readonly DependencyProperty InfoIconSizeProperty =
            DependencyProperty.Register(
                nameof(InfoIconSize),
                typeof(double),
                typeof(CarCommercialMetricItem),
                new PropertyMetadata(20.0));

        public double InfoIconSize
        {
            get => (double)GetValue(InfoIconSizeProperty);
            set => SetValue(InfoIconSizeProperty, value);
        }

        // Info Foreground
        public static readonly DependencyProperty InfoForegroundProperty =
            DependencyProperty.Register(
            nameof(InfoForeground),
            typeof(Brush),
            typeof(CarCommercialMetricItem),
            new PropertyMetadata(null));

        public Brush? InfoForeground
        {
            get => (Brush?)GetValue(InfoForegroundProperty);
            set => SetValue(InfoForegroundProperty, value);
        }

    }
}
