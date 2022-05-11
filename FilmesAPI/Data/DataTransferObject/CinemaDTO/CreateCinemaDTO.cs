using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.CinemaDTO
{
    public class CreateCinemaDTO
    {
        [Required(ErrorMessage = "O Campo do nome é obrigatório")]
        public string Nome { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }

    }
}
