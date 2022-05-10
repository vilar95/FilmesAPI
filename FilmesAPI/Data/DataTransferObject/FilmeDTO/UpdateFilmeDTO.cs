using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject
{
    public class UpdateFilmeDTO
    {
        [Required(ErrorMessage = "O campo Título é obrigatório.")]
        public string Titulo { get; set; }
        [Required(ErrorMessage = "O Campo Diretor é obrigatório.")]
        public string Diretor { get; set; }
        [StringLength(30, ErrorMessage = "O Gênero não pode passar de 30 caracteres.")]
        public string Genero { get; set; }
        [Range(1, 600, ErrorMessage = "A Duração deve ter no mínimo 1 e no maximo 600 minutos.")]
        public int Duracao { get; set; }
    }
}
