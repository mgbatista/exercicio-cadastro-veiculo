using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1CadastroVeiculo
{
    public class Veiculo
    {
        public int Renavam { get; set; }
        public int Chassi { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

       

        public override string ToString()
        {
            return ("Renavam: " + Renavam + "\nChassi: " + Chassi + "\nPlaca: " + Placa + "\nMarca: " + Marca + "\nModelo: " + Modelo + "\nCor: " + Cor + "\nAno: " + Ano);
        }

    }
}
