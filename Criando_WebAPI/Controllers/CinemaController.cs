using AutoMapper;
using Criando_WebAPI.Data;
using Criando_WebAPI.Data.Dtos;
using Criando_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
//Operações que serão realizadas pelo usuário
namespace Criando_WebAPI.Controllers
{
    //Definicao das Anotacoes de controlador
    [ApiController]
    //Rota para /cinema que é o controlador
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        //Injecao de DEPENDENCIAS (_context e _mapper)
        private FilmeContext _context;
        private IMapper _mapper;

        public CinemaController(FilmeContext context, IMapper mapper)
        {
            //instancia do contexto que será utilizado
            _context = context;
            _mapper = mapper;

        }//Até aqui a injecao de dependencias


        //-------MÉTODOS HTTP-------
        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);//mapeamento do objeto cinemaDto do tipo CreateCinemaDto para um Cinema
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinemaDto);//retorna a rota em que ele foi criado
        }

        [HttpGet]
        public IEnumerable<ReadCinemaDto> RecuperaCinemas()
        {
            return _mapper.Map<List<ReadCinemaDto>>(_context.Cinemas.ToList());//retorna todos os cinemas cadastrados
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id)!;
            if (cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id, [FromBody] UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id)!;
            if (cinema == null)
            {
                return NotFound();
            }
            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return NoContent();
        }


        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id)!;
            if (cinema == null)
            {
                return NotFound();
            }
            _context.Remove(cinema);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
