using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    class Program
    { 
        public struct Carro
    {
            public string placa;
    }
        static void Main(string[] args)
        {
            //PARTE 3 DO EXERCÍCIO - Consulta por placa

            string placa = "placa";
            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();

            for (int c = 0; c <= 301; c++)
            {
                if (placa == "Váriavel publica da classe do caminhão")
                {
                    Console.WriteLine($"Carro da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nNúmero de eixos: {"Váriavel publica da classe"}\nPeso máximo: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
            }
            for (int c = 0; c <= 301; c++)
            {
                if (placa == "Váriavel publica da classe do caminhão")
                {
                    Console.WriteLine($"Carro da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nCapacidade do porta malas: {"Váriavel publica da classe"}\nBagageiro: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
            }
            placa = "placa";

            Console.ReadKey();
        }
        
        
        //PARTE 4 DO EXERCÍCIO - Consulta por Modelo/Marca
        static void Caso4()
        }
            string ModeloMarca = "modelo/marca";
            Console.Write("Digite o modelo/marca do veículo: ");
            ModeloMarca = Console.ReadLine();

            for (int c = 0; c <= 301; c++)
            {
                if (ModeloMarca == "Váriavel pública do modelo carro")
                {
                    Console.WriteLine($"Carro da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nNúmero de eixos: {"Váriavel publica da classe"}\nPeso máximo: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
                else if (ModeloMarca == "Váriavel publica da marca carro")
                {
                    Console.WriteLine($"Carro da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nNúmero de eixos: {"Váriavel publica da classe"}\nPeso máximo: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
            }
            for (int c = 0; c <= 201; c++)
            {
                if (ModeloMarca == "Váriavel pública do modelo caminhão")
                {
                    Console.WriteLine($"Caminhão da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nNúmero de eixos: {"Váriavel publica da classe"}\nPeso máximo: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
                else if (ModeloMarca == "Váriavel publica da marca caminhão")
                {
                    Console.WriteLine($"Caminhão da marca: {"Váriavel publica da classe"}\nPlaca: {"Váriavel publica da classe"}\nModelo: {"Váriavel publica da classe"}\nFabricante {"Váriavel publica da classe"}\nAno: {"Váriavel publica da classe"}\nCor: {"Váriavel publica da classe"}\nNúmero de portas: {"Váriavel publica da classe"}\nNúmero de eixos: {"Váriavel publica da classe"}\nPeso máximo: {"Váriavel publica da classe"}\n Váriavel específica: {"Váriavel publica da classe"}");
                    break;
                }
            }

            ModeloMarca = "modelo/marca";

            Console.ReadKey();
        }
    }
}
