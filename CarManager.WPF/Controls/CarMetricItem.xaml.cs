using System.Windows;
using System.Windows.Controls;

namespace CarManager.WPF.Controls
{
    public partial class CarMetricItem : UserControl
    {
        public CarMetricItem()
        {
            InitializeComponent();
        }

        // Label
        public static readonly DependencyProperty LabelProperty =
           DependencyProperty.Register(
          nameof(Label),
          typeof(string),
          typeof(CarMetricItem),
          new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }

        // Value
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(CarMetricItem),
                new PropertyMetadata(string.Empty));


        public string Value
        {
            get => (string)GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
