internal class MusicasPreferidas{
    public string Nome {get;set;}
    public List<Musica> ListaDeMusicasFavoritas {get;set;}

    public MusicasPreferidas(string nome){
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicasFavoritas(Musica musica){
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas(){
        Console.WriteLine($"Essas são as músicas favoritas {Nome}");
        foreach(var musica in ListaDeMusicasFavoritas){
            Console.WriteLine($"-{musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine(" ");
    }

}