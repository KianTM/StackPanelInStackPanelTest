using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StackPanelInStackPanelTest.Gui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Button> buttons = new ObservableCollection<Button>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int buttonNumber = wrapPanel1.Children.Count;
            Button button = new Button() { Name = $"listBoxBtn{buttonNumber.ToString()}", Width = 50, Height = 35, Margin = new Thickness(2)};
            wrapPanel1.Children.Add(button);
        }
    }
}
