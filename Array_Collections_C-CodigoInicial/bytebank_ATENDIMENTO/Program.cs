using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");

#region Exemplos de Array e métodos em C#
Console.WriteLine("\nCálculo da Media");
TestaArrayInt();
Console.WriteLine("\nBusca por palavras");
TestaBuscarPalavra();

void TestaArrayInt()
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
}

void TestaBuscarPalavra(){

string[] arrayPalavras = new string[5];

for(int i = 0; i < arrayPalavras.Length; i++){
    Console.Write($"Digite {i+1}ª palavra: ");
    arrayPalavras[i] = Console.ReadLine()!;
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

//classe array
Array amostra = Array.CreateInstance(typeof(double), 5);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

Console.WriteLine("\nCálculo da Mediana");
TestaMediana(amostra);

void TestaMediana(Array array)
{
    if ((array == null) || (array.Length == 0))
    {
        Console.WriteLine("Array está vazio ou nulo");
    }

        //cria array reserva com método Clone()
        double[] numerosOrdenados = (double[])array.Clone();
        //metodo Sort() para ordenar
        Array.Sort(numerosOrdenados);

        //calculo mediana
        int tamanho = numerosOrdenados.Length;
        int meio = tamanho / 2;
        double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

        Console.WriteLine($"Com base na amostra, a mediana é {mediana}");
    }

#endregion