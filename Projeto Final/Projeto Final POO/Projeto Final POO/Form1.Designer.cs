namespace Projeto_Final_POO
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPacientes = new System.Windows.Forms.TabPage();
            this.btAtualizarP = new System.Windows.Forms.Button();
            this.mtbTelefoneP = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mtbDatadenascimento = new System.Windows.Forms.MaskedTextBox();
            this.dgvP = new System.Windows.Forms.DataGridView();
            this.btSairP = new System.Windows.Forms.Button();
            this.btDeletarP = new System.Windows.Forms.Button();
            this.btRelatorioP = new System.Windows.Forms.Button();
            this.btGravarP = new System.Windows.Forms.Button();
            this.mtbCpfP = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbCpfM = new System.Windows.Forms.TabPage();
            this.mtbTelefoneM = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btAtualizarM = new System.Windows.Forms.Button();
            this.btSairM = new System.Windows.Forms.Button();
            this.btRelatórioM = new System.Windows.Forms.Button();
            this.btDeletarM = new System.Windows.Forms.Button();
            this.btGravarM = new System.Windows.Forms.Button();
            this.mtbCpfMe = new System.Windows.Forms.MaskedTextBox();
            this.tbNomeM = new System.Windows.Forms.TextBox();
            this.tbEspecialidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvM = new System.Windows.Forms.DataGridView();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.mtbcpfmedico = new System.Windows.Forms.MaskedTextBox();
            this.mtbcpfpaciente = new System.Windows.Forms.MaskedTextBox();
            this.btAtualizarC = new System.Windows.Forms.Button();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.mtbDataConsulta = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btSairC = new System.Windows.Forms.Button();
            this.btRelatorioC = new System.Windows.Forms.Button();
            this.btDeletarC = new System.Windows.Forms.Button();
            this.btGravarC = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvC = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).BeginInit();
            this.mtbCpfM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).BeginInit();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPacientes);
            this.tabControl1.Controls.Add(this.mtbCpfM);
            this.tabControl1.Controls.Add(this.tabConsulta);
            this.tabControl1.Location = new System.Drawing.Point(1, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(787, 443);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPacientes
            // 
            this.tabPacientes.Controls.Add(this.btAtualizarP);
            this.tabPacientes.Controls.Add(this.mtbTelefoneP);
            this.tabPacientes.Controls.Add(this.label10);
            this.tabPacientes.Controls.Add(this.mtbDatadenascimento);
            this.tabPacientes.Controls.Add(this.dgvP);
            this.tabPacientes.Controls.Add(this.btSairP);
            this.tabPacientes.Controls.Add(this.btDeletarP);
            this.tabPacientes.Controls.Add(this.btRelatorioP);
            this.tabPacientes.Controls.Add(this.btGravarP);
            this.tabPacientes.Controls.Add(this.mtbCpfP);
            this.tabPacientes.Controls.Add(this.tbNomeP);
            this.tabPacientes.Controls.Add(this.label1);
            this.tabPacientes.Controls.Add(this.label2);
            this.tabPacientes.Controls.Add(this.label3);
            this.tabPacientes.Location = new System.Drawing.Point(4, 25);
            this.tabPacientes.Name = "tabPacientes";
            this.tabPacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPacientes.Size = new System.Drawing.Size(779, 414);
            this.tabPacientes.TabIndex = 0;
            this.tabPacientes.Text = "Pacientes";
            this.tabPacientes.UseVisualStyleBackColor = true;
            // 
            // btAtualizarP
            // 
            this.btAtualizarP.Location = new System.Drawing.Point(141, 189);
            this.btAtualizarP.Name = "btAtualizarP";
            this.btAtualizarP.Size = new System.Drawing.Size(76, 24);
            this.btAtualizarP.TabIndex = 60;
            this.btAtualizarP.Text = "Atualizar";
            this.btAtualizarP.UseVisualStyleBackColor = true;
            this.btAtualizarP.Click += new System.EventHandler(this.btAtualizarP_Click);
            // 
            // mtbTelefoneP
            // 
            this.mtbTelefoneP.Location = new System.Drawing.Point(154, 136);
            this.mtbTelefoneP.Mask = "(00) 00000-0000";
            this.mtbTelefoneP.Name = "mtbTelefoneP";
            this.mtbTelefoneP.Size = new System.Drawing.Size(110, 22);
            this.mtbTelefoneP.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 16);
            this.label10.TabIndex = 58;
            this.label10.Text = "Data de nascimento:";
            // 
            // mtbDatadenascimento
            // 
            this.mtbDatadenascimento.Location = new System.Drawing.Point(154, 102);
            this.mtbDatadenascimento.Mask = "00/00/0000";
            this.mtbDatadenascimento.Name = "mtbDatadenascimento";
            this.mtbDatadenascimento.Size = new System.Drawing.Size(90, 22);
            this.mtbDatadenascimento.TabIndex = 57;
            this.mtbDatadenascimento.ValidatingType = typeof(System.DateTime);
            // 
            // dgvP
            // 
            this.dgvP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvP.Location = new System.Drawing.Point(46, 219);
            this.dgvP.Name = "dgvP";
            this.dgvP.RowHeadersWidth = 51;
            this.dgvP.RowTemplate.Height = 24;
            this.dgvP.Size = new System.Drawing.Size(679, 178);
            this.dgvP.TabIndex = 31;
            // 
            // btSairP
            // 
            this.btSairP.Location = new System.Drawing.Point(698, 6);
            this.btSairP.Name = "btSairP";
            this.btSairP.Size = new System.Drawing.Size(75, 23);
            this.btSairP.TabIndex = 30;
            this.btSairP.Text = "Sair";
            this.btSairP.UseVisualStyleBackColor = true;
            this.btSairP.Click += new System.EventHandler(this.btSairP_Click);
            // 
            // btDeletarP
            // 
            this.btDeletarP.Location = new System.Drawing.Point(240, 189);
            this.btDeletarP.Name = "btDeletarP";
            this.btDeletarP.Size = new System.Drawing.Size(75, 23);
            this.btDeletarP.TabIndex = 29;
            this.btDeletarP.Text = "Deletar";
            this.btDeletarP.UseVisualStyleBackColor = true;
            this.btDeletarP.Click += new System.EventHandler(this.btDeletarP_Click);
            // 
            // btRelatorioP
            // 
            this.btRelatorioP.Location = new System.Drawing.Point(605, 189);
            this.btRelatorioP.Name = "btRelatorioP";
            this.btRelatorioP.Size = new System.Drawing.Size(120, 23);
            this.btRelatorioP.TabIndex = 28;
            this.btRelatorioP.Text = " Gerar Relatório";
            this.btRelatorioP.UseVisualStyleBackColor = true;
            this.btRelatorioP.Click += new System.EventHandler(this.btRelatorioP_Click);
            // 
            // btGravarP
            // 
            this.btGravarP.Location = new System.Drawing.Point(46, 190);
            this.btGravarP.Name = "btGravarP";
            this.btGravarP.Size = new System.Drawing.Size(75, 23);
            this.btGravarP.TabIndex = 26;
            this.btGravarP.Text = "Gravar";
            this.btGravarP.UseVisualStyleBackColor = true;
            this.btGravarP.Click += new System.EventHandler(this.btGravarP_Click);
            // 
            // mtbCpfP
            // 
            this.mtbCpfP.Location = new System.Drawing.Point(154, 70);
            this.mtbCpfP.Mask = "000,000,000-00";
            this.mtbCpfP.Name = "mtbCpfP";
            this.mtbCpfP.Size = new System.Drawing.Size(120, 22);
            this.mtbCpfP.TabIndex = 25;
            // 
            // tbNomeP
            // 
            this.tbNomeP.Location = new System.Drawing.Point(154, 33);
            this.tbNomeP.Name = "tbNomeP";
            this.tbNomeP.Size = new System.Drawing.Size(312, 22);
            this.tbNomeP.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nome:";
            // 
            // mtbCpfM
            // 
            this.mtbCpfM.Controls.Add(this.mtbTelefoneM);
            this.mtbCpfM.Controls.Add(this.label11);
            this.mtbCpfM.Controls.Add(this.btAtualizarM);
            this.mtbCpfM.Controls.Add(this.btSairM);
            this.mtbCpfM.Controls.Add(this.btRelatórioM);
            this.mtbCpfM.Controls.Add(this.btDeletarM);
            this.mtbCpfM.Controls.Add(this.btGravarM);
            this.mtbCpfM.Controls.Add(this.mtbCpfMe);
            this.mtbCpfM.Controls.Add(this.tbNomeM);
            this.mtbCpfM.Controls.Add(this.tbEspecialidade);
            this.mtbCpfM.Controls.Add(this.label4);
            this.mtbCpfM.Controls.Add(this.label5);
            this.mtbCpfM.Controls.Add(this.label6);
            this.mtbCpfM.Controls.Add(this.dgvM);
            this.mtbCpfM.Location = new System.Drawing.Point(4, 25);
            this.mtbCpfM.Name = "mtbCpfM";
            this.mtbCpfM.Padding = new System.Windows.Forms.Padding(3);
            this.mtbCpfM.Size = new System.Drawing.Size(779, 414);
            this.mtbCpfM.TabIndex = 1;
            this.mtbCpfM.Text = "Médicos";
            this.mtbCpfM.UseVisualStyleBackColor = true;
            // 
            // mtbTelefoneM
            // 
            this.mtbTelefoneM.Location = new System.Drawing.Point(126, 133);
            this.mtbTelefoneM.Mask = "(00) 00000-0000";
            this.mtbTelefoneM.Name = "mtbTelefoneM";
            this.mtbTelefoneM.Size = new System.Drawing.Size(110, 22);
            this.mtbTelefoneM.TabIndex = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Telefone:";
            // 
            // btAtualizarM
            // 
            this.btAtualizarM.Location = new System.Drawing.Point(126, 192);
            this.btAtualizarM.Name = "btAtualizarM";
            this.btAtualizarM.Size = new System.Drawing.Size(75, 23);
            this.btAtualizarM.TabIndex = 43;
            this.btAtualizarM.Text = "Atualizar";
            this.btAtualizarM.UseVisualStyleBackColor = true;
            this.btAtualizarM.Click += new System.EventHandler(this.btAtualizarM_Click);
            // 
            // btSairM
            // 
            this.btSairM.Location = new System.Drawing.Point(683, 15);
            this.btSairM.Name = "btSairM";
            this.btSairM.Size = new System.Drawing.Size(75, 23);
            this.btSairM.TabIndex = 42;
            this.btSairM.Text = "Sair";
            this.btSairM.UseVisualStyleBackColor = true;
            this.btSairM.Click += new System.EventHandler(this.btSairM_Click);
            // 
            // btRelatórioM
            // 
            this.btRelatórioM.Location = new System.Drawing.Point(591, 192);
            this.btRelatórioM.Name = "btRelatórioM";
            this.btRelatórioM.Size = new System.Drawing.Size(126, 23);
            this.btRelatórioM.TabIndex = 41;
            this.btRelatórioM.Text = "Gerar Relatório";
            this.btRelatórioM.UseVisualStyleBackColor = true;
            this.btRelatórioM.Click += new System.EventHandler(this.btRelatórioM_Click);
            // 
            // btDeletarM
            // 
            this.btDeletarM.Location = new System.Drawing.Point(216, 192);
            this.btDeletarM.Name = "btDeletarM";
            this.btDeletarM.Size = new System.Drawing.Size(75, 23);
            this.btDeletarM.TabIndex = 40;
            this.btDeletarM.Text = "Deletar";
            this.btDeletarM.UseVisualStyleBackColor = true;
            this.btDeletarM.Click += new System.EventHandler(this.btDeletarM_Click);
            // 
            // btGravarM
            // 
            this.btGravarM.Location = new System.Drawing.Point(39, 192);
            this.btGravarM.Name = "btGravarM";
            this.btGravarM.Size = new System.Drawing.Size(75, 23);
            this.btGravarM.TabIndex = 39;
            this.btGravarM.Text = "Gravar";
            this.btGravarM.UseVisualStyleBackColor = true;
            this.btGravarM.Click += new System.EventHandler(this.btGravarM_Click);
            // 
            // mtbCpfMe
            // 
            this.mtbCpfMe.Location = new System.Drawing.Point(126, 63);
            this.mtbCpfMe.Mask = "000,000,000-00";
            this.mtbCpfMe.Name = "mtbCpfMe";
            this.mtbCpfMe.Size = new System.Drawing.Size(120, 22);
            this.mtbCpfMe.TabIndex = 38;
            // 
            // tbNomeM
            // 
            this.tbNomeM.Location = new System.Drawing.Point(126, 30);
            this.tbNomeM.Name = "tbNomeM";
            this.tbNomeM.Size = new System.Drawing.Size(312, 22);
            this.tbNomeM.TabIndex = 37;
            // 
            // tbEspecialidade
            // 
            this.tbEspecialidade.Location = new System.Drawing.Point(126, 94);
            this.tbEspecialidade.Name = "tbEspecialidade";
            this.tbEspecialidade.Size = new System.Drawing.Size(150, 22);
            this.tbEspecialidade.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "CPF:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 34;
            this.label5.Text = "Especialidade:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "Nome:";
            // 
            // dgvM
            // 
            this.dgvM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvM.Location = new System.Drawing.Point(39, 221);
            this.dgvM.Name = "dgvM";
            this.dgvM.RowHeadersWidth = 51;
            this.dgvM.RowTemplate.Height = 24;
            this.dgvM.Size = new System.Drawing.Size(678, 187);
            this.dgvM.TabIndex = 32;
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.mtbcpfmedico);
            this.tabConsulta.Controls.Add(this.mtbcpfpaciente);
            this.tabConsulta.Controls.Add(this.btAtualizarC);
            this.tabConsulta.Controls.Add(this.cbHorario);
            this.tabConsulta.Controls.Add(this.mtbDataConsulta);
            this.tabConsulta.Controls.Add(this.label8);
            this.tabConsulta.Controls.Add(this.btSairC);
            this.tabConsulta.Controls.Add(this.btRelatorioC);
            this.tabConsulta.Controls.Add(this.btDeletarC);
            this.tabConsulta.Controls.Add(this.btGravarC);
            this.tabConsulta.Controls.Add(this.label7);
            this.tabConsulta.Controls.Add(this.lbData);
            this.tabConsulta.Controls.Add(this.label9);
            this.tabConsulta.Controls.Add(this.dgvC);
            this.tabConsulta.Location = new System.Drawing.Point(4, 25);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Size = new System.Drawing.Size(779, 414);
            this.tabConsulta.TabIndex = 2;
            this.tabConsulta.Text = "Consultas";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // mtbcpfmedico
            // 
            this.mtbcpfmedico.Location = new System.Drawing.Point(214, 72);
            this.mtbcpfmedico.Mask = "000,000,000-00";
            this.mtbcpfmedico.Name = "mtbcpfmedico";
            this.mtbcpfmedico.Size = new System.Drawing.Size(120, 22);
            this.mtbcpfmedico.TabIndex = 61;
            // 
            // mtbcpfpaciente
            // 
            this.mtbcpfpaciente.Location = new System.Drawing.Point(214, 33);
            this.mtbcpfpaciente.Mask = "000,000,000-00";
            this.mtbcpfpaciente.Name = "mtbcpfpaciente";
            this.mtbcpfpaciente.Size = new System.Drawing.Size(120, 22);
            this.mtbcpfpaciente.TabIndex = 60;
            // 
            // btAtualizarC
            // 
            this.btAtualizarC.Location = new System.Drawing.Point(119, 195);
            this.btAtualizarC.Name = "btAtualizarC";
            this.btAtualizarC.Size = new System.Drawing.Size(78, 23);
            this.btAtualizarC.TabIndex = 59;
            this.btAtualizarC.Text = "Atualizar";
            this.btAtualizarC.UseVisualStyleBackColor = true;
            this.btAtualizarC.Click += new System.EventHandler(this.btAtualizarC_Click);
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00"});
            this.cbHorario.Location = new System.Drawing.Point(213, 143);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 24);
            this.cbHorario.TabIndex = 57;
            // 
            // mtbDataConsulta
            // 
            this.mtbDataConsulta.Location = new System.Drawing.Point(213, 105);
            this.mtbDataConsulta.Mask = "00/00/0000";
            this.mtbDataConsulta.Name = "mtbDataConsulta";
            this.mtbDataConsulta.Size = new System.Drawing.Size(90, 22);
            this.mtbDataConsulta.TabIndex = 56;
            this.mtbDataConsulta.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 55;
            this.label8.Text = "Horário:";
            // 
            // btSairC
            // 
            this.btSairC.Location = new System.Drawing.Point(701, 3);
            this.btSairC.Name = "btSairC";
            this.btSairC.Size = new System.Drawing.Size(75, 23);
            this.btSairC.TabIndex = 53;
            this.btSairC.Text = "Sair";
            this.btSairC.UseVisualStyleBackColor = true;
            this.btSairC.Click += new System.EventHandler(this.btSairC_Click);
            // 
            // btRelatorioC
            // 
            this.btRelatorioC.Location = new System.Drawing.Point(614, 195);
            this.btRelatorioC.Name = "btRelatorioC";
            this.btRelatorioC.Size = new System.Drawing.Size(122, 25);
            this.btRelatorioC.TabIndex = 52;
            this.btRelatorioC.Text = "Gerar Relatório";
            this.btRelatorioC.UseVisualStyleBackColor = true;
            this.btRelatorioC.Click += new System.EventHandler(this.btRelatorioC_Click);
            // 
            // btDeletarC
            // 
            this.btDeletarC.Location = new System.Drawing.Point(214, 195);
            this.btDeletarC.Name = "btDeletarC";
            this.btDeletarC.Size = new System.Drawing.Size(75, 23);
            this.btDeletarC.TabIndex = 51;
            this.btDeletarC.Text = "Deletar";
            this.btDeletarC.UseVisualStyleBackColor = true;
            this.btDeletarC.Click += new System.EventHandler(this.btDeletarC_Click);
            // 
            // btGravarC
            // 
            this.btGravarC.Location = new System.Drawing.Point(29, 195);
            this.btGravarC.Name = "btGravarC";
            this.btGravarC.Size = new System.Drawing.Size(75, 23);
            this.btGravarC.TabIndex = 50;
            this.btGravarC.Text = "Gravar";
            this.btGravarC.UseVisualStyleBackColor = true;
            this.btGravarC.Click += new System.EventHandler(this.btGravarC_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "CPF do Médico:";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(78, 111);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(111, 16);
            this.lbData.TabIndex = 45;
            this.lbData.Text = "Data da consulta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 16);
            this.label9.TabIndex = 44;
            this.label9.Text = "CPF do Paciente:";
            // 
            // dgvC
            // 
            this.dgvC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvC.Location = new System.Drawing.Point(29, 226);
            this.dgvC.Name = "dgvC";
            this.dgvC.RowHeadersWidth = 51;
            this.dgvC.RowTemplate.Height = 24;
            this.dgvC.Size = new System.Drawing.Size(707, 185);
            this.dgvC.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPacientes.ResumeLayout(false);
            this.tabPacientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvP)).EndInit();
            this.mtbCpfM.ResumeLayout(false);
            this.mtbCpfM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvM)).EndInit();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPacientes;
        private System.Windows.Forms.TabPage mtbCpfM;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.DataGridView dgvP;
        private System.Windows.Forms.Button btSairP;
        private System.Windows.Forms.Button btDeletarP;
        private System.Windows.Forms.Button btRelatorioP;
        private System.Windows.Forms.Button btGravarP;
        private System.Windows.Forms.MaskedTextBox mtbCpfP;
        private System.Windows.Forms.TextBox tbNomeP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvM;
        private System.Windows.Forms.Button btSairM;
        private System.Windows.Forms.Button btRelatórioM;
        private System.Windows.Forms.Button btDeletarM;
        private System.Windows.Forms.Button btGravarM;
        private System.Windows.Forms.MaskedTextBox mtbCpfMe;
        private System.Windows.Forms.TextBox tbNomeM;
        private System.Windows.Forms.TextBox tbEspecialidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSairC;
        private System.Windows.Forms.Button btRelatorioC;
        private System.Windows.Forms.Button btDeletarC;
        private System.Windows.Forms.Button btGravarC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mtbDatadenascimento;
        private System.Windows.Forms.MaskedTextBox mtbDataConsulta;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneP;
        private System.Windows.Forms.Button btAtualizarM;
        private System.Windows.Forms.Button btAtualizarC;
        private System.Windows.Forms.Button btAtualizarP;
        private System.Windows.Forms.MaskedTextBox mtbTelefoneM;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtbcpfpaciente;
        private System.Windows.Forms.MaskedTextBox mtbcpfmedico;
    }
}

