using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.DataTransferObject.EnderecoDTO
{
    public class CreateEnderecoDTO
    {
        
        public string Logradouro { get; set; }
        
        public string Bairro { get; set; }
        
        public int Numero { get; set; }
    }
}
