using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.EnderecoDTO
{
    public class ReadEnderecoDTO
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "O Campo do Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public int Numero { get; set; }
    }
}
