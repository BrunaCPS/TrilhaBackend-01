class Episodio{
    private List<string> convidados = new();

    public Episodio(int duracao,int ordem, string titulo){
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }
    public int Duracao {get;}
    public int Ordem {get;}
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao} min) - {string.Join(", ", convidados)}";
    public string Titulo {get;}

    public void AdicionarConvidados(string convidado){
        convidados.Add(convidado);
    }
}