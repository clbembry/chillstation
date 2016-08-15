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
using HEC.Models;
using System.Collections.ObjectModel;

namespace HEC
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class HomeBase: Window
    {
        public ObservableCollection<ToolbarAction> Items;

        public HomeBase()
        {
            InitializeComponent();
            Items = new ObservableCollection<ToolbarAction>();
        }

        public void SetToolBarItemsWithMapping(Dictionary<Buttons, Macro> macros)
        {
            Items = new ObservableCollection<ToolbarAction>();
            foreach (Buttons key in macros.Keys)
            {
                ToolbarAction action = new ToolbarAction(key, macros[key].Title);
                Items.Add(new ToolbarAction(key, macros[key].Title));
            }
            tStack.ItemsSource = Items;
        }
    }
}
