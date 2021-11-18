using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Логика взаимодействия для DeparturesTablePage.xaml
    /// </summary>
    public partial class DeparturesTablePage : Page
    {
        Shykment_internationalEntities db = new Shykment_internationalEntities();
        List<Departures> departuresList = new List<Departures>();

        public DeparturesTablePage()
        {
            InitializeComponent();
            var listDeparture = db.Departures.ToList();
            for (int i = 0; i < listDeparture.Count(); i++)
            {
                double totalHours = (listDeparture[i].Departure.Value - DateTime.Now).TotalHours;
                if (totalHours <= 3 && totalHours >= 0 && (listDeparture[i].Departure.Value.Year == DateTime.Now.Year || DateTime.Now.Year - listDeparture[i].Departure.Value.Year == 1))
                    departuresList.Add(listDeparture[i]);
                else if (listDeparture[i].Status == "ЗАДЕРЖКА")
                    departuresList.Add(listDeparture[i]);
            }
            datagridDepartures.ItemsSource = departuresList;
        }

        private void btnShowTable_Click(object sender, RoutedEventArgs e)
        {
            datagridDepartures.Visibility = Visibility.Visible;
        }
    }
}
