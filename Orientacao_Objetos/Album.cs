
     class Album
    {
        private List<Musica> musicas = new List<Musica>();

        public Album(string nome){
            Nome = nome;
        }
        public string Nome {get;}
        //para cada musica, quero somar as musicas
        public int DuracaoTotal => musicas.Sum(m => m.Duracao);

        public void AdicionarMusica(Musica musica){
            musicas.Add(musica);
        }

        public void ExibirMusicasDoAlbum(){

            Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
            foreach (var musica in musicas)
            {
            Console.WriteLine($"Música: {musica.Nome}");
            }
            Console.WriteLine($"Para ouvir este álbum inteiro você precisa de {DuracaoTotal}");
        }
    }
