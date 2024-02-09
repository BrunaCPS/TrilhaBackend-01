using System.Text.Json.Serialization;
internal class Musica
{

    private string[] Tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]

    //? -> Pode ser nulo
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]

    public string? Genero { get; set; }

    [JsonPropertyName("key")]

    public int Key { get; set; }

    public string Tonalidade
    {
        get
        {
            return Tonalidades[Key];
        }
    }


    public void ExibirDetalhesMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
    }

}