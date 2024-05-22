using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento.src.Models {
    internal class InteraçõesIMPL : Interações {
        public void Apresentacao() {
        System.Console.WriteLine("Digite uma opção");
        System.Console.WriteLine("1 - Cadastrar veiculo");
        System.Console.WriteLine("2 - Remover veiculo");
        System.Console.WriteLine("3 - Listar veiculos");
        System.Console.WriteLine("4 - Encerrar");
            }

        public void Cadastro(List<string> veicluos) {

        Console.Write("Digite a placa do veiculo: ");
        string placa = Console.ReadLine()!;
        veicluos.Add(placa);
        Console.WriteLine("Placa cadastrada com sucesso!\nPrecione qualquer tecla para continuar!");
        Console.ReadLine();
            }

        public void ListarCadastros(List<string> veiculos) {
        Console.WriteLine("|--- Controle de Patio ---|");
        if (veiculos.Count == 0) {
        Console.WriteLine("Estacionamento Vazio");
            }
        foreach (var item in veiculos) {
        Console.WriteLine($"PLACA: {item}");
            }
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadLine();
            }

        public void RemoverCadastro(List<string> veiculos, double valorInicial, double valorPorHora) {
        if (veiculos.Count == 0) {
        Console.WriteLine("Estacionamento Vazio");
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadLine();
        return;
            }
        Console.Write("Digite a placa que deseja remover: ");
        string placaDigitada = Console.ReadLine()!;

        for (int i = 0; i < veiculos.Count; i++) {

        if (veiculos[i].Contains(placaDigitada)) {
        veiculos.Remove(placaDigitada);
        Console.Write("Digite a quantidade de horas que o veiculo permaneceu estacionado: ");
        int horasPermanencia = int.Parse(Console.ReadLine()!);
        double totalAPagar = valorInicial + (horasPermanencia * valorPorHora);
        Console.WriteLine($"O veiculo {placaDigitada} foi removido e o preço total foi de: R$ {totalAPagar}");
        Console.WriteLine("Precione qualquer tecla para continuar...");
        Console.ReadLine();
            }
        else {
        Console.WriteLine("Placa não encontrada");
            }


            }


            }
        }
    }
