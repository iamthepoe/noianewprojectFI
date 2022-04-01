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
            int optionMenu, meuCarro = 0, meuCaminhao = 0;
            int carrosRegistrados = 0, caminhoesRegistrados = 0;
            bool saiu = false;;
            Carro[] carro = new Carro[300];
            Caminhao[] caminhao = new Caminhao[200];
            for(int i = 0; i<carro.Length; i++) //preenchendo os arrays
            {
                carro[i] = new Carro(" - - - - ", "- - - -", 000000, "- - - -", 000000, "- - - -", 000000, false, false, false);
            }

            for (int i = 0; i < caminhao.Length; i++) //preenchendo os arrays
            {
                caminhao[i] = new Caminhao("- - - -", "- - - -", 000000,"- - - -", 0,"- - - -", 000000, 000000, 000000, false);
            }

            do
            {
                Console.WriteLine("****Menu**** \n 1 - Cadastrar carro \n 2 - Cadastrar caminhão \n 3 - Consultar por placa \n 4 - Consultar caminhão por modelo/marca \n 5 - Consultar carro por cor \n 6 - Exibir todos os carros cadastrados \n 7 - Exibir todos os caminhões cadastrados \n 0 - Sair");
                optionMenu = int.Parse(Console.ReadLine());
                switch (optionMenu)
                {
                    case 0:
                        Console.WriteLine("Deseja mesmo sair? [1 - SIM /2 - NÃO]");
                        int n = int.Parse(Console.ReadLine());
                        saiu = optClose(n);
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
                        break;
                    case 3:
                        ConsultarPorPlaca(caminhao, carro);
                        break;
                    case 4:
                        ConsultarPorModelo(caminhao);
                        break;
                    case 5:
                        ConsultarPorCor(carro);
                    break;

                    case 6:
                        ExibirCarros(carro);
                        break;
                    case 7:
                        ExibirCaminhoes(caminhao);
                        break;
                };
            } while (!saiu);
            Console.ReadKey();
        }
        static bool optClose(int n)
        {
            if (n == 1)
            {
                Console.Clear();
                Console.WriteLine("Me desculpe :( prometo ser melhor da próxima vez!!");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.Clear();
                return false;
            }
        }
        static Carro CadastrarCarro()
        {
            Console.Clear();
            Carro carro = new Carro("", "", 0000, "", 0,"", 0, false, false, false);
            Console.WriteLine("Digite o modelo do seu carro: ");
            carro.modelo = Console.ReadLine();
            Console.WriteLine("Digite o/a fabricante do seu carro: ");
            carro.fabricante = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo: ");
            carro.ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a cor do seu carro: ");
            carro.cor = Console.ReadLine();
            Console.WriteLine("Digite o número de portas do seu veículo: ");
            carro.numero_portas = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a capacidade máxima do porta mala: ");
            carro.capacidadePortaMala = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira a placa: ");
            carro.placa = Console.ReadLine();
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
            Caminhao caminhao = new Caminhao("", "", 0000, "", 0, "",0, 0, 0, false);
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
            Console.WriteLine("Insira a placa: ");
            caminhao.placa = Console.ReadLine();
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
        static void ConsultarPorCor(Carro[] carro)
        {
            string cor = "";
            Console.WriteLine("Insira a cor do carro: ");
            cor = Console.ReadLine();
            for (int c = 0; c < carro.Length; c++)
            {
                if (cor == carro[c].cor)
                {
                    carro[c].DadosCarro();
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void ConsultarPorPlaca(Caminhao[] caminhao, Carro[] carro)
        {
            string placa = "";
            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine();
            for (int c = 0; c < caminhao.Length; c++)
            {
                if (placa == caminhao[c].placa)
                {
                    caminhao[c].DadosCaminhao();
                }
            }

            for (int c = 0; c < carro.Length; c++)
            {
                if (placa == carro[c].placa)
                {
                    carro[c].DadosCarro();
                }
            }
            Console.ReadLine();
            Console.Clear();
        }
        static void ConsultarPorModelo(Caminhao[] caminhao)
        {
            string ModeloMarca = "";
            Console.Write("Digite o modelo/marca do veículo: ");
            ModeloMarca = Console.ReadLine();
            for (int c = 0; c<caminhao.Length; c++)
            {
                if (ModeloMarca == caminhao[c].modelo)
                {
                    caminhao[c].DadosCaminhao();
                }
            }
            Console.ReadLine();
            Console.Clear();
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


