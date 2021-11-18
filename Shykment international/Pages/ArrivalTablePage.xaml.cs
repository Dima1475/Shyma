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
    /// Логика взаимодействия для ArrivalTablePage.xaml
    /// </summary>
    public partial class ArrivalTablePage : Page
    {
        Shykment_internationalEntities db = new Shykment_internationalEntities();
        List<Arrivals> arrivalList = new List<Arrivals>();

        public ArrivalTablePage()
        {
            InitializeComponent();
            var listDeparture = db.Arrivals.ToList();
            for (int i = 0; i < listDeparture.Count(); i++)
            {
                double totalHours = (listDeparture[i].Arrival.Value - DateTime.Now).TotalHours;
                if (totalHours <= 1 && totalHours >= 0)
                {
                    arrivalList.Add(listDeparture[i]);
                }
            }
            datagridDepartures.ItemsSource = arrivalList;
        }
        

        private void btnShowTable_Click(object sender, RoutedEventArgs e)
        {
            datagridDepartures.Visibility = Visibility.Visible;
        }
    }
}
