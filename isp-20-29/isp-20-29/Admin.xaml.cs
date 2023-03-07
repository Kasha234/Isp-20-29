using System;
using System.Collections.Generic;
using System.Configuration;
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
using System.Windows.Shapes;

namespace isp_20_29
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clients.Children.Clear();
            SqlDataReader reader = new sql().Select(@"SELECT
[UserId]
,[UserSurname]
,[UserName]
,[UserPatronymic]
FROM [Trade].[dbo].[User]
");
            while (reader.Read())
            {
                Client2 client2 = new Client2();
                client2.Fio.Content = reader[1].ToString();
                client2.DateofBirth.Content = reader[2].ToString();
                client2.City.Content = reader[3].ToString(); 
                client2.UserId = reader[0].ToString();
                Clients.Children.Add(client2);
            }
        }
    }
}
