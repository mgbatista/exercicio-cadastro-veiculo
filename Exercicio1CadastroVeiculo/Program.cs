using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1CadastroVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo v = new Veiculo();
            Proprietario p = new Proprietario();
            Endereco e = new Endereco();

            int escolherMenu = 0;


            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine("\n1- Informar todos os dados.");
                Console.WriteLine("2- Imprimir dados.");
                Console.WriteLine("3- Finalizar programa.");

                Console.WriteLine("\nEscolha uma das opções acima:");
                escolherMenu = int.Parse(Console.ReadLine());

                Console.WriteLine("");

                switch (escolherMenu)
                {
                    case 1:
                        LendoDados(v, p, e);
                        break;
                    case 2:
                        ImprimirDados(v, p, e);
                        break;
                    case 3:
                        Console.WriteLine("Pressione qualquer tecla para fechar o programa!");
                        break;
                }
            } while (escolherMenu != 3);

            Console.ReadKey();
        }

        static void LendoDados(Veiculo v, Proprietario p, Endereco e)
        {
            Console.WriteLine("Informe os dados do veículo:");
            Console.Write("Renavam: ");
            v.Renavam = int.Parse(Console.ReadLine());
            Console.Write("Chassi: ");
            v.Chassi = int.Parse(Console.ReadLine());
            Console.Write("Placa: ");
            v.Placa = Console.ReadLine();
            Console.Write("Marca: ");
            v.Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            v.Modelo = Console.ReadLine();
            Console.Write("Cor: ");
            v.Cor = Console.ReadLine();
            Console.Write("Ano: ");
            v.Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe os dados do proprietario:");
            Console.Write("CPF: ");
            p.Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            p.DataNascimento = Console.ReadLine();
            Console.Write("Data da Compra: ");
            p.DataCompra = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Informe o endereço do proprietario:");
            Console.Write("Logradouro: ");
            e.Logradouro = Console.ReadLine();
            Console.Write("Número: ");
            e.Numero = int.Parse(Console.ReadLine());
            Console.Write("Localidade: ");
            e.Localidade = Console.ReadLine();
            Console.WriteLine("");
        }


        static void ImprimirDados(Veiculo v, Proprietario p, Endereco e)
        {
            Console.WriteLine(v.ToString());
            Console.WriteLine("");
            Console.WriteLine(p.ToString());
            Console.WriteLine("");
            Console.WriteLine(e.ToString());

        }
        
    }
}
