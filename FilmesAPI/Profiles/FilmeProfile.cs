using AutoMapper;
using FilmesAPI.Data.DataTransferObject;
using FilmesAPI.Models;

namespace FilmesAPI.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDTO, Filme>();
            CreateMap<ReadFilmeDTO, Filme>();
            CreateMap<UpdateFilmeDTO, Filme>();
        }
    }
}
