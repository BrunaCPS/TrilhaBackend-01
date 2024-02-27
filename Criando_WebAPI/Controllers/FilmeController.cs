using AutoMapper;
using Criando_WebAPI.Data;
using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;
using Microsoft.AspNetCore.JsonPatch;
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
    [ProducesResponseType(StatusCodes.Status201Created)]
    //Cadastrar filme no sistema
    public IActionResult AdicionarFilme([FromBody] CreateFilmeDto filmeDto)
    {
        //Mapeamento de um Filme a partir de um filme DTO
        Filme filme = _mapper.Map<Filme>(filmeDto);
        _context.Filmes.Add(filme);
        _context.SaveChanges();
        return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);
    }

    //Recuperacao de dados
    [HttpGet]
    //Uso do IEnumerable para deixar o método abstrato, para depender de interface e não de uma classe concreta
    public IEnumerable<ReadFilmeDto> LerFilmes([FromQuery] int skip = 0, [FromQuery] int take = 50) //Usuario passará parametro na propra consulta, caso não passar entrará os valores padroes
    {
        //Skip para pular X elementos e Take para pegar X elementos
        //Pegará de 50 a 59
        return _mapper.Map<List<ReadFilmeDto>>(_context.Filmes.Skip(skip).Take(take));
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
        var filmeDto = _mapper.Map<ReadFilmeDto>(filme);
        return Ok(filmeDto);
    }

    [HttpPut("{id}")]

    public ActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        //mapeamento os campos do meu filme a partir de um filme DTO
        _mapper.Map(filmeDto, filme);
        _context.SaveChanges();
        //usado para quando é feita alguma atualizacao, retorno é 204
        return NoContent();
    }

    //Path usado para atualizações parciais, o PUT precisa passar o Objeto todo "UpdateFilmeDto filmeDto" mesmo que for atualizar 2 campos de 4, por exemplo, já o Path não
    [HttpPatch("{id}")]
    public ActionResult AtualizaFilmeParcial(int id, JsonPatchDocument<UpdateFilmeDto> patch)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();

        var filmeParaAtualizar = _mapper.Map<UpdateFilmeDto>(filme);
        patch.ApplyTo(filmeParaAtualizar, ModelState);

        if (!TryValidateModel(filmeParaAtualizar))
        {
            return ValidationProblem(ModelState);
        }
        //mapeamento os campos do meu filme a partir de um filme DTO
        _mapper.Map(filmeParaAtualizar, filme);
        _context.SaveChanges();
        //usado para quando é feita alguma atualizacao, retorno é 204
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletaFilme(int id)
    {
        var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        //caso exista o filme
        _context.Remove(filme);
        _context.SaveChanges();
        return NoContent();
    }
}