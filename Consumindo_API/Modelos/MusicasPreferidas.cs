using System.Text.Json;

internal class MusicasPreferidas
{
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; set; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as músicas favoritas {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine(" ");
    }

    public void GerarArquivoJson()
    {
        //Serialização (transformar em Json)
        string json = JsonSerializer.Serialize(new
        { //propriedade anonima/criar objeto anonimo
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"musicas-favoritas={Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"Arquivo Json foi criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)} ");
    }



}