using ClothStock_ClassLibrary;
using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;


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

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder error = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentCloth.ClothName))
                error.Append("Укажите название ткани!");

            if (costPerMetre.Text.Contains("-"))
            {
                MessageBox.Show("Цена не может быть отрицательной");
                return;
            }
            if (error.Length > 0)
            {
                MessageBox.Show(error.ToString(), "Невозможно добавить ткань");
                return;
            }
            if (newProduct)
            {
                ManagerModel.Stock.Add(currentCloth);
                statusBar.Text = "Ткань " + currentCloth.ClothName.ToString() + " добавлена ";
            }
            else
            {
                statusBar.Text = "Ткань " + currentCloth.ClothName.ToString() + " изменена ";
                ManagerNavigation.MainFrame.Navigate(new ClothListPage());
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigation.MainFrame.Navigate(new ClothListPage());
        }
    }
}
