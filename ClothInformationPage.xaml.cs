using Microsoft.Win32;
using System;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ClothStock_WPF
{
    /// <summary>
    /// Interaction logic for ClothInformationPage.xaml
    /// </summary>
    public partial class ClothInformationPage : Page
    {
        public ClothInformationPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            StringBuilder info = new StringBuilder();
            int counter = 0;
            foreach (var cloth in ManagerModel.Stock) {
                info.AppendLine(counter++ + ". " + cloth.ToString());
            }
            report_TextBlock.Text = info.ToString();
        }

        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
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
                    writer.Write(report_TextBlock.Text);
                }
            }
        }
    }
}
