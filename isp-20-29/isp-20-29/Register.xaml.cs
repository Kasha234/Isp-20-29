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

namespace isp_20_29
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (FirstName.Text.Length > 3
                && LastName.Text.Length > 3
                && Patronymic.Text.Length > 3
                && Login.Text.Length > 3
                && Password.Text.Length > 3
                && PasswordRepeat.Text == PasswordRepeat.Text)
            {
                string command = $@"INSERT INTO [dbo].[User]
([UserSurname]
,[UserName]
,[UserPatronymic]
,[UserLogin]
,[UserPassword]
,[UserRole])
VALUES
('{LastName.Text}'
,'{FirstName.Text}'
,'{Patronymic.Text}'
,'{Login.Text}'
,'{Password.Text}'
,3)";
                new sql().InsDelUpd(command);
            }
            else
            {
                MessageBox.Show("Ошибка проверьте данные!");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
        
    
        
