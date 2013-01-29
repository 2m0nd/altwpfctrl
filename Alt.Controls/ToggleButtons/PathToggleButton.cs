using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Alt.Controls.ToggleButtons
{
    public class PathToggleButton : ToggleButton
    {
        public PathToggleButton()
        {
            this.Checked += OnChecked;
            this.Unchecked += OnUnchecked;

            if (IsChecked.Value)
                CurrentFillColor = CheckedColor;
            else
                CurrentFillColor = UncheckedColor;
        }

        private void OnUnchecked(object sender, RoutedEventArgs routedEventArgs)
        {
            CurrentFillColor = UncheckedColor;
        }

        private void OnChecked(object sender, RoutedEventArgs routedEventArgs)
        {
            CurrentFillColor = CheckedColor;
        }


        public static readonly DependencyProperty CheckedColorProperty =
            DependencyProperty.Register("CheckedColor", typeof(Color), typeof(PathToggleButton), new PropertyMetadata(Colors.Green, CheckedColorChanged));

        private static void CheckedColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var instance = (PathToggleButton)dependencyObject;
            var newValue = (Color)dependencyPropertyChangedEventArgs.NewValue;
            if (instance.IsChecked.Value)
            {
                instance.CurrentFillColor = newValue;
            }
        }

        public Color CheckedColor
        {
            get { return (Color) GetValue(CheckedColorProperty); }
            set { SetValue(CheckedColorProperty, value); }
        }

        public static readonly DependencyProperty UncheckedColorProperty =
            DependencyProperty.Register("UncheckedColor", typeof(Color), typeof(PathToggleButton), new PropertyMetadata(Color.FromRgb(255, 155, 155, 155), UncheckedColorChanged));

        private static void UncheckedColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var instance = (PathToggleButton)dependencyObject;
            var newValue = (Color) dependencyPropertyChangedEventArgs.NewValue;
            if (!instance.IsChecked.Value)
            {
                instance.CurrentFillColor = newValue;
            }
        }

        public Color UncheckedColor
        {
            get { return (Color) GetValue(UncheckedColorProperty); }
            set { SetValue(UncheckedColorProperty, value); }
        }

        public static readonly DependencyProperty CurrentFillColorProperty =
            DependencyProperty.Register("CurrentFillColor", typeof (Color), typeof (PathToggleButton), new PropertyMetadata(default(Color)));

        public Color CurrentFillColor
        {
            get { return (Color) GetValue(CurrentFillColorProperty); }
            set { SetValue(CurrentFillColorProperty, value); }
        }

        public static readonly DependencyProperty PathGeometryProperty =
            DependencyProperty.Register("PathGeometry", typeof(PathGeometry), typeof(PathToggleButton), new PropertyMetadata(default(PathGeometry)));

        public PathGeometry PathGeometry
        {
            get { return (PathGeometry)GetValue(PathGeometryProperty); }
            set { SetValue(PathGeometryProperty, value); }
        }

        
    }
}
