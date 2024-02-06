class Musica
    {
        public Musica(Banda artista, string nome){
            Artista = artista;
            Nome = nome;
        }
        public string Nome { get; }
        public Banda Artista { get; }
        public int Duracao { get; set; }
        public bool Disponivel { get; set; }
        //lambda
        public string Descricao => $"A música {Nome} pertence à banda {Artista}";



        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Arista: {Artista.Nome}");
            Console.WriteLine($"Duração: {Duracao}");

            if (Disponivel)
            {
                Console.WriteLine("Disponível para plano");
            }
            else
            {
                Console.WriteLine("Adquira o plano Plus+");
            }

        }
    }
