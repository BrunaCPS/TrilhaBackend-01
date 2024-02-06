//---------------Sistema de Controle de Estoque-----------------
SortedList<string, int> estoque = new SortedList<string, int>();

void Menu()
{
    Console.WriteLine("\n=========CONTROLE DE ESTOQUE==========");
    Console.WriteLine("1- Adicionar novo produto no estoque");
    Console.WriteLine("2- Remover produto do estoque");
    Console.WriteLine("3- Consultar estoque");
    Console.WriteLine("4- Reajuste do estoque");
    Console.WriteLine("5- Sair do sistema");

    Console.WriteLine("\nQual a opção deseja?");
    char op = char.Parse(Console.ReadLine()!);

    switch (op)
    {
        case '1':
            AdicionarProduto();
            break;

        case '2':
            RemoverProduto();
            break;

        case '3':
            ConsultarEstoque();
            break;

        case '4':
            AjustarEstoque();
            break;

        case '5':
            SairDoSistema();
            break;

        default:
            Console.WriteLine("Opção inválida...");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
            break;

    }
}

void AdicionarProduto()
{
    int quantidadeNovoProduto = 0;
    Console.Clear();
    Console.WriteLine("Qual produto deseja adicionar no estoque?");
    string novoProduto = Console.ReadLine()!.ToLower();

    if (estoque.ContainsKey(novoProduto))
    {
        Console.WriteLine("Produto já existe...");
        VoltarAoMenu();
    }
    else
    {
        do
        {
            Console.WriteLine("Qual a quantidade deste produto deseja adicionar no estoque?");
            string valor = Console.ReadLine()!;

            if(int.TryParse(valor, out quantidadeNovoProduto) && quantidadeNovoProduto > 0){
                break;
            }else{
                Console.WriteLine("\nDigite uma quantidade válida...");
            }
        } while (true);

        estoque.Add(novoProduto, quantidadeNovoProduto);
        Console.WriteLine($"\nProduto {novoProduto} adicionado ao estoque!");
        VoltarAoMenu();
    }



}

void RemoverProduto()
{
    Console.Clear();
    Console.WriteLine("Qual produto você deseja remover completamente do estoque?");
    string produtoRemovido = Console.ReadLine()!.ToLower();

    if (estoque.ContainsKey(produtoRemovido))
    {
        estoque.Remove(produtoRemovido);
        Console.WriteLine($"Produto {produtoRemovido} removido com sucesso!");
        VoltarAoMenu();
    }
    else
    {
        Console.WriteLine("\nProduto não existe no estoque...");
        VoltarAoMenu();
    }
}

void ConsultarEstoque()
{
    Console.Clear();
    for (int i = 0; i < estoque.Count; i++)
    {
        Console.WriteLine($"Produto: {estoque.Keys[i]} | Quantidade em estoque: {estoque.Values[i]}");
    }
    VoltarAoMenu();
}


void AjustarEstoque()
{
    Console.Clear();
    int quantidadeAjustada;
    Console.WriteLine("Qual produto você deseja ajustar a quantidade em estoque?");
    string produto = Console.ReadLine()!.ToLower();

    if (estoque.ContainsKey(produto))
    {
        do
        {
            Console.WriteLine("Quantidade que deseja ajustar: ");
            quantidadeAjustada = int.Parse(Console.ReadLine()!);
        } while (quantidadeAjustada <= 0);

        estoque[produto] = quantidadeAjustada;
        Console.WriteLine("Ajuste realizado com sucesso!");
        VoltarAoMenu();
    }
    else
    {
        Console.WriteLine("\nProduto não existe no estoque...");
        VoltarAoMenu();
    }

}

void SairDoSistema()
{
    Console.WriteLine("Encerrando...");
    Thread.Sleep(2000);
    Console.Clear();
}

void VoltarAoMenu()
{
    Console.WriteLine("Pressione uma tecla para voltar ao menu principal...");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

Menu();
