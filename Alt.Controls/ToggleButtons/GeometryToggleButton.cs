using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace Alt.Controls.ToggleButtons
{
    public class GeometryToggleButton : ToggleButton
    {
        public GeometryToggleButton()
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
            DependencyProperty.Register("CheckedColor", typeof(Color), typeof(GeometryToggleButton), new PropertyMetadata(Colors.Green, CheckedColorChanged));

        private static void CheckedColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var instance = (GeometryToggleButton)dependencyObject;
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
            DependencyProperty.Register("UncheckedColor", typeof(Color), typeof(GeometryToggleButton), new PropertyMetadata(Color.FromArgb(255, 155, 155, 155), UncheckedColorChanged));

        private static void UncheckedColorChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs dependencyPropertyChangedEventArgs)
        {
            var instance = (GeometryToggleButton)dependencyObject;
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
            DependencyProperty.Register("CurrentFillColor", typeof (Color), typeof (GeometryToggleButton), new PropertyMetadata(default(Color)));

        public Color CurrentFillColor
        {
            get { return (Color) GetValue(CurrentFillColorProperty); }
            set { SetValue(CurrentFillColorProperty, value); }
        }

		public static readonly DependencyProperty CheckedGeometryProperty =
            DependencyProperty.Register("CheckedGeometry", typeof(Geometry), typeof(GeometryToggleButton), new PropertyMetadata(null, (
	            o, args) =>
	            {
					var instance = (GeometryToggleButton)o;
					var newValue = (Geometry)args.NewValue;
					if (newValue != null && instance.UnchekedGeometry == null)
					{
						instance.UnchekedGeometry = instance.CheckedGeometry;
					}
	            }));

		public Geometry CheckedGeometry
        {
			get { return (Geometry)GetValue(CheckedGeometryProperty); }
			set { SetValue(CheckedGeometryProperty, value); }
        }

	    public static readonly DependencyProperty UnchekedGeometryProperty =
		    DependencyProperty.Register("UnchekedGeometry", typeof (Geometry), typeof (GeometryToggleButton), new PropertyMetadata(null, (
			    o, args) =>
			    {
					var instance = (GeometryToggleButton)o;
					var newValue = (Geometry)args.NewValue;
					if (newValue == null && instance.CheckedGeometry != null)
					{
						instance.UnchekedGeometry = instance.CheckedGeometry;
					}
			    }));

	    public Geometry UnchekedGeometry
	    {
		    get { return (Geometry) GetValue(UnchekedGeometryProperty); }
		    set { SetValue(UnchekedGeometryProperty, value); }
	    }
        
    }
}
