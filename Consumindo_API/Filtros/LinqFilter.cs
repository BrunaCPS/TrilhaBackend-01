internal class LinqFilter
{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }

    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"-{artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"-{musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorTonalidade(List<Musica> musicas)
    {
        var musicasPorTonalidade = musicas
        .Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .ToList();
        Console.WriteLine("Músicas em C#");
        foreach (var musica in musicasPorTonalidade)
        {
            Console.WriteLine($"={musica}");
        }
    }
}