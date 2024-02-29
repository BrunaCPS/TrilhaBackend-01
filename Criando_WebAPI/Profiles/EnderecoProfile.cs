using AutoMapper;
using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;

namespace Criando_WebAPI.Profiles{

    //É no Profile que ficará o mapeamento do AutoMapper
    public class EnderecoProfile: Profile{
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco,ReadEnderecoDto>();//aqui é invertido, pois quando estamos buscando info é do obj Endereco para ReadEndereco
            CreateMap<UpdateEnderecoDto, Endereco>();

        }

    }
}