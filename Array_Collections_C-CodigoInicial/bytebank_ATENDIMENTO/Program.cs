Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
//TestaArrayInt();
TestaBuscarPalavra();
/*void TestaArrayInt()
{
    int[] idades = new int[5];
    idades[0] = 30;
    idades[1] = 40;
    idades[2] = 17;
    idades[3] = 21;
    idades[4] = 18;

    Console.WriteLine($"Tamanho do meu array {idades.Length} ");

    int acumulador = 0;
    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades[i];
        Console.WriteLine($"Indice [{i}] = {idades[i]}");
        acumulador += idade;
    }
    int media = acumulador / idades.Length;
    Console.WriteLine($"Média: {media}");
}*/

void TestaBuscarPalavra(){

string[] arrayPalavras = new string[5];

for(int i = 0; i < arrayPalavras.Length; i++){
    Console.Write($"Digite {i+1}ª palavra: ");
    arrayPalavras[i] = Console.ReadLine();
}

Console.Write("Digite a palavra a ser encontrada: ");
//tipo var definida em tempo de execucao 
var busca = Console.ReadLine();

foreach(string palavra in arrayPalavras){
    if(palavra.Equals(busca)){
        Console.WriteLine($"Palavra {busca} foi encontrada");
        //ou return
        break;
    }
    
}
}
