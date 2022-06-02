using ClothStock_ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            clothStock.ItemsSource = ManagerModel.Stock;
        }

        private void DeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            List<Cloth> ProductsForDel = clothStock.SelectedItems.Cast<Cloth>().ToList();
            if (ProductsForDel.Count == 0)
            {
                MessageBox.Show("Выделите элементы для удаления!");
                return;
            }
            if (MessageBox.Show($"Вы действительно хотите удалить {ProductsForDel.Count} элементов?", "Отменить действие будет нельзя", MessageBoxButton.YesNoCancel,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                foreach (var prod in ProductsForDel)
                {
                    ManagerModel.Stock.Remove(prod);
                }
                clothStock.Items.Refresh();
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
