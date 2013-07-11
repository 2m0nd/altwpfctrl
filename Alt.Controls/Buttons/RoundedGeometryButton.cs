using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Alt.Controls.ToggleButtons;

namespace Alt.Controls.Buttons
{
	public class RoundedGeometryButton : Button
	{
		public static readonly DependencyProperty GeometryInRoundProperty =
			DependencyProperty.Register("GeometryInRound", typeof(Geometry), typeof(RoundedGeometryButton), new PropertyMetadata(default(Geometry)));

		public Geometry GeometryInRound
		{
			get { return (Geometry)GetValue(GeometryInRoundProperty); }
			set { SetValue(GeometryInRoundProperty, value); }
		}
	}
}
