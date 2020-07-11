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
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : System.Windows.Window
    {
        public List<MainWindow.ingredient> temp = new List<MainWindow.ingredient>();
        public Menu()
        {
            InitializeComponent();
        }

    

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IngredientWindow popup = new IngredientWindow();
            int x = Convert.ToInt32(Left) + 40;
            int y = Convert.ToInt32(Top) + 20;
            popup.Left = x;
            popup.Top = y;
            popup.ShowDialog();
            foreach (var item in popup.temp)
            {
                temp.Add(item.ToString());
            }
            this.Close();
        }
    }
}
