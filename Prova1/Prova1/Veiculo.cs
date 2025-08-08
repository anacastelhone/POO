using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    internal abstract class Veiculo
    {
        private string nome;
        private int anoAtual;
        private int anoVeiculo;

        public string Nome { get => nome; set => nome = value; }
        public int AnoAtual { get => anoAtual; set => anoAtual = value; }

        public int AnoVeiculo { get => anoVeiculo; set => anoVeiculo = value; }

        protected Veiculo(string nome, int anoAtual , int anoVeiculo)
        {
            this.Nome = nome;
            this.AnoAtual = anoAtual ;
            this.AnoVeiculo=anoVeiculo;
        }

        public abstract double diaria();

    }
}
