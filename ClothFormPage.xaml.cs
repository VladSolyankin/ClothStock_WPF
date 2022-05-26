using ClothStock_ClassLibrary;
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

namespace ClothStock_WPF
{
    /// <summary>
    /// Interaction logic for ClothFormPage.xaml
    /// </summary>
    public partial class ClothFormPage : Page
    {
        Cloth currentCloth;
        bool newProduct;
        public ClothFormPage(Cloth cloth)
        {
            InitializeComponent();
            if (cloth == null)
            {
                currentCloth = new Cloth();
                newProduct = true;
            }
            else
            {
                currentCloth = cloth;
                newProduct = false;
            }
            DataContext = currentCloth;
        }
    }
}
