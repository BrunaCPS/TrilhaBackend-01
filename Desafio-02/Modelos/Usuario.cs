using System.ComponentModel.Design;

class Usuario : IUser
{
    public string? Nome { get; }
    public long CPF { get; }
    public long Telefone { get; }
    public string? Email { get; }
    public int Idade { get; }

    private List<Usuario> ListaDeUsuarios = new List<Usuario>();

    public Usuario()
    {
        //Contrutor vazio para ser possível instanciar o objeto em Program.cs
    }

    public Usuario(string nome, long cpf, long telefone, string email, int idade)
    {
        Nome = nome;
        CPF = cpf;
        Telefone = telefone;
        Email = email;
        Idade = idade;
    }

    public void CadastrarUsuario()
    {
        System.Console.WriteLine("Informe o nome do hóspede: ");
        string nome = Console.ReadLine()!;

        System.Console.WriteLine("Informe o CPF do hóspede: ");
        long cpf = long.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Informe o telefone do hóspede: ");
        long telefone = long.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Informe a idade do hóspede: ");
        int idade = int.Parse(Console.ReadLine()!);

        System.Console.WriteLine("Informe um e-mail: ");
        string email = Console.ReadLine()!;

        Usuario novoUsuario = new Usuario(nome, cpf, telefone, email, idade);
        ListaDeUsuarios.Add(novoUsuario);
        System.Console.WriteLine("\nUsuário cadastrado com sucesso!");
    }

    public void CancelarCadastroUsuario()
    {
        System.Console.WriteLine("Digite o CPF do usuário que deseja encerrar o cadastro: ");
        long cpf = long.Parse(Console.ReadLine()!);

        Usuario usuario = ListaDeUsuarios.Find(u => u.CPF == cpf)!;

        if (usuario != null)
        {
            ListaDeUsuarios.Remove(usuario);
            System.Console.WriteLine("Usuário removido com sucesso");
        }
        else
        {
            System.Console.WriteLine("Usuário não encontrado...");
        }

    }

    public void AtualizarCadastroUsuario()
    {


    }

    public void ExibirCadastroUsuario()
    {
        foreach (Usuario usuario in ListaDeUsuarios)
        {
            System.Console.WriteLine($"\n====Dados do usuário {usuario.Nome}====");
            System.Console.WriteLine($"Nome: {usuario.Nome}");
            System.Console.WriteLine($"E-mail: {usuario.Email}");
            System.Console.WriteLine($"CPF: {usuario.CPF}");
            System.Console.WriteLine($"Idade: {usuario.Idade}");
            System.Console.WriteLine($"Telefone: {usuario.Telefone}");
        }
        

    }

}

