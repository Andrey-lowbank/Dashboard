using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        ApplicationContext db;

        public Registration()
        {
            InitializeComponent();

            db = new ApplicationContext();
        }


        private void Button_Gotovoreg_Click_1(object sender, RoutedEventArgs e)
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
            }
            else
            {
                loginreg.ToolTip = "";
                loginreg.Background = Brushes.Transparent;
                passreg.ToolTip = "";
                passreg.Background = Brushes.Transparent;

                MessageBox.Show("Вы зарегистрированы!");
                User user = new User(login, pass);

                db.Users.Add(user);
                db.SaveChanges();
            }
        }


        private void Button_Back_Click_1(object sender, RoutedEventArgs e)
        {
            Authentication authentication = new Authentication();
            authentication.Show();
            this.Hide();
        }
    }
}