namespace Marcade
{
    partial class frmTelaPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.btnPesquisarId = new System.Windows.Forms.Button();
            this.lblAtor = new System.Windows.Forms.Label();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.lblAssistido = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscarId = new System.Windows.Forms.TextBox();
            this.dgvFilmes = new System.Windows.Forms.DataGridView();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblPesqId = new System.Windows.Forms.Label();
            this.lblPesqTitulo = new System.Windows.Forms.Label();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.btnPesquisarTitulo = new System.Windows.Forms.Button();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.txtAtor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(56, 120);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(56, 150);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(35, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(56, 178);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(26, 13);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Ano";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(56, 207);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(42, 13);
            this.lblGenero.TabIndex = 3;
            this.lblGenero.Text = "Gênero";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(113, 120);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(79, 20);
            this.txtCodigo.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(113, 150);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(230, 20);
            this.txtTitulo.TabIndex = 6;
            // 
            // cboAno
            // 
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(113, 178);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(100, 21);
            this.cboAno.TabIndex = 7;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Ação",
            "Animação",
            "Comédia",
            "Drama",
            "Infantil",
            "Romance",
            "Terror"});
            this.cboGenero.Location = new System.Drawing.Point(113, 207);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(151, 21);
            this.cboGenero.TabIndex = 8;
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.Location = new System.Drawing.Point(129, 238);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(42, 17);
            this.rbtSim.TabIndex = 9;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "Sim";
            this.rbtSim.UseVisualStyleBackColor = true;
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.Location = new System.Drawing.Point(216, 238);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(45, 17);
            this.rbtNao.TabIndex = 10;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "Não";
            this.rbtNao.UseVisualStyleBackColor = true;
            // 
            // btnPesquisarId
            // 
            this.btnPesquisarId.Location = new System.Drawing.Point(408, 11);
            this.btnPesquisarId.Name = "btnPesquisarId";
            this.btnPesquisarId.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarId.TabIndex = 12;
            this.btnPesquisarId.Text = "Pesquisar";
            this.btnPesquisarId.UseVisualStyleBackColor = true;
            this.btnPesquisarId.Click += new System.EventHandler(this.btnPesquisarId_Click);
            // 
            // lblAtor
            // 
            this.lblAtor.AutoSize = true;
            this.lblAtor.Location = new System.Drawing.Point(56, 277);
            this.lblAtor.Name = "lblAtor";
            this.lblAtor.Size = new System.Drawing.Size(26, 13);
            this.lblAtor.TabIndex = 15;
            this.lblAtor.Text = "Ator";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.Location = new System.Drawing.Point(56, 310);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(38, 13);
            this.lblDiretor.TabIndex = 16;
            this.lblDiretor.Text = "Diretor";
            // 
            // lblAssistido
            // 
            this.lblAssistido.AutoSize = true;
            this.lblAssistido.Location = new System.Drawing.Point(56, 238);
            this.lblAssistido.Name = "lblAssistido";
            this.lblAssistido.Size = new System.Drawing.Size(48, 13);
            this.lblAssistido.TabIndex = 17;
            this.lblAssistido.Text = "Assistido";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(56, 20);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 18;
            this.lblBuscar.Text = "Buscar";
            // 
            // txtBuscarId
            // 
            this.txtBuscarId.Location = new System.Drawing.Point(184, 20);
            this.txtBuscarId.Name = "txtBuscarId";
            this.txtBuscarId.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarId.TabIndex = 3;
            // 
            // dgvFilmes
            // 
            this.dgvFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilmes.Location = new System.Drawing.Point(15, 352);
            this.dgvFilmes.Name = "dgvFilmes";
            this.dgvFilmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFilmes.Size = new System.Drawing.Size(544, 152);
            this.dgvFilmes.TabIndex = 20;
            this.dgvFilmes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFilmes_CellDoubleClick);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(408, 178);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(90, 29);
            this.btnAlterar.TabIndex = 21;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(408, 248);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 29);
            this.btnExcluir.TabIndex = 22;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblPesqId
            // 
            this.lblPesqId.AutoSize = true;
            this.lblPesqId.Location = new System.Drawing.Point(110, 20);
            this.lblPesqId.Name = "lblPesqId";
            this.lblPesqId.Size = new System.Drawing.Size(64, 13);
            this.lblPesqId.TabIndex = 25;
            this.lblPesqId.Text = "Pelo Código";
            // 
            // lblPesqTitulo
            // 
            this.lblPesqTitulo.AutoSize = true;
            this.lblPesqTitulo.Location = new System.Drawing.Point(113, 56);
            this.lblPesqTitulo.Name = "lblPesqTitulo";
            this.lblPesqTitulo.Size = new System.Drawing.Size(59, 13);
            this.lblPesqTitulo.TabIndex = 26;
            this.lblPesqTitulo.Text = "Pelo Título";
            // 
            // txtBuscarTitulo
            // 
            this.txtBuscarTitulo.Location = new System.Drawing.Point(184, 56);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarTitulo.TabIndex = 4;
            // 
            // btnPesquisarTitulo
            // 
            this.btnPesquisarTitulo.Location = new System.Drawing.Point(408, 56);
            this.btnPesquisarTitulo.Name = "btnPesquisarTitulo";
            this.btnPesquisarTitulo.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarTitulo.TabIndex = 28;
            this.btnPesquisarTitulo.Text = "Pesquisar";
            this.btnPesquisarTitulo.UseVisualStyleBackColor = true;
            this.btnPesquisarTitulo.Click += new System.EventHandler(this.btnPesquisarTitulo_Click);
            // 
            // txtDiretor
            // 
            this.txtDiretor.Location = new System.Drawing.Point(113, 310);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(230, 20);
            this.txtDiretor.TabIndex = 29;
            // 
            // txtAtor
            // 
            this.txtAtor.Location = new System.Drawing.Point(113, 277);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(230, 20);
            this.txtAtor.TabIndex = 31;
            // 
            // frmTelaPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 516);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.btnPesquisarTitulo);
            this.Controls.Add(this.txtBuscarTitulo);
            this.Controls.Add(this.lblPesqTitulo);
            this.Controls.Add(this.lblPesqId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.dgvFilmes);
            this.Controls.Add(this.txtBuscarId);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblAssistido);
            this.Controls.Add(this.rbtSim);
            this.Controls.Add(this.rbtNao);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.lblAtor);
            this.Controls.Add(this.btnPesquisarId);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmTelaPesquisa";
            this.Text = "Marcade Filmes";
            this.Load += new System.EventHandler(this.frmTelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilmes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.Button btnPesquisarId;
        private System.Windows.Forms.Label lblAtor;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.Label lblAssistido;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscarId;
        private System.Windows.Forms.DataGridView dgvFilmes;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblPesqId;
        private System.Windows.Forms.Label lblPesqTitulo;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.Button btnPesquisarTitulo;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.TextBox txtAtor;
    }
}

