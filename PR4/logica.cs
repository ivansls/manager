using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PR4
{
    internal class logica
    {
        static List<type> typed = desir.MyDesirialize<List<type>>();
        static List<type> dop_type = new List<type>();
        public static void log(MainWindow window)
        {
            window.dategrid.ItemsSource = "";
            if (File.Exists(desir.desktop + "\\manager.json"))
            {
                dop_type.Clear();
            }
            else
            {
                File.WriteAllText(desir.desktop + "\\manager.json", "[]");
            }
            int count = 0;
            foreach (var type in typed) 
            {
                if (type.date == window.date.Text.ToString())
                {
                    dop_type.Add(type);
                }


                
                 count += type.Money;
                
                


            }
            window.dategrid.ItemsSource = dop_type;
           
            window.all_sum.Text = "Итого: " + count.ToString();

        }

        public static void add(MainWindow window)
        {
            string r = window.textrec.Text;
            int q = Convert.ToInt32(window.textsum.Text);
            string t = window.type_cheng;
            /*type tu = new type(r, t, q, true, window.date.Text.ToString());*/
            typed.Add(new type(r, t, q, true, window.date.Text.ToString()));
            desir.MySerialeze(typed);
            typed = desir.MyDesirialize<List<type>>();
            log(window);
        }

        public static void remove(MainWindow window)
        {
            type select = window.dategrid.SelectedItem as type;
            try
            {
                foreach (var tye in typed)
                {
                    if (tye == select)
                    {
                        typed.Remove(tye);
                    }
                }
            }
            catch { }
            finally
            { 
            desir.MySerialeze(typed);
            typed = desir.MyDesirialize<List<type>>();
            log(window);
            }
        }

        public static void edit(MainWindow window)
        {
            type select = window.dategrid.SelectedItem as type;
            try
            {
                foreach (var tye in typed)
                {
                    if (tye == select)
                    {
                        string r = window.textrec.Text;
                        int i = typed.IndexOf(tye);
                        int q = Convert.ToInt32(window.textsum.Text);
                        string t = window.type_cheng;
                        typed[i] = new type(r, t, q, true, window.date.Text.ToString());
                    }
                }
            }
            catch { }
            finally
            {
                desir.MySerialeze(typed);
                typed = desir.MyDesirialize<List<type>>();
                log(window);
            }
        }
    }
}
