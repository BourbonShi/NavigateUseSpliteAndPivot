using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Demo.Model
{
    public class NavItem
    {
        public enum NavType
        {
            one,
            two,
            three,
        }
        public string Label { get; set; }
        public Symbol Symbol { get; set; }
        public char SymbolAsChar
        {
            get
            {
                return (char)this.Symbol;
            }
        }
        public NavType DestPage { get; set; }
        public object Arguments { get; set; }
    }
}
