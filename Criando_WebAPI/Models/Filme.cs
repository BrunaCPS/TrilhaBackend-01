using System.ComponentModel.DataAnnotations;

namespace Criando_WebAPI.Models;

public class Filme
{
    //Chave que vai identificar esse campo lá no banco de dados
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O título do filme é obrigatório")]
    public string Titulo { get; set; }

    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O tamanho do gênero não pode exceder 50 caracteres")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "A duração do filme é obrigatório")]
    //Intervalo válido para duracao
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600 minutos")]
    public int Duracao { get; set; }
}