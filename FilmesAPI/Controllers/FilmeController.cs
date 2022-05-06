﻿using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        
        [HttpPost]
        public void AdicionarFilme([FromBody]Filme filme)
        {
            filmes.Add(filme);
            Console.WriteLine(filme.Titulo);
        }
    }
}
