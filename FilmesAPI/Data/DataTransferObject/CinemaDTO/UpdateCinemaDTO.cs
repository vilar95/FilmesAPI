using AutoMapper;
using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.CinemaDTO
{
    public class UpdateCinemaDTO : Profile
    {
        [Required(ErrorMessage = "O Campo do nome é obrigatório")]
        public string Nome { get; set; }

    }
}
