using System;
using System.Data;
using System.Globalization;

namespace EmpresaOnibusTurismo { 
    class Program
    {
        static void Main() {

            //necessária a pré-inicialização das variáveis, pois ao compilar estava dando erro sem a pré-inicialização
            int ano = 0;
            string nome = "";
            int telefone = 0;
            string email = "";
            double precoPassagem = 0;
            double taxaEmbarque = 0.0;
            double porcentagemPromocao = 0.0;
            double valorPromocao = 0.0;

            while (true)
            {
                Console.WriteLine("=====================================================");
                Console.WriteLine("MENU DO SISTEMA!");
                Console.WriteLine("=====================================================");
                Console.WriteLine("Digite 1 - Acessar painel de configuração do sistema");
                Console.WriteLine("Digite 2 - Exibir a tela de informações ao cliente ");
                int op = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (op) {
                    case 1:
                        Console.WriteLine("=====================================================");
                        Console.WriteLine("INICIALIZANDO... CONFIGURE O SISTEMA!");
                        Console.WriteLine("=====================================================");
                        Console.WriteLine("\nInforme o ano atual: ");
                        ano = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme o nome da empresa: ");
                        nome = Console.ReadLine();
                        Console.WriteLine("\nInforme o telefone: ");
                        telefone = int.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme o e-mail: ");
                        email = Console.ReadLine();
                        Console.WriteLine("\nInforme o preço da passagem: ");
                        precoPassagem = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme o preço da taxa para embarque: ");
                        taxaEmbarque = double.Parse(Console.ReadLine());
                        Console.WriteLine("\nInforme uma porcentagem promocional: ");
                        porcentagemPromocao = double.Parse(Console.ReadLine());
                        valorPromocao = CalculatePercentage(porcentagemPromocao, precoPassagem, taxaEmbarque);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("=====================================================");
                        Console.WriteLine("SISTEMA PARA EMPRESA DE ÔNIBUS - Ano atual: " + ano);
                        Console.WriteLine("=====================================================");
                        Console.WriteLine("\nBem-Vindo a " + nome + "!");
                        Console.WriteLine("\nCompre suas passagens pelo telefone: " + telefone);
                        Console.WriteLine("\nOu entre em contato pelo e-mail: " + email);
                        Console.WriteLine("\nPreço da passagem: R$" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", precoPassagem));
                        Console.WriteLine("\nPreço da taxa para embarque: R$" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", taxaEmbarque));
                        Console.WriteLine("\nPreço da passagem com a taxa para embarque e sem promoção: R$" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", (precoPassagem + taxaEmbarque)));
                        Console.WriteLine("\nValor da promoção: R$" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", valorPromocao)); 
                        Console.WriteLine("\nTotal a ser pago: R$" + string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:0,0.00}", ((precoPassagem+taxaEmbarque) - valorPromocao)));
                        Console.WriteLine("\n=====================================================");
                        Console.WriteLine("Construído por 'Empresa Bem Legal'");
                        Console.WriteLine("=====================================================");
                        Console.WriteLine("\nPressione a tecla enter para voltar ao menu...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("\nA opção selecionada não é válida!\n");
                        Console.WriteLine("\nPressione a tecla enter para voltar ao menu...");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        private static double CalculatePercentage(double porcentagemPromocao, double precoPassagem, double taxaEmbarque) {

            return (porcentagemPromocao / 100) * (precoPassagem + taxaEmbarque);

        }
    }
}