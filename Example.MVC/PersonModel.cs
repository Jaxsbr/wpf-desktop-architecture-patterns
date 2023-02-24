namespace Example.MVC 
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return $"firstname: {FirstName} lastname: {LastName}";
        }
    }
}