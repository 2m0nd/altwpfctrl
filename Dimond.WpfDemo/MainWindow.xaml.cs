using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Dimond.WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

	    public static readonly DependencyProperty IsEnabledControlProperty =
		    DependencyProperty.Register("IsEnabledControl", typeof (bool), typeof (MainWindow), new PropertyMetadata(default(bool)));

	    public bool IsEnabledControl
	    {
		    get { return (bool) GetValue(IsEnabledControlProperty); }
		    set { SetValue(IsEnabledControlProperty, value); }
	    }
    }
}
