using AutoMapper;
using Criando_WebAPI.Data;
using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace Criando_WebAPI.Controllers;

//Para que a classe consiga receber e lidar com as requisições dos usuarios, é necessário:
[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    //Injecao de dependencias
    private FilmeContext _context;
    private IMapper _mapper;


    public FilmeController(FilmeContext context, IMapper mapper)
    {
        //intancia do contexto que será utilizado
        _context = context;
        _mapper = mapper;

    }

    [HttpPost]
    //Cadastrar filme no sistema
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
    {
        //Mapeamento de um Filme a partir de um filme DTO
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaFilmePorId), new {id = filme.Id}, filme);
    }

    //Recuperacao de dados
    [HttpGet]
    //Uso do IEnumerable para deixar o método abstrato, para depender de interface e não de uma classe concreta
    public IEnumerable<Filme> LerFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50) //Usuario passará parametro na propra consulta, caso não passar entrará os valores padroes
    {
        //Skip para pular X elementos e Take para pegar X elementos
        //Pegará de 50 a 59
        return _context.Filmes.Skip(skip).Take(take);
    }

    //Como saber qual GET o programa vai executar?
    //Se especificar igual o exemplo abaixo irá retornar ele, se não retornará todos os filmes
    [HttpGet("{id}")]
    public ActionResult RecuperaFilmePorId(int id)
    {
        //firstordefault -> retorna o primeiro elemento que encontrar ou padrao especifico se não tiver a informacao passada
        //return filmes.FirstOrDefault(filme => filme.Id == id);

        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}