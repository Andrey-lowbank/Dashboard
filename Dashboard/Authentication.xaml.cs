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

namespace Dashboard
{
    /// <summary>
    /// Логика взаимодействия для Authentication.xaml
    /// </summary>
    public partial class Authentication : Window
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Button_Auth_Click_1(object sender, RoutedEventArgs e)
        {
            String login = loginreg.Text;
            String pass = passreg.Password.Trim();


            if (login.Length < 4)
            {
                loginreg.ToolTip = "Логин слишком короткий";
                loginreg.Background = Brushes.Red;
            }
            else if (pass.Length < 4)
            {
                passreg.ToolTip = " Пароль слишком короткий";
                passreg.Background = Brushes.Red;
            } else {
                loginreg.ToolTip = "";
                loginreg.Background = Brushes.Transparent;
                passreg.ToolTip = "";
                passreg.Background = Brushes.Transparent;

                User authUser = null;
                using (ApplicationContext db = new ApplicationContext()) {
                    authUser = db.Users.Where(b => b.Login == login && b.Pass == pass).FirstOrDefault();
                }

                if (authUser != null)
                {
                    MainWindow dashboard = new MainWindow();
                    dashboard.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("Данные неверны!");
            }
        }

        private void Button_Reg_Click_1(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();

        }
    }
}
 