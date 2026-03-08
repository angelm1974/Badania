using System.ComponentModel.DataAnnotations;

namespace Badania.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Imię jest wymagane")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Nazwisko jest wyamgane")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Adres jest wymagany")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = "Wybór płci jest wymagany")]
        public string Gender { get; set; } = string.Empty;
    }
}
