using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = textImie.Text;
            string sobie = oSobie.Text;
            StreamWriter sw = File.AppendText(path: "zapplik.txt");
            sw.WriteLine(name);
            if (man.IsChecked == true)
            {
                sw.WriteLine("Mężczyzna");
            }
            else if(woman.IsChecked == true)
            {
                sw.WriteLine("Kobieta");
            }
            else
            {
                sw.WriteLine("Nie wybrano płci");
            }
            if(muzyka.IsChecked == true)
            {
                sw.WriteLine("Muzyka");
            }
            if (sport.IsChecked == true)
            {
                sw.WriteLine("Sport");
            }
            if (gry.IsChecked == true)
            {
                sw.WriteLine("Gry komputerowe");
            }
            sw.WriteLine(sobie);
            sw.Close();
        }
    }
}
