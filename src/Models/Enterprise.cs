namespace ISS.Models
{
    public class Enterprise : BaseEntity
    {
        public string Identification { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Provider { get; set; }

        public Enterprise(string identification, string name, string city, string provider):base()
        {
            Identification = identification;
            Name = name;
            City = city;
            Provider = provider;
        }

    }
}