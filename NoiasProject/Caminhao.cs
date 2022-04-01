using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    public class Caminhao : Veiculo
    {
        public int numero_eixos;
        public double maximo_carga;
        public double altura;
        public Caminhao(string modelo, string fabricante, int ano, string cor,  int numero_portas, int numero_eixos, double maximo_carga, double altura, bool cadastrado): base(modelo, fabricante, ano, cor, numero_portas, cadastrado)
        {
            this.numero_eixos = numero_eixos;
            this.maximo_carga = maximo_carga;
            this.altura = altura;
        }
        public void DadosCaminhao()
        {
            this.Exibir();
            Console.WriteLine($"Numero de Eixos: {this.numero_eixos}\nCarga Máxima: {this.maximo_carga}\nAltura: {this.altura}");
            Console.WriteLine("=====================");
        }
    }
}
