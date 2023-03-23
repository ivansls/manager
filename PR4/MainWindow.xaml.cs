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

namespace PR4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> boxxes = new List<string> {"Еда", "Игры", "Развлечения", "Степуха" };
        public string type_cheng;
        
        public MainWindow()
        {
            InitializeComponent();
            date.Text = DateTime.Now.ToString();
            logica.log(this);
            boxtype.ItemsSource = boxxes;
        }

        private void add_new_type(object sender, RoutedEventArgs e)
        {
            windowtip tip = new windowtip();
            bool? t = tip.ShowDialog();
            boxtype.ItemsSource = "";
            if (tip.res == true)
            {
                string a = tip.new_type_win;
                boxxes.Add(a);
                
            }
            else if (tip.res == false)
            {
                MessageBox.Show("Вы закрыли окно неправильно!");
            }
            boxtype.ItemsSource = boxxes;
        }

        private void add(object sender, RoutedEventArgs e)
        {

            logica.add(this);
        }

        private void edit(object sender, RoutedEventArgs e)
        {
            logica.edit(this);
        }

        private void del(object sender, RoutedEventArgs e)
        {
            logica.remove(this);
        }

        private void close_date(object sender, RoutedEventArgs e)
        {
            
            logica.log(this);
        }

        private void boxtype_ch(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                type_cheng = boxxes[boxtype.SelectedIndex];
            }
            catch {
                boxtype.SelectedItem = "";
            }
        }

        private void data_sel_ch(object sender, SelectionChangedEventArgs e)
        {
            /*type tpe = dategrid.SelectedItem as type;
            try
            {
                textrec.Text = tpe.name;
                boxtype.Text = tpe.tipe;
                textsum.Text = tpe.Money.ToString();
            }
            catch 
            {
                textrec.Text = "";
                boxtype.Text = "";
                textsum.Text = "";
            }*/

        }
    }
}
