using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_POO
{
    internal class Medico
    {
        string nome;
        string cpf;
        string especialidade;
        string telefone;

        public Medico()
        {
        }

        public Medico(string _nome, string _cpf, string _especialidade, string _telefone)
        {
            nome = _nome;
            cpf = _cpf;
            especialidade = _especialidade;
            telefone = _telefone;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
