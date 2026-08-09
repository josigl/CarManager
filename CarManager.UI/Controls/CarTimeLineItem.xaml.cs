using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CarManager.UI.Controls
{
    public partial class CarTimeLineItem : UserControl
    {
        public CarTimeLineItem()
        {
            InitializeComponent();
        }

        // Value
        public static readonly DependencyProperty ValueProperty =
            DependencyProperty.Register(
                nameof(Value),
                typeof(string),
                typeof(CarTimeLineItem),
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
                typeof(CarTimeLineItem),
                new PropertyMetadata(string.Empty));

        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }
        
        // Info Text
        public static readonly DependencyProperty InfoTextProperty =
            DependencyProperty.Register(
                nameof(InfoText),
                typeof(string),
                typeof(CarTimeLineItem),
                new PropertyMetadata(string.Empty));

        public string InfoText
        {
            get => (string)GetValue(InfoTextProperty);
            set => SetValue(InfoTextProperty, value);
        }

        // Time Line Check Icon
        public static readonly DependencyProperty CheckIconProperty =
            DependencyProperty.Register(
                nameof(CheckIcon),
                typeof(Geometry),
                typeof(CarTimeLineItem),
                new PropertyMetadata(null));

        public Geometry CheckIcon
        {
            get => (Geometry)GetValue(CheckIconProperty);
            set => SetValue(CheckIconProperty, value);
        }



    }
}
