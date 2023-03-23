using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PR4
{
    internal class type
    {
        public string name { get; set; }
        public string tipe { get; set; }

        public int money;
        public bool money_income { get; set; }

        public string date;

        public type(string name_, string type_, int money_, bool money_zp_, string date_)
        {
            name = name_;
            tipe = type_;
            Money = money_;
            money_income = money_zp_;
            date = date_;
        }

        public int Money
        {
            get { return money; }
            set
            {
                if (value > 0)
                {
                    money_income = true;
                    
                }
                else
                {
                    money_income = false;
                    
                }
                money = value;
            }
        }
    }
}
