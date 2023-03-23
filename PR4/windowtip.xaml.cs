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

namespace PR4
{
    /// <summary>
    /// Логика взаимодействия для windowtip.xaml
    /// </summary>
    public partial class windowtip : Window
    {
        public string new_type_win;
        public bool res = false;
        public windowtip()
        {
            InitializeComponent();
            
        }

        private void add_type_new(object sender, RoutedEventArgs e)
        {
            new_type_win = newtypetext.Text.ToString();
            res = true;
            Close();
        }
    }
}
