using System.Text.Json;

using (HttpClient client = new HttpClient())
{
   try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");//não consegue converter do tipo task em string, por isso foi usado o await, para esperar a tarefa ser concluida e em seguida pegar o resultado da tarefa e colocar na variável
        //Console.WriteLine(resposta);

        //Criar uma lista do JSON baseado no Objeto
        //Desserialização -> Pega o JSON e converte em um objeto manipulável em C#
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
        //LinqOrder.ExibirListaArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas,"Michel Teló");

        var musicasPreferidasBruna = new MusicasPreferidas("Bruna");
        musicasPreferidasBruna.AdicionarMusicasFavoritas(musicas[1]);
        musicasPreferidasBruna.AdicionarMusicasFavoritas(musicas[377]);
        musicasPreferidasBruna.AdicionarMusicasFavoritas(musicas[4]);
        musicasPreferidasBruna.AdicionarMusicasFavoritas(musicas[6]);
        musicasPreferidasBruna.AdicionarMusicasFavoritas(musicas[1467]);

        musicasPreferidasBruna.ExibirMusicasFavoritas();

        var musicasPreferidasBel = new MusicasPreferidas("Bel");
        musicasPreferidasBel.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidasBel.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidasBel.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidasBel.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidasBel.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidasBel.ExibirMusicasFavoritas();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
