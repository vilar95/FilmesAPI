using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.EnderecoDTO
{
    public class CreateEnderecoDTO
    {
        [Required(ErrorMessage = "O Campo do Logradouro é obrigatório")]
        public string Logradouro { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public int Numero { get; set; }
    }
}
