using System.ComponentModel.DataAnnotations;

namespace  Criando_WebAPI.Models{
    public class Sessao{
        [Key]
        [Required]
        public int Id { get; set; }

        //iniciar relacao com filme
        [Required]
        public int FilmeId { get; set; }
        public virtual Filme Filme { get; set; }

        public int? CinemaId { get; set; }// ? pode ser nulo
        public virtual Cinema Cinema { get; set; }
    }
}
