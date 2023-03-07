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

namespace isp_20_29
{
    /// <summary>
    /// Логика взаимодействия для Client2.xaml
    /// </summary>
    public partial class Client2 : UserControl
    {
        public string UserId = "";
        public Client2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new sql().InsDelUpd("DELETE FROM [Trade].[dbo].[User] where UserId =  " + UserId);
        }
    }
}
