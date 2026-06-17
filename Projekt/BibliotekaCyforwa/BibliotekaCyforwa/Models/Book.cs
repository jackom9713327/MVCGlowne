using System.ComponentModel.DataAnnotations;

namespace BibliotekaCyfrowa.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany.")]
        [StringLength(200, ErrorMessage = "Tytuł może mieć maksymalnie 200 znaków.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Autor jest wymagany.")]
        [StringLength(100, ErrorMessage = "Autor może mieć maksymalnie 100 znaków.")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Rok wydania jest wymagany.")]
        [Range(1000, 2100, ErrorMessage = "Rok musi być z zakresu 1000–2100.")]
        public int Year { get; set; }
    }
}