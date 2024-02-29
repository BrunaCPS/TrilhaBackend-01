using System.ComponentModel.DataAnnotations;

namespace Criando_WebAPI.Data.Dtos{
    
    public class CreateCinemaDto{

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        
        public int Nome { get; set; }

        //No momento que for criar o cinema no BD, preciso receber como parametro no controlador através da Dto o EnderecoId
        public int EnderecoId { get; set; }
    }
}