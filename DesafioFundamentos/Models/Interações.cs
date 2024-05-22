using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estacionamento.src.Models {
    internal interface Interações {
        public void Apresentacao();
        public void Cadastro(List<string> veiculos);
        public void RemoverCadastro(List<string> veiculos, double valorInicial, double valorPorHora);
        public void ListarCadastros(List<string> veiculos);

        }
    }
