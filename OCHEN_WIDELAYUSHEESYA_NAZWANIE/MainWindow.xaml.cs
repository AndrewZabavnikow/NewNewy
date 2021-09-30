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

namespace OCHEN_WIDELAYUSHEESYA_NAZWANIE
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AndrwZapEntities AZ = new AndrwZapEntities();
            DeGas.ItemsSource = AZ.Люди.ToList();
        }

        private void Frst_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Scnd_Click()
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            AddWin win = new AddWin();
            win.Show();
        }
    }
}
