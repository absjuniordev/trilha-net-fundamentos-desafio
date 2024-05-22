using estacionamento.src.Models;
using System.Runtime.InteropServices;

internal class Program {
    private static void Main(string[] args) {
    List<string> veicluos = new List<string>();
    int opcao;
    InteraçõesIMPL interações = new InteraçõesIMPL();

    Console.WriteLine("Sejam bem vindo ao sitema de estacionamento");
    Console.Write("Digite o valor inicial: ");
    double valorInicial = double.Parse(Console.ReadLine()!);
    Console.Write("Digite o valor por hora: ");
    double valorHora = double.Parse(Console.ReadLine()!);
    Console.Clear();

    do {

    interações.Apresentacao();
    opcao = int.Parse(Console.ReadLine()!);
    Console.Clear();

    switch (opcao) {
        case 1:
            interações.Cadastro(veicluos);
            Console.Clear();
            break;

        case 2:
            interações.RemoverCadastro(veicluos,valorInicial, valorHora);
            Console.Clear();
            break;
        case 3:
            interações.ListarCadastros(veicluos);
            Console.Clear();
            break;
        }
        } while (opcao != 4);

    Console.WriteLine("Saindo...");
        }


    }