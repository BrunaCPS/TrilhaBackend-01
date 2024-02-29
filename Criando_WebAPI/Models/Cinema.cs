using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Criando_WebAPI.Models
{
    public class Cinema
    {
        [Key] //Identificador necessario
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo de nome é obrigatório")]
        public string Nome { get; set; }

        //1) Incluindo o ID do Endereço para iniciar o relacionamento
        public int EnderecoId { get; set; }//Para cadastrar cinema no BD e para que Cinema exista, preciso receber o ID do Endereco

        //2) Informar ao Entity que a entidade Cinema possui uma relacao de possuir 1 e apenas 1 endereco
        public virtual Endereco Endereco { get; set; }

        //relacionamento com sessao
        public virtual ICollection<Sessao> Sessoes { get; set; }
    }
}