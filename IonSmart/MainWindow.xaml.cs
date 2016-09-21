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
using Fluent;
namespace IonSmart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Fluent.RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void openVast(object sender, RoutedEventArgs e)
        {
            MainContext.Navigate(new Uri("VAST_Page.xaml", UriKind.Relative));
            MainContext.HorizontalAlignment = HorizontalAlignment.Stretch;
            MainContext.Height = this.ActualHeight;
            var popup = new VAST_CamManagement_PopupWindow();
            popup.ShowDialog();
        }
    }
}
