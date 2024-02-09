using System.Text.Json.Serialization;
internal class Musica{
    [JsonPropertyName("song")]
    public string Nome {get;set;}

    [JsonPropertyName("artist")]

    //? -> Pode ser nulo
    public string? Artista {get;set;}

    [JsonPropertyName("duration_ms")]
    public int Duracao {get;set;}

    [JsonPropertyName("genre")]

    public string? Genero {get;set;}

    public void ExibirDetalhesMusica(){
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");

    }

}