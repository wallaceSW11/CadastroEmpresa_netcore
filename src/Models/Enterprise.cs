using System.ComponentModel.DataAnnotations;

namespace ISS.Models
{
    public class Enterprise : BaseEntity
    {
        [Required(ErrorMessage = "Please, inform the identification.")]
        [MaxLength(14, ErrorMessage = "The identification must have 14 numbers"), MinLength(14, ErrorMessage = "The identification must have 14 numbers")]
        public string Identification { get; set; }

        [Required(ErrorMessage = "Please, inform the enteprise name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, inform the city.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please, inform the provider.")]
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