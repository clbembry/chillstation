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
using HEC.Macros;

namespace HEC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeBase: Window
    {
        public List<ToolbarItem> Items;

        public HomeBase()
        {
            InitializeComponent();
            Items = new List<ToolbarItem>();
        }

        public void SetToolBarItemsWithMapping(Dictionary<Buttons, Macro> macros)
        {
            Items = new List<ToolbarItem>();
            foreach (Buttons key in macros.Keys)
            {
                ToolbarItem item = new ToolbarItem();
            }
        }
    }
}
