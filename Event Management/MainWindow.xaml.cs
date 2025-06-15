using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Event_Management
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

        private void ShowOnly(UIElement visibleControl)
        {
            DashboardControl.Visibility = Visibility.Collapsed;
            EventDetailsControl.Visibility = Visibility.Collapsed;

            visibleControl.Visibility = Visibility.Visible;
        }

        private void dashboardButton_Click(object sender, RoutedEventArgs e)
        {
            ShowOnly(DashboardControl);
        }

        private void EventDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            ShowOnly(EventDetailsControl);
        }
    }
}