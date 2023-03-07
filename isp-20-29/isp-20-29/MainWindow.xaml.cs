using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace isp_20_29
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SqlDataReader reader = new sql().Select($@"SELECT UserRole, UserName, UserSurname FROM [Trade].[dbo].[User]
                where UserLogin = '{Login.Text}' and UserPassword = '{Password.Password}' ");
            if(reader.HasRows)
            {
                while (reader.Read()) 
                {
                    MessageBox.Show("С возвращением \n" + reader[1].ToString() + "" + reader[2].ToString());
                  if (reader[0].ToString() == "1")
                    {
                        Admin admin = new Admin();  
                        admin.ShowDialog();
                    }
                  else if (reader[0].ToString() == "2")
                    {
                        Manager manager = new Manager();
                        manager.ShowDialog();
                    }
                  else if (reader[0].ToString() == "3")
                    {
                        User user = new User();
                        user.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
