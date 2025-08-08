using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal class Onibus : Veiculo
    {
        double assento;

        public Onibus(string nome, int anoAtual, int anoVeiculo, double assento) : base(nome, anoAtual, anoVeiculo)
        {
            this.Assento= assento;
        }

        public double Assento { get => assento; set => assento = value; }

        public override double diaria()
        {
            return (30 * assento) - (AnoAtual - AnoVeiculo) * 70;
        }
    }
}

