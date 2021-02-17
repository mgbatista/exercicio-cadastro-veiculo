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
                }
            } while (escolherMenu != 3);

            Console.ReadKey();
        }

        static void LendoDados(Veiculo v, Proprietario p, Endereco e)
        {
            Console.WriteLine("Informe os dados do veículo:");
            Console.Write("Renavam: ");
            int Renavam = int.Parse(Console.ReadLine());
            Console.Write("Chassi: ");
            int Chassi = int.Parse(Console.ReadLine());
            Console.Write("Placa: ");
            string Placa = Console.ReadLine();
            Console.Write("Marca: ");
            string Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            string Modelo = Console.ReadLine();
            Console.Write("Cor: ");
            string Cor = Console.ReadLine();
            Console.Write("Ano: ");
            int Ano = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            Console.WriteLine("Informe os dados do proprietario:");
            Console.Write("CPF: ");
            string Cpf = Console.ReadLine();
            Console.Write("Nome: ");
            string Nome = Console.ReadLine();
            Console.Write("Data de Nascimento: ");
            string DataNascimento = Console.ReadLine();
            Console.Write("Data da Compra: ");
            string DataCompra = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Informe o endereço do proprietario:");
            Console.Write("Logradouro: ");
            string Logradouro = Console.ReadLine();
            Console.Write("Número: ");
            int Numero = int.Parse(Console.ReadLine());
            Console.Write("Localidade: ");
            string Localidade = Console.ReadLine();
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
