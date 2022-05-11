using FilmesAPI.Models;
using System.Collections.Generic;

namespace FilmesAPI.Data.DataTransferObject.GerenteDTO
{
    public class ReadGerenteDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public object Cinemas { get; set; }
    }
}
