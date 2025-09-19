using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Final_POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            tbNomeP.Text = string.Empty;
            mtbCpfP.Text = string.Empty;
            mtbTelefoneP.Text = string.Empty;
            mtbDatadenascimento.Text = string.Empty;

            tbNomeM.Text = string.Empty;
            mtbCpfMe.Text = string.Empty;
            tbEspecialidade.Text = string.Empty;
            mtbTelefoneM.Text = string.Empty;

            mtbcpfpaciente.Text = string.Empty;
            mtbcpfmedico.Text = string.Empty;
            mtbDataConsulta.Text = string.Empty;
            cbHorario.Text = string.Empty;
        }

        private void btGravarP_Click(object sender, EventArgs e)
        {
            try
            {
                // Converte a data antes de passar para o objeto
                DateTime dataNascimento = DateTime.ParseExact(mtbDatadenascimento.Text, "dd/MM/yyyy", null);

                Paciente paciente = new Paciente(
                    tbNomeP.Text,
                    mtbCpfP.Text,
                    mtbTelefoneP.Text,
                    mtbDatadenascimento.Text
                );

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "INSERT INTO clinica.pacientes (nome, cpf, data_nascimento, telefone) " +
                                     "VALUES (@nome, @cpf, @dn, @tel)";

                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                        cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                        cmd.Parameters.AddWithValue("@dn", dataNascimento);
                        cmd.Parameters.AddWithValue("@tel", paciente.Telefone);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Paciente cadastrado com sucesso!");
                Limpar();
                btRelatorioP_Click(null, null); 
            }
            catch (NpgsqlException)
            {
                MessageBox.Show("Erro: CPF já cadastrado.");
            }
            catch (FormatException)
            {
                MessageBox.Show("Erro de formato. Verifique se a data está no formato dd/mm/aaaa.");
            }
        }

        private void btAtualizarP_Click(object sender, EventArgs e)
        {
            try
            {
                
                Paciente paciente = new Paciente(
                    tbNomeP.Text,
                    mtbCpfP.Text,
                    mtbTelefoneP.Text,
                    mtbDatadenascimento.Text
                );

                // Converte a data antes de passar para o objeto
                DateTime dataNascimento = DateTime.ParseExact(mtbDatadenascimento.Text, "dd/MM/yyyy", null);

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "UPDATE clinica.pacientes SET nome=@nome, data_nascimento=@dn, telefone=@tel " +
                                     "WHERE cpf=@cpf";

                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@nome", paciente.Nome);
                        cmd.Parameters.AddWithValue("@cpf", paciente.Cpf);
                        cmd.Parameters.AddWithValue("@dn", dataNascimento);
                        cmd.Parameters.AddWithValue("@tel", paciente.Telefone);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Paciente atualizado!");
                Limpar();
                btRelatorioP_Click(null, null); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar paciente: " + ex.Message);
            }
        }

        private void btDeletarP_Click(object sender, EventArgs e)
        {

            // Verifica se uma linha foi selecionada no DataGridView
            if (dgvP.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtém o CPF da linha selecionada no DataGridView
                    string cpfPaciente = dgvP.SelectedRows[0].Cells["cpf"].Value.ToString();

                    string conexao = new ConexaoString().ConnString();
                    using (var connect = new NpgsqlConnection(conexao))
                    {
                        connect.Open();
                        string comando = "DELETE FROM clinica.pacientes WHERE cpf=@cpf";

                        using (var cmd = new NpgsqlCommand(comando, connect))
                        {
                            cmd.Parameters.AddWithValue("@cpf", cpfPaciente);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Paciente excluído com sucesso!");
                    Limpar();
                    btRelatorioP_Click(null, null); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir paciente: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um paciente para excluir.");
            }
        }

        private void btRelatorioP_Click(object sender, EventArgs e)
        {
            string conexao = new ConexaoString().ConnString();
            using (var connect = new NpgsqlConnection(conexao))
            {
                connect.Open();
                DataTable dt = new DataTable();
                string comando = "SELECT nome, cpf, data_nascimento, telefone FROM clinica.pacientes";
                using (NpgsqlDataAdapter adpt = new NpgsqlDataAdapter(comando, conexao))
                {
                    adpt.Fill(dt);
                }
                dgvP.DataSource = dt;
            }
        }

        private void btSairP_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGravarM_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico(
                    tbNomeM.Text,
                    mtbCpfMe.Text,
                    tbEspecialidade.Text,
                    mtbTelefoneM.Text
                );

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "INSERT INTO clinica.medicos (nome, cpf, especialidade, telefone) " +
                                     "VALUES (@nome, @cpf, @esp, @tel)";

                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@nome", medico.Nome);
                        cmd.Parameters.AddWithValue("@cpf", medico.Cpf);
                        cmd.Parameters.AddWithValue("@esp", medico.Especialidade);
                        cmd.Parameters.AddWithValue("@tel", medico.Telefone);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Médico cadastrado!");
                Limpar();
                btRelatórioM_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar médico: " + ex.Message);
            }
        }

        private void btAtualizarM_Click(object sender, EventArgs e)
        {
            try
            {
                Medico medico = new Medico(
                    tbNomeM.Text,
                    mtbCpfMe.Text,
                    tbEspecialidade.Text,
                    mtbTelefoneM.Text
                );

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "UPDATE clinica.medicos SET nome=@nome, especialidade=@esp, telefone=@tel WHERE cpf=@cpf";

                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@nome", medico.Nome);
                        cmd.Parameters.AddWithValue("@cpf", medico.Cpf);
                        cmd.Parameters.AddWithValue("@esp", medico.Especialidade);
                        cmd.Parameters.AddWithValue("@tel", medico.Telefone);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Médico atualizado!");
                Limpar();
                btRelatórioM_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar médico: " + ex.Message);
            }
        }

        private void btDeletarM_Click(object sender, EventArgs e)
        {
            // Verifica se uma linha foi selecionada no DataGridView
            if (dgvM.SelectedRows.Count > 0)
            {
                try
                {
                    // Obtém o CPF da linha selecionada no DataGridView
                    string cpfMedico = dgvM.SelectedRows[0].Cells["cpf"].Value.ToString();

                    string conexao = new ConexaoString().ConnString();
                    using (var connect = new NpgsqlConnection(conexao))
                    {
                        connect.Open();
                        string comando = "DELETE FROM clinica.medicos WHERE cpf=@cpf";

                        using (var cmd = new NpgsqlCommand(comando, connect))
                        {
                            cmd.Parameters.AddWithValue("@cpf", cpfMedico);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Médico excluído com sucesso!");
                    Limpar();
                    btRelatórioM_Click(null, null); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir médico: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione um médico para excluir.");
            }
        }

        private void btRelatórioM_Click(object sender, EventArgs e)
        {
            string conexao = new ConexaoString().ConnString();
            using (var connect = new NpgsqlConnection(conexao))
            {
                connect.Open();
                DataTable dt = new DataTable();
                string comando = "SELECT * FROM clinica.medicos ORDER BY nome";
                using (NpgsqlDataAdapter adpt = new NpgsqlDataAdapter(comando, conexao))
                {
                    adpt.Fill(dt);
                }
                dgvM.DataSource = dt;
            }
        }

        private void btSairM_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btGravarC_Click(object sender, EventArgs e)
        {

            try
            {
                Consulta consulta = new Consulta(
                    mtbcpfpaciente.Text,
                    mtbcpfmedico.Text,
                    DateTime.ParseExact(mtbDataConsulta.Text, "dd/MM/yyyy", null),
                    TimeSpan.Parse(cbHorario.Text)
                );

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "INSERT INTO clinica.consultas (paciente_cpf, medico_cpf, data, horario) " +
                                     "VALUES (@pcpf, @mcpf, @data, @horario)";
                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@pcpf", consulta.PacienteCpf);
                        cmd.Parameters.AddWithValue("@mcpf", consulta.MedicoCpf);
                        cmd.Parameters.AddWithValue("@data", consulta.Data);
                        cmd.Parameters.AddWithValue("@horario", consulta.Horario);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Consulta cadastrada com sucesso!");
                Limpar();
                btRelatorioC_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar consulta: " + ex.Message);
            }
        }

        private void btAtualizarC_Click(object sender, EventArgs e)
        {
            try
            {
                Consulta consulta = new Consulta(
                 mtbcpfpaciente.Text,
                 mtbcpfmedico.Text,
                 DateTime.ParseExact(mtbDataConsulta.Text, "dd/MM/yyyy", null),
                 TimeSpan.Parse(cbHorario.Text)
                 );

                string conexao = new ConexaoString().ConnString();
                using (var connect = new NpgsqlConnection(conexao))
                {
                    connect.Open();
                    string comando = "UPDATE clinica.consultas SET data=@data, horario=@horario " +
                                     "WHERE paciente_cpf=@pcpf AND medico_cpf=@mcpf";

                    using (var cmd = new NpgsqlCommand(comando, connect))
                    {
                        cmd.Parameters.AddWithValue("@pcpf", consulta.PacienteCpf);
                        cmd.Parameters.AddWithValue("@mcpf", consulta.MedicoCpf);
                        cmd.Parameters.AddWithValue("@data", consulta.Data);
                        cmd.Parameters.AddWithValue("@horario", consulta.Horario);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Consulta atualizada com sucesso!");
                Limpar();
                btRelatorioC_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar consulta: " + ex.Message);
            }
        }

        private void btDeletarC_Click(object sender, EventArgs e)
        {
            if (dgvC.SelectedRows.Count > 0)
            {
                try
                {
                    int idConsulta = Convert.ToInt32(dgvC.SelectedRows[0].Cells["id"].Value);

                    string conexao = new ConexaoString().ConnString();
                    using (var connect = new NpgsqlConnection(conexao))
                    {
                        connect.Open();
                        string comando = "DELETE FROM clinica.consultas WHERE id = @id";
                        using (var cmd = new NpgsqlCommand(comando, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", idConsulta);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Consulta excluída com sucesso!");
                    Limpar();
                    btRelatorioC_Click(null, null);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir consulta: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma consulta para excluir.");
            }
        }

        private void btRelatorioC_Click(object sender, EventArgs e)
        {
            string conexao = new ConexaoString().ConnString();
            using (var connect = new NpgsqlConnection(conexao))
            {
                connect.Open();
                DataTable dt = new DataTable();
                string comando = "SELECT c.id, c.data, c.horario, p.nome as paciente, m.nome as medico " +
                                 "FROM clinica.consultas c JOIN clinica.pacientes p ON c.paciente_cpf = p.cpf " +
                                 "JOIN clinica.medicos m ON c.medico_cpf = m.cpf ORDER BY c.data";
                using (NpgsqlDataAdapter adpt = new NpgsqlDataAdapter(comando, conexao))
                {
                    adpt.Fill(dt);
                }
                dgvC.DataSource = dt;
            }
        }

        private void btSairC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}