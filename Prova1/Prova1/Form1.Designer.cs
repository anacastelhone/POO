namespace Prova1
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
            this.rbonibus = new System.Windows.Forms.RadioButton();
            this.rbcaminhao = new System.Windows.Forms.RadioButton();
            this.tbanoa = new System.Windows.Forms.TextBox();
            this.tbassentos = new System.Windows.Forms.TextBox();
            this.tbanov = new System.Windows.Forms.TextBox();
            this.lbanoatual = new System.Windows.Forms.Label();
            this.lbanoveiculo = new System.Windows.Forms.Label();
            this.lbassentos = new System.Windows.Forms.Label();
            this.ListVeiculos = new System.Windows.Forms.ListView();
            this.colnome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colanoatual = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colanoveiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coldiaria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbonibus
            // 
            this.rbonibus.AutoSize = true;
            this.rbonibus.Location = new System.Drawing.Point(74, 40);
            this.rbonibus.Name = "rbonibus";
            this.rbonibus.Size = new System.Drawing.Size(70, 20);
            this.rbonibus.TabIndex = 0;
            this.rbonibus.TabStop = true;
            this.rbonibus.Text = "Ônibus";
            this.rbonibus.UseVisualStyleBackColor = true;
            this.rbonibus.CheckedChanged += new System.EventHandler(this.rbonibus_CheckedChanged);
            // 
            // rbcaminhao
            // 
            this.rbcaminhao.AutoSize = true;
            this.rbcaminhao.Location = new System.Drawing.Point(356, 40);
            this.rbcaminhao.Name = "rbcaminhao";
            this.rbcaminhao.Size = new System.Drawing.Size(89, 20);
            this.rbcaminhao.TabIndex = 1;
            this.rbcaminhao.TabStop = true;
            this.rbcaminhao.Text = "Caminhão";
            this.rbcaminhao.UseVisualStyleBackColor = true;
            this.rbcaminhao.CheckedChanged += new System.EventHandler(this.rbcaminhao_CheckedChanged);
            // 
            // tbanoa
            // 
            this.tbanoa.Location = new System.Drawing.Point(193, 107);
            this.tbanoa.Name = "tbanoa";
            this.tbanoa.Size = new System.Drawing.Size(100, 22);
            this.tbanoa.TabIndex = 2;
            // 
            // tbassentos
            // 
            this.tbassentos.Location = new System.Drawing.Point(193, 201);
            this.tbassentos.Name = "tbassentos";
            this.tbassentos.Size = new System.Drawing.Size(100, 22);
            this.tbassentos.TabIndex = 3;
            // 
            // tbanov
            // 
            this.tbanov.Location = new System.Drawing.Point(193, 148);
            this.tbanov.Name = "tbanov";
            this.tbanov.Size = new System.Drawing.Size(100, 22);
            this.tbanov.TabIndex = 4;
            // 
            // lbanoatual
            // 
            this.lbanoatual.AutoSize = true;
            this.lbanoatual.Location = new System.Drawing.Point(90, 107);
            this.lbanoatual.Name = "lbanoatual";
            this.lbanoatual.Size = new System.Drawing.Size(67, 16);
            this.lbanoatual.TabIndex = 5;
            this.lbanoatual.Text = "Ano Atual:";
            // 
            // lbanoveiculo
            // 
            this.lbanoveiculo.AutoSize = true;
            this.lbanoveiculo.Location = new System.Drawing.Point(91, 154);
            this.lbanoveiculo.Name = "lbanoveiculo";
            this.lbanoveiculo.Size = new System.Drawing.Size(82, 16);
            this.lbanoveiculo.TabIndex = 6;
            this.lbanoveiculo.Text = "Ano Veículo:";
            // 
            // lbassentos
            // 
            this.lbassentos.AutoSize = true;
            this.lbassentos.Location = new System.Drawing.Point(91, 201);
            this.lbassentos.Name = "lbassentos";
            this.lbassentos.Size = new System.Drawing.Size(66, 16);
            this.lbassentos.TabIndex = 7;
            this.lbassentos.Text = "Assentos:";
            // 
            // ListVeiculos
            // 
            this.ListVeiculos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colnome,
            this.colanoatual,
            this.colanoveiculo,
            this.coldiaria});
            this.ListVeiculos.HideSelection = false;
            this.ListVeiculos.Location = new System.Drawing.Point(74, 276);
            this.ListVeiculos.Name = "ListVeiculos";
            this.ListVeiculos.Size = new System.Drawing.Size(619, 124);
            this.ListVeiculos.TabIndex = 8;
            this.ListVeiculos.UseCompatibleStateImageBehavior = false;
            this.ListVeiculos.View = System.Windows.Forms.View.Details;
            // 
            // colnome
            // 
            this.colnome.Text = "Nome";
            this.colnome.Width = 116;
            // 
            // colanoatual
            // 
            this.colanoatual.Text = "Ano Atual";
            this.colanoatual.Width = 119;
            // 
            // colanoveiculo
            // 
            this.colanoveiculo.Text = "Ano Veiculo";
            this.colanoveiculo.Width = 135;
            // 
            // coldiaria
            // 
            this.coldiaria.Text = "Diária";
            this.coldiaria.Width = 152;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(409, 136);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(130, 46);
            this.btCalcular.TabIndex = 9;
            this.btCalcular.Text = "Cadastrar";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.ListVeiculos);
            this.Controls.Add(this.lbassentos);
            this.Controls.Add(this.lbanoveiculo);
            this.Controls.Add(this.lbanoatual);
            this.Controls.Add(this.tbanov);
            this.Controls.Add(this.tbassentos);
            this.Controls.Add(this.tbanoa);
            this.Controls.Add(this.rbcaminhao);
            this.Controls.Add(this.rbonibus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbonibus;
        private System.Windows.Forms.RadioButton rbcaminhao;
        private System.Windows.Forms.TextBox tbanoa;
        private System.Windows.Forms.TextBox tbassentos;
        private System.Windows.Forms.TextBox tbanov;
        private System.Windows.Forms.Label lbanoatual;
        private System.Windows.Forms.Label lbanoveiculo;
        private System.Windows.Forms.Label lbassentos;
        private System.Windows.Forms.ListView ListVeiculos;
        private System.Windows.Forms.ColumnHeader colnome;
        private System.Windows.Forms.ColumnHeader colanoatual;
        private System.Windows.Forms.ColumnHeader colanoveiculo;
        private System.Windows.Forms.ColumnHeader coldiaria;
        private System.Windows.Forms.Button btCalcular;
    }
}

