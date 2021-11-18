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
    /// Логика взаимодействия для Autorize.xaml
    /// </summary>
    public partial class Autorize : Window
    {
        Shykment_internationalEntities db = new Shykment_internationalEntities();
        MainWindow window;

        public Autorize(MainWindow window)
        {
            InitializeComponent();
            this.window = window;
        }

        private void btnTryToLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Text.Length > 0)
            {
                if (db.Dispatcher.Any(x => x.Password == txtPassword.Text))
                {
                    window.frameMain.Navigate(new AllFilghtsPage());
                    Hide();
                }
                else
                    MessageBox.Show("Неверный пароль!");
            }
            else
                MessageBox.Show("Заполните поле пароля!");
        }
    }
}
