using System.Text.Json;

using (HttpClient client = new HttpClient())
{
   try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");//não consegue converter do tipo task em string, por isso foi usado o await, para esperar a tarefa ser concluida e em seguida pegar o resultado da tarefa e colocar na variável
        Console.WriteLine(resposta);

        //Criar uma lista do JSON baseado no Objeto
        //Desserialização -> Pega o JSON e converte em um objeto manipulável em C#
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosGenerosMusicais(musicas);
        LinqOrder.ExibirListaArtistasOrdenados(musicas);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
