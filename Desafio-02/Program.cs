using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Usuario usuario = new Usuario();

void Menu()
{
    Console.WriteLine("\n=========SISTEMA DE RESERVA DE HOTÉIS==========");
    Console.WriteLine("\nAntes de reservar, faça o cadastro no sistema...");

    Console.WriteLine("1- Cadastrar-se no sistema para reservar um hotel");

    Console.WriteLine("\nSe já possuir cadastro, faça já a reserva em um hotel!");
    Console.WriteLine("2- Já possuo cadastro e desejo reservar um hotel");
    Console.WriteLine("3- Exibir dados de Cadastro do usuário");
    Console.WriteLine("4- Cancelar Reserva");
    Console.WriteLine("5- Cancelar Cadastro do usuário");
    Console.WriteLine("6- Sair do sistema");

    Console.WriteLine("\nQual a opção deseja?");
    char op = char.Parse(Console.ReadLine()!);

    switch (op)
    {
        case '1':
            usuario.CadastrarUsuario();
            Menu();
            break;

        /*case '2':
            hotel.ReservarHotel();
            break;*/

        case '3':
            usuario.ExibirCadastroUsuario();
            break;

        /*case '4':
            CancelarReserva();
            break;*/

        case '5':
            usuario.CancelarCadastroUsuario();
            Menu();
            break;
/*
        case '6':
            SairDoSistema();
            break;*/

        default:
            Console.WriteLine("Opção inválida...");
            Thread.Sleep(2000);
            Console.Clear();
            Menu();
            break;

    }
}

Menu();
