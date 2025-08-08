using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCalcular_Click(object sender, EventArgs e)
        {
            if(rbcaminhao.Checked)
            {
                String placa = tbplaca.Text;
                int anoAtual=int.Parse(tbanoa.Text);
                int anoVeiculo=int .Parse(tbanov.Text);
                double eixo = double.Parse(tbassentos.Text);
                Caminhao cam = new Caminhao("Caminhão",placa, anoAtual, anoVeiculo, eixo);

                string[] item = new string[]
                {
                    cam.Nome,
                    cam.Placa,
                    cam.AnoVeiculo.ToString(),
                    cam.AnoAtual.ToString(),
                    cam.diaria().ToString("F2")
                };

                ListVeiculos.Items.Add(new ListViewItem(item));
            }
            else if (rbonibus.Checked)
            {
                string placa = tbplaca.Text;
                int anoAtual = int.Parse(tbanoa.Text);
                int anoVeiculo = int.Parse(tbanov.Text);
                double assento = double.Parse(tbassentos.Text);
                Onibus oni = new Onibus("Ônibus",placa, anoAtual, anoVeiculo, assento);

                string[] item = new string[]
                {
                    oni.Nome,
                    oni.Placa,
                    oni.AnoVeiculo.ToString(),
                    oni.AnoAtual.ToString(),
                    oni.diaria().ToString("F2")
                };

                ListVeiculos.Items.Add(new ListViewItem(item));
            }
        }

        private void rbonibus_CheckedChanged(object sender, EventArgs e)
        {
            lbassentos.Text = "Assentos:";
        }

        private void rbcaminhao_CheckedChanged(object sender, EventArgs e)
        {
            lbassentos.Text = "Eixos:";
        }
    }
}


