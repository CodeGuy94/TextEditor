using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace practice.Stuff.Controls
{
    /// <summary>
    /// Interaction logic for MenuBar.xaml
    /// </summary>
   
    public partial class MenuBar : UserControl
    {
        OpenFileDialog fileDialog = new OpenFileDialog();
        public string FileName = "";
        private string[] Read = new string[2000];
        MainWindow MainWin;
        public MenuBar()
        {
            InitializeComponent();
             
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.DefaultExt = "txt";
            fileDialog.Multiselect = false;
            fileDialog.ShowDialog();
            FileName = fileDialog.FileName;
            Read = File.ReadAllLines(FileName);
            for (int i = 0; i < Read.Length; i++)
                MainWin.TxtBox.Text += Read[i] + "\n";

            
           
            
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            
        }
         private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
