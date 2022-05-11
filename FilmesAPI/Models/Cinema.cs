﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesAPI.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="O Campo do nome é obrigatório")]
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
       
        public int EnderecoId { get; set; }
        public virtual Gerente Gerente { get; set; }

        public int GerenteId { get; set; }
    }
}
