using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_POO
{
    internal class Paciente
    {
        string nome;
        string cpf;
        string telefone; 
        string dataNascimento; 

        public Paciente()
        {
        }

        public Paciente(string _nome, string _cpf, string _telefone, string _dataNascimento)
        {
            nome = _nome;
            cpf = _cpf;
            telefone = _telefone;
            dataNascimento = _dataNascimento;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string DataNascimento { get => dataNascimento; set => dataNascimento = value; }
    }
}
