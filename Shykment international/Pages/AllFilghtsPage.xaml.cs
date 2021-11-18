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
    /// Логика взаимодействия для AllFilghtsPage.xaml
    /// </summary>
    public partial class AllFilghtsPage : Page
    {
        Shykment_internationalEntities db = new Shykment_internationalEntities();

        public AllFilghtsPage()
        {
            InitializeComponent();
            datagridAllFlights.ItemsSource = db.Departures.ToList();
        }

        private void saveChanges_Click(object sender, RoutedEventArgs e)
        {
            db.SaveChanges();
        }
    }
}
