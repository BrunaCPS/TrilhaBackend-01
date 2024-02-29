namespace Criando_WebAPI.Data.Dtos
{
    public class ReadCinemaDto
    {
        //DTo de leitura
        public int Id { get; set; }
        public int Nome { get; set; }
        public ReadEnderecoDto Endereco { get; set; }

    }
}