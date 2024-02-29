using System.ComponentModel.DataAnnotations;

namespace Criando_WebAPI.Data.Dtos{
    public class UpdateCinemaDto{
        //Permite atualizar o nome
        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public int Nome { get; set; }
    }
}