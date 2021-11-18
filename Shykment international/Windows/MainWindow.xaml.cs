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

namespace Shykment_international
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTableDepartures_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(new DeparturesTablePage());
        }

        private void btnTableArrivals_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Navigate(new ArrivalTablePage());
        }

        private void btnControlRoom_Click(object sender, RoutedEventArgs e)
        {
            Autorize autorize = new Autorize(this);
            Hide();
            autorize.ShowDialog();
            Show();
        }

        private void btnAdministratorRoom_Click(object sender, RoutedEventArgs e)
        {
            AdministratorAutorizeWindow autorize = new AdministratorAutorizeWindow(this);
            Hide();
            autorize.ShowDialog();
            Show();
        }
    }
}
