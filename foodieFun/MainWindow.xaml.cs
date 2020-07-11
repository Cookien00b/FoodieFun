using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime;
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

namespace foodieFun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : System.Windows.Window
    {
        List<ingredient> recipe = new List<ingredient>();
        public MainWindow()
        {
            
            InitializeComponent();
            ingredientsList.ItemsSource = recipe;

        }

        public class ingredient
        {
            public string Name { get; set; }
            public prepMethods methods = new prepMethods() { method =  "", timeMult = 1m };
        }

        public static class Container
        {
            public static List<ingredient> ingredients = new List<ingredient>();
        }

        

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            //Set's the location of the window
            Menu popup = new Menu();
            int x = Convert.ToInt32(Left) + 40;
            int y = Convert.ToInt32(Top) + 20;
            popup.Left = x;
            popup.Top = y;
            popup.ShowDialog();
            recipe.Clear();
            recipe = popup.temp;
            ICollectionView view = CollectionViewSource.GetDefaultView(recipe);
            view.Refresh();
        }

        public void AddIngredient(object sender, RoutedEventArgs e)
        {
            ingredientsList.Items.Add("test");
        }

















    }
}
