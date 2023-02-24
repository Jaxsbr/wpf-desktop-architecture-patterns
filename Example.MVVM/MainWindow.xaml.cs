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

namespace Example.MVVM
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PersonViewModel _personViewModel;

        public MainWindow()
        {
            InitializeComponent();

            // Simulate loading data from a store
            _personViewModel = new PersonViewModel();
            _personViewModel.FirstName = "Buzz";
            _personViewModel.LastName = "Lightyear";

            DataContext = _personViewModel;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Saving change as: {_personViewModel.ToString()}");
        }
    }
}
