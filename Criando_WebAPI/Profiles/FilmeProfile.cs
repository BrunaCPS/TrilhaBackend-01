using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;
using AutoMapper;

namespace Criando_WebAPI.Profiles;
public class FilmeProfile : Profile{
    public FilmeProfile()
    {
        CreateMap<CreateFilmeDto, Filme>();
        CreateMap<UpdateFilmeDto, Filme>();
        CreateMap<Filme, UpdateFilmeDto>();
        CreateMap<Filme, ReadFilmeDto>();
    }
}