using Criando_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Criando_WebAPI.Data;

    public class FilmeContext : DbContext
    {

        //construtor do FilmeContext que receberá as OPCOES (OPTS) de acesso ao banco
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {

        }

        public DbSet<Filme> Filmes {get;set;}
        public DbSet<Cinema> Cinemas {get;set;}
        public DbSet<Endereco> Enderecos {get;set;}
        public DbSet<Sessao> Sessoes {get;set;}


    }


