using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;
using AutoMapper;

//autoMapper usado para mapeamento das propriedades de um objeto para o outro
namespace Criando_WebAPI.Profiles
{
    public class CinemaProfile : Profile
    {

        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema, ReadCinemaDto>().ForMember(cinemaDto => cinemaDto.Endereco, opt => opt.MapFrom(cinema => cinema.Endereco));//para determinado membro, você irá fazer determinado mapeamento para pegar da origem (cinem) o campo de endereço
            CreateMap<UpdateCinemaDto, Cinema>();
        }
    }
}