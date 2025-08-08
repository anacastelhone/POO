using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Caminhao : Veiculo
    {
        double eixo;

        public Caminhao(string nome, int anoAtual, int anoVeiculo, double eixo) : base(nome, anoAtual, anoVeiculo)
        {
            this.Eixo = eixo;
        }

        public double Eixo { get =>eixo; set => eixo = value; }

        public override double diaria()
        {
            return (300 *eixo) - (AnoAtual -AnoVeiculo) * 50;
        }
    }
}
