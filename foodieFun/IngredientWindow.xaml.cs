using Bogus.DataSets;
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

namespace foodieFun
{
    /// <summary>
    /// Interaction logic for IngredientWindow.xaml
    /// </summary>
    
    
    public partial class IngredientWindow : System.Windows.Window
    {

        public List<MainWindow.ingredient> temp = new List<MainWindow.ingredient>();
        public IngredientWindow()
        {
            InitializeComponent();
            List<string> prepMethods 
            
        }

        public void Add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Container.ingredients.Add(new MainWindow.ingredient() { Name = IngredientTxt.Text, prepMethod = preppingCmb.ToString() });
            temp = MainWindow.Container.ingredients;
            this.Close();
        }

        

        


        

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        
    }
}
