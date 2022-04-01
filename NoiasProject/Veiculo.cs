using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    public class Veiculo
    {
        public string modelo;
        public string fabricante;
        public int ano;
        public string cor;
        public int numero_portas;
        public bool cadastrado;
        public Veiculo(string modelo, string fabricante, int ano, string cor, int numero_portas, bool cadastrado)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
            this.cadastrado = cadastrado;
        }

        public void Exibir()
        {
            Console.WriteLine("=====================");
            Console.WriteLine($"Modelo: {this.modelo}\nFabricante: {this.fabricante}\nAno: {this.ano}\nCor: {this.cor}\nNúmero de Portas: ${numero_portas}");
        }
    }
}
