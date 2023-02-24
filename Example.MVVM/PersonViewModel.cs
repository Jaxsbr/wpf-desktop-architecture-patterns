using System.ComponentModel;

namespace Example.MVVM
{
    public class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;

        public string FirstName
        {
            get { return _person.FirstName; }
            set
            {
                _person.FirstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string LastName
        {
            get { return _person.LastName; }
            set
            {
                _person.LastName = value;
                OnPropertyChanged("LastName");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public PersonViewModel()
        {
            _person = new Person();
        }

        public override string ToString()
        {
            return $"firstname: {FirstName} lastname: {LastName}";
        }
    }
}