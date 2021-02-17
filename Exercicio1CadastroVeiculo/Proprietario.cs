using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1CadastroVeiculo
{
    public class Proprietario
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string DataCompra { get; set; }

       

        public override string ToString()
        {
            return ("CPF: " + Cpf + "\nNome: " + Nome + "\nData de Nascimento: " + DataNascimento + "\nData da Compra: " + DataCompra);
        }


    }
}

