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

        [Required(ErrorMessage = "Please, inform the State.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please, inform the Country.")]
        public string Country { get; set; }
        public Enterprise(Guid id, string identification, string name, string city, string state, string country):base()
        {
            Id = id == Guid.Empty ? Guid.NewGuid() : id;
            Identification = identification;
            Name = name;
            City = city;
            State = state;
            Country = country;
        }

    }
}