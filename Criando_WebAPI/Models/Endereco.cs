using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Criando_WebAPI.Models{
    public class Endereco{
        //Definir propriedades para mapear para banco
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }

        //3) Tem que fazer a mesma coisa para Cinema
        public virtual Cinema Cinema { get; set; }

    }
}