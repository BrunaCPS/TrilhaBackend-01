internal class LinqFilter{
    public static void FiltrarTodosGenerosMusicais(List<Musica> musicas){
        var todosGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosGenerosMusicais){
            Console.WriteLine($"- {genero}");
        }

    }
}