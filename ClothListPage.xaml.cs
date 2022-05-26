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
    /// Interaction logic for ClothListPage.xaml
    /// </summary>
    public partial class ClothListPage : Page
    {
        public ClothListPage()
        {
            InitializeComponent();
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            List<Cloth> ProductsForDel = gridStock.SelectedItems.Cast<Cloth>().ToList();
            if (ProductsForDel.Count == 0)
            {
                MessageBox.Show("Выделите продукты для удаления");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите удалить {ProductsForDel.Count} товаров?", "Отменить действие будет нельзя", MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                foreach (var prod in ProductsForDel)
                {
                    ManagerModel.Stock.Remove(prod);
                }
                gridStock.Items.Refresh();
            }
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigation.MainFrame.Navigate(new ClothFormPage(null));
        }

        private void EditProduct_Click(object sender, RoutedEventArgs e)
        {
            Cloth selectProduct = (sender as Button).DataContext as Cloth;
            ManagerNavigation.MainFrame.Navigate(new ClothFormPage(selectProduct));
        }
    }
}
