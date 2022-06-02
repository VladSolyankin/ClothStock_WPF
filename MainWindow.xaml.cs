using ClothStock_ClassLibrary;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;

namespace ClothStock_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ManagerNavigation.MainFrame = mainFrame;
            ManagerNavigation.MainFrame.Navigate(new ClothListPage());
        }

        private void MainBorder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Maximize_Click(object sender, RoutedEventArgs e)
        {
            switch (this.WindowState)
            {
                case WindowState.Normal: this.WindowState = WindowState.Maximized; break;
                case WindowState.Maximized: this.WindowState = WindowState.Normal; break;
            }
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void AddCloth_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigation.MainFrame.Navigate(new ClothFormPage(null));
        }

        private void AllProducts_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigation.MainFrame.Navigate(new ClothListPage());
        }

        private void InfoPage_Click(object sender, RoutedEventArgs e)
        {
            ManagerNavigation.MainFrame.Navigate(new ClothInformationPage());
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog loadFile = new OpenFileDialog();
            loadFile.Filter = "Файл данных (*dat)|*.dat|Все файлы (*.*)|*.*";
            loadFile.InitialDirectory = Environment.CurrentDirectory;
            loadFile.DefaultExt = "dat";
            if (loadFile.ShowDialog() == true)
            {
                string path = loadFile.FileName;
                using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
                {
                    //foreach (var product in ManagerModel.Stock)
                    while (reader.PeekChar() > -1)
                    {
                        Cloth cloth = new Cloth();
                        cloth.ClothName = reader.ReadString();
                        cloth.Factory = (ProducingFactory)Enum.Parse(typeof(ProducingFactory), reader.ReadString());
                        cloth.ClothType = (Types)Enum.Parse(typeof(Types), reader.ReadString());
                        cloth.CostPerMetre = reader.ReadDouble();
                        cloth.CheckDate = DateTime.Parse(reader.ReadString());
                        cloth.MetresInStock = reader.ReadDouble();
                        cloth.Markup = (Markup)Enum.Parse(typeof(Markup), reader.ReadString());
                    }
                }
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Файл данных (*dat)|*.dat|Все файлы (*.*)|*.*";
            saveFile.InitialDirectory = Environment.CurrentDirectory;
            saveFile.DefaultExt = "dat";
            if (saveFile.ShowDialog() == true)
            {
                string path = saveFile.FileName;
                using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
                {
                    Encoding.UTF8.GetBytes(writer.ToString());
                    //foreach (var product in ManagerModel.Stock)
                    foreach (var cloth in ManagerModel.Stock)
                    {
                        writer.Write(cloth.ClothName);
                        writer.Write(cloth.Factory.ToString());
                        writer.Write(cloth.ClothType.ToString());
                        writer.Write(cloth.CostPerMetre);
                        writer.Write(cloth.CheckDate.ToString());
                        writer.Write(cloth.MetresInStock.ToString());
                        writer.Write(cloth.Markup.ToString());
                    }
                }
            }
        }
        private void SaveToXML_Click(object sender, RoutedEventArgs e)
        {
            XDocument xdoc = new XDocument();
            XElement stock = new XElement("stock");
            foreach (Cloth cloth in ManagerModel.Stock)
            {
                XElement cl = new XElement("cloth");
                XAttribute clothName = new XAttribute("clothName", cloth.ClothName);
                XAttribute factory = new XAttribute("factory", cloth.Factory.ToString());
                XAttribute clothType = new XAttribute("clothType", cloth.ClothType.ToString());
                XAttribute costPerMetre = new XAttribute("costPerMetre", cloth.CostPerMetre);
                XAttribute checkDate = new XAttribute("checkDate", cloth.CheckDate.ToString());
                XAttribute metresInStock = new XAttribute("metresInStock", cloth.MetresInStock);
                XAttribute markup = new XAttribute("markup", cloth.Markup.ToString());
                cl.Add(clothName);
                cl.Add(factory);
                cl.Add(clothType);
                cl.Add(costPerMetre);
                cl.Add(checkDate);
                cl.Add(metresInStock);
                cl.Add(markup);
                stock.Add(cl);
            }
            xdoc.Add(stock);
            xdoc.Save("stock.xml");
        }
    }
}
