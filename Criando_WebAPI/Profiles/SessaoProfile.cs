using AutoMapper;
using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;

namespace Criando_WebAPI.Profiles{
    public class SessaoProfile:Profile{
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>();
        }
    }
}