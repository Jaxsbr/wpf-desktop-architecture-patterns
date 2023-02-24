using System.Windows;

namespace Example.MVC
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            // simulate populating data from a store
            var personModel = new PersonModel();
            personModel.FirstName = "Buzz";
            personModel.LastName = "Lightyear";
            
            var personView = new PersonView();
            
            var personController = new PersonController(personModel, personView);
            personController.ShowView();
        }
    }
}
