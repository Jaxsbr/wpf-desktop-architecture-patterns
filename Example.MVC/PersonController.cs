using System.Windows;

namespace Example.MVC
{
    public class PersonController
    {
        private PersonModel _person;
        private PersonView _view;

        public PersonController(PersonModel person, PersonView view)
        {
            _person = person;
            _view = view;

            _view.DataContext = _person;
            _view.SaveButton.Click += Save_Click;
        }

        public void ShowView()
        {
            _view.Show();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Saving change as: {_person.ToString()}");
        }
    }

}