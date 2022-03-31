using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    class Veiculo
    {
        public string modelo;
        public string fabricante;
        public int ano;
        public string cor;
        public int numero_portas;

        public Veiculo(string modelo, string fabricante, int ano, string cor, int numero_portas)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
        }

    }
}
