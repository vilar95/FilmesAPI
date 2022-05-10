using FilmesAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.CinemaDTO
{
    public class ReadCinemaDTO 
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo do nome é obrigatório")]
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
