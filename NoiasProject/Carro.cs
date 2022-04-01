using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    class Carro : Veiculo
    {
        public int capacidadePortaMala;
        public bool bagageiro;
        public bool cambio;
        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int capacidadePortaMala, bool bagageiro, bool cambio, bool cadastrado): base(modelo, fabricante, ano, cor, numero_portas, placa, cadastrado)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.cambio = cambio;
        }

        public void DadosCarro()
        {
            this.Exibir();
            Console.Write($"Capacidade do Porta Malas: {capacidadePortaMala}\nBagageiro: ");
            if (this.bagageiro){Console.Write("Tem\nCambio: ");}
            if (this.cambio) { Console.WriteLine("Tem");}
            Console.WriteLine("=====================");
        }
    }
}