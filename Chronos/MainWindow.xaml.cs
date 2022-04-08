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



namespace Chronos
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int year = 2022;
        public MainWindow()
        {
            InitializeComponent();

            Month januar = new Month(year, "Januar");
            Month februar = new Month(year, "Februar");
            Month maerz = new Month(year, "März");
            Month april = new Month(year, "April");
            Month mai = new Month(year, "Mai");
            Month juni = new Month(year, "Juni");
            Month juli = new Month(year, "Juli");
            Month august = new Month(year, "August");
            Month september = new Month(year, "September");
            Month oktober = new Month(year, "Oktober");
            Month november = new Month(year, "November");
            Month dezember = new Month(year, "Dezember");

            daysJanuar.ItemsSource = januar.Days;
            
        }

        private void ListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext;
            Day myItem = item as Day;
            if (item != null)
            {
                //Here you have your item
            }
        }
    }
}
