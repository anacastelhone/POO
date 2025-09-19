using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Final_POO
{
    internal class Consulta
    {
        int id;
        string pacienteCpf;
        string medicoCpf;
        DateTime data;
        TimeSpan horario;

        public Consulta()
        {
        }

        public Consulta(string _pacienteCpf, string _medicoCpf, DateTime _data, TimeSpan _horario)
        {
            pacienteCpf = _pacienteCpf;
            medicoCpf = _medicoCpf;
            data = _data;
            horario = _horario;
        }

        public int Id { get => id; set => id = value; }
        public string PacienteCpf { get => pacienteCpf; set => pacienteCpf = value; }
        public string MedicoCpf { get => medicoCpf; set => medicoCpf = value; }
        public DateTime Data { get => data; set => data = value; }
        public TimeSpan Horario { get => horario; set => horario = value; }
    }
}
