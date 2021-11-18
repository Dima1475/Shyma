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
using System.Windows.Shapes;

namespace Shykment_international
{
    /// <summary>
    /// Логика взаимодействия для AdministratorAutorizeWindow.xaml
    /// </summary>
    public partial class AdministratorAutorizeWindow : Window
    {
        MainWindow window;
        Shykment_internationalEntities db = new Shykment_internationalEntities();

        public AdministratorAutorizeWindow(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void btnTryToLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                if (db.Administators.Any(x => x.Password == txtPassword.Text))
                {

                }
            }
            else
                MessageBox.Show("Введите пароль!");
        }
    }
}
