using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoiasProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0, optionMenu, meuCarro = 0, meuCaminhao = 0;
            int carrosRegistrados = 0, caminhoesRegistrados = 0;
            string modelo, fabricante, cor;
            Carro[] carro = new Carro[300];
            Caminhao[] caminhao = new Caminhao[200];
            for(int i = 0; i<carro.Length; i++) //preenchendo os arrays
            {
                carro[i] = new Carro("", "", 0000, "", 0, 0, false, false, false);
            }

            for (int i = 0; i < caminhao.Length; i++) //preenchendo os arrays
            {
                caminhao[i] = new Caminhao("", "", 0000,"", 0, 0, 0, 0, false);
            }

            do
            {
                Console.WriteLine("****Menu**** \n 1 - Cadastrar carro \n 2 - Cadastrar caminhão \n 3 - Consultar por placa \n 4 - Consultar caminhão por modelo/marca \n 5 - Consultar carro por cor \n 6 - Exibir todos os carros cadastrados \n 7 - Exibir todos os caminhões cadastrados \n 0 - Sair");
                optionMenu = int.Parse(Console.ReadLine());
                switch (optionMenu)
                {
                    case 0:
                        Console.WriteLine("Deseja mesmo sair? [1 - sim/2- não]");
                        n = int.Parse(Console.ReadLine());
                        optClose(n);
                        break;
                    case 1:
                        if (carrosRegistrados < 300)
                        {
                            carro[meuCarro] = CadastrarCarro();
                            meuCarro++;
                            carrosRegistrados++;
                        }
                        else
                        {

                        }
                        n = 2;
                        Console.Clear();

                        break;
                    case 2:
                        if (caminhoesRegistrados < 200)
                        {
                            caminhao[meuCaminhao] = CadastrarCaminhao();
                            meuCaminhao++;
                            caminhoesRegistrados++;
                        }
                        else
                        {

                        }
                        n = 2;
                        Console.Clear();
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        n = 2;
                        Console.Clear();
                    break;

                    case 6:
                        ExibirCarros(carro);
                        break;
                    case 7:
                        ExibirCaminhoes(caminhao);
                        break;
                };
            } while (n == 2);
            Console.ReadKey();
        }
        static int optClose(int n)
        {
            if (n == 1)
            {
                Console.Clear();
                Console.WriteLine("Me desculpe :( prometo ser melhor da próxima vez!!");
            }
            else
            {
                Console.Clear();
                n = 2;
            }
            return n;
        }
        static Carro CadastrarCarro()
        {
            Console.Clear();
            Carro carro = new Carro("", "", 0000, "", 0, 0, false, false, false);
            Console.WriteLine("Digite o modelo do seu caminhão: ");
            carro.modelo = Console.ReadLine();
            Console.WriteLine("Digite o/a fabricante do seu caminhão: ");
            carro.fabricante = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo: ");
            carro.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor do seu caminhão: ");
            carro.cor = Console.ReadLine();
            Console.WriteLine("Digite o número de portas do seu veículo: ");
            carro.numero_portas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a capacidade máxima do porta mala: ");
            carro.capacidadePortaMala = int.Parse(Console.ReadLine());
            Console.WriteLine("O carro possui bagageiro? [S/N] :");
            string msg = Console.ReadLine();
            carro.bagageiro = msg != "s" || msg != "S" ? true : false;
            Console.WriteLine("O carro possui cambio? [S/N] :");
            msg = Console.ReadLine();
            carro.cambio = msg != "s" || msg != "S" ? true : false;
            carro.cadastrado = true;
            Console.Clear();

            return carro;
        }
        static Caminhao CadastrarCaminhao()
        {
            Console.Clear();
            Caminhao caminhao = new Caminhao("", "", 0000, "", 0, 0, 0, 0, false);
            Console.WriteLine("Digite o modelo do seu caminhão: ");
            caminhao.modelo = Console.ReadLine();
            Console.WriteLine("Digite o/a fabricante do seu caminhão: ");
            caminhao.fabricante = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo: ");
            caminhao.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor do seu caminhão: ");
            caminhao.cor = Console.ReadLine();
            Console.WriteLine("Digite o número de portas do seu veículo: ");
            caminhao.numero_portas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de eixos: ");
            caminhao.numero_eixos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a carga máxima:");
            caminhao.maximo_carga = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do caminhão ");
            caminhao.altura = double.Parse(Console.ReadLine());
            caminhao.cadastrado = true;
            Console.Clear();
            return caminhao;
        }
        static void ExibirCarros(Carro[] carros)
        {
            Console.Clear();
            for(int i = 0; i<carros.Length; i++)
            {
                if (carros[i].cadastrado)
                {
                    carros[i].DadosCarro();
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void ExibirCaminhoes(Caminhao[] caminhoes)
        {
            Console.Clear();
            for (int i = 0; i < caminhoes.Length; i++)
            {
                if (caminhoes[i].cadastrado)
                {
                    caminhoes[i].DadosCaminhao();
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}


