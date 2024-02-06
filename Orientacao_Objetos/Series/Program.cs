Episodio ep1 = new Episodio(45,1,"Técnicas de facilitação");
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Bruna");

Episodio ep2 = new Episodio(50,2,"Técnicas de aprendizado");
ep2.AdicionarConvidados("John");
ep2.AdicionarConvidados("Isabel");

Podcast podcast = new Podcast("Podcast dev", "Bruna");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();
