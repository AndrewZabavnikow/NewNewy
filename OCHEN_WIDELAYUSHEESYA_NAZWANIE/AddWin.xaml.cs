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

namespace OCHEN_WIDELAYUSHEESYA_NAZWANIE
{
    /// <summary>
    /// Логика взаимодействия для AddWin.xaml
    /// </summary>
    public partial class AddWin : Window
    {
        public AddWin()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            ADDCLASS.DB.Люди.Add(new Люди 
            {
                Имя = One.Text,
                Фамилия = Two.Text,
            });
            ADDCLASS.DB.SaveChanges();
            MainWindow win = new MainWindow();
            win.Show();
            Close();
        }
    }
}
