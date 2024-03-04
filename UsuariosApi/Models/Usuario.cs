using Microsoft.AspNetCore.Identity;

namespace UsuariosApi.Models
{
    public class Usuario : IdentityUser
    {
        public DateTime DataNascimento { get; set; }

        //quando instanciar um usuario vai chamar o construtor da super classe desse usuario (IdentityUser)
        public Usuario() : base() { }
    }
}