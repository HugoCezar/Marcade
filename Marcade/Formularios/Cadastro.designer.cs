namespace Marcade
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.rbtSim = new System.Windows.Forms.RadioButton();
            this.rbtNao = new System.Windows.Forms.RadioButton();
            this.cboAno = new System.Windows.Forms.ComboBox();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAtor = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cADASTROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROCURARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSSISTIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDiretor = new System.Windows.Forms.Label();
            this.txtDiretor = new System.Windows.Forms.TextBox();
            this.lblAtor = new System.Windows.Forms.Label();
            this.txtAtor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.Silver;
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Location = new System.Drawing.Point(295, 44);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(222, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.Color.Silver;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitulo.Location = new System.Drawing.Point(295, 80);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(222, 20);
            this.txtTitulo.TabIndex = 8;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.DarkRed;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncluir.ForeColor = System.Drawing.Color.Black;
            this.btnIncluir.Location = new System.Drawing.Point(418, 290);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(86, 29);
            this.btnIncluir.TabIndex = 18;
            this.btnIncluir.Text = "INCLUIR";
            this.btnIncluir.UseVisualStyleBackColor = false;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // rbtSim
            // 
            this.rbtSim.AutoSize = true;
            this.rbtSim.BackColor = System.Drawing.Color.Transparent;
            this.rbtSim.ForeColor = System.Drawing.Color.White;
            this.rbtSim.Location = new System.Drawing.Point(308, 194);
            this.rbtSim.Name = "rbtSim";
            this.rbtSim.Size = new System.Drawing.Size(44, 17);
            this.rbtSim.TabIndex = 11;
            this.rbtSim.TabStop = true;
            this.rbtSim.Text = "SIM";
            this.rbtSim.UseVisualStyleBackColor = false;
            // 
            // rbtNao
            // 
            this.rbtNao.AutoSize = true;
            this.rbtNao.BackColor = System.Drawing.Color.Transparent;
            this.rbtNao.ForeColor = System.Drawing.Color.White;
            this.rbtNao.Location = new System.Drawing.Point(408, 194);
            this.rbtNao.Name = "rbtNao";
            this.rbtNao.Size = new System.Drawing.Size(48, 17);
            this.rbtNao.TabIndex = 12;
            this.rbtNao.TabStop = true;
            this.rbtNao.Text = "NÃO";
            this.rbtNao.UseVisualStyleBackColor = false;
            // 
            // cboAno
            // 
            this.cboAno.BackColor = System.Drawing.Color.Silver;
            this.cboAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboAno.FormattingEnabled = true;
            this.cboAno.Location = new System.Drawing.Point(295, 114);
            this.cboAno.Name = "cboAno";
            this.cboAno.Size = new System.Drawing.Size(222, 21);
            this.cboAno.TabIndex = 13;
            this.cboAno.Text = "Selecione";
            // 
            // cboGenero
            // 
            this.cboGenero.BackColor = System.Drawing.Color.Silver;
            this.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Items.AddRange(new object[] {
            "Ação",
            "Comédia",
            "Drama",
            "Ficção Cientifica",
            "Romance",
            "Terror"});
            this.cboGenero.Location = new System.Drawing.Point(295, 151);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(222, 21);
            this.cboGenero.TabIndex = 14;
            this.cboGenero.Text = "Selecione";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.BackColor = System.Drawing.Color.Transparent;
            this.lblId.ForeColor = System.Drawing.Color.Silver;
            this.lblId.Location = new System.Drawing.Point(203, 51);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(49, 13);
            this.lblId.TabIndex = 17;
            this.lblId.Text = "CÓDIGO";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.ForeColor = System.Drawing.Color.Silver;
            this.lblTitulo.Location = new System.Drawing.Point(203, 87);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(46, 13);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "TÍTULO";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.Transparent;
            this.lblAno.ForeColor = System.Drawing.Color.Silver;
            this.lblAno.Location = new System.Drawing.Point(203, 122);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(30, 13);
            this.lblAno.TabIndex = 19;
            this.lblAno.Text = "ANO";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.Transparent;
            this.lblGenero.ForeColor = System.Drawing.Color.Silver;
            this.lblGenero.Location = new System.Drawing.Point(203, 159);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(53, 13);
            this.lblGenero.TabIndex = 20;
            this.lblGenero.Text = "GÊNERO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(203, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "ASSISTIDO";
            // 
            // btnAtor
            // 
            this.btnAtor.Location = new System.Drawing.Point(0, 0);
            this.btnAtor.Name = "btnAtor";
            this.btnAtor.Size = new System.Drawing.Size(75, 23);
            this.btnAtor.TabIndex = 32;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.White;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel1.Image")));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel1.Location = new System.Drawing.Point(58, 44);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FILMES";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel2.Location = new System.Drawing.Point(58, 71);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(37, 13);
            this.linkLabel2.TabIndex = 24;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "LISTA";
            // 
            // linkLabel3
            // 
            this.linkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel3.Image")));
            this.linkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel3.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel3.Location = new System.Drawing.Point(58, 100);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(46, 13);
            this.linkLabel3.TabIndex = 25;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "SÉRIES";
            // 
            // linkLabel4
            // 
            this.linkLabel4.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel4.Image")));
            this.linkLabel4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel4.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel4.Location = new System.Drawing.Point(58, 131);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(45, 13);
            this.linkLabel4.TabIndex = 26;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "DADOS";
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel5.Image")));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel5.Location = new System.Drawing.Point(46, 168);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(99, 13);
            this.linkLabel5.TabIndex = 27;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "CONFIGURAÇÕES";
            // 
            // linkLabel6
            // 
            this.linkLabel6.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel6.Image")));
            this.linkLabel6.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel6.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel6.Location = new System.Drawing.Point(47, 198);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(42, 13);
            this.linkLabel6.TabIndex = 28;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "AJUDA";
            // 
            // linkLabel7
            // 
            this.linkLabel7.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel7.Image")));
            this.linkLabel7.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel7.LinkColor = System.Drawing.Color.Silver;
            this.linkLabel7.Location = new System.Drawing.Point(47, 229);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(79, 13);
            this.linkLabel7.TabIndex = 29;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "MEUS FILMES";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTROToolStripMenuItem,
            this.pROCURARToolStripMenuItem,
            this.aSSISTIDOSToolStripMenuItem,
            this.aJUDAToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cADASTROToolStripMenuItem
            // 
            this.cADASTROToolStripMenuItem.DoubleClickEnabled = true;
            this.cADASTROToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.cADASTROToolStripMenuItem.Name = "cADASTROToolStripMenuItem";
            this.cADASTROToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.cADASTROToolStripMenuItem.Text = "CADASTRAR";
            // 
            // pROCURARToolStripMenuItem
            // 
            this.pROCURARToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pROCURARToolStripMenuItem.Name = "pROCURARToolStripMenuItem";
            this.pROCURARToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.pROCURARToolStripMenuItem.Text = "PROCURAR";
            // 
            // aSSISTIDOSToolStripMenuItem
            // 
            this.aSSISTIDOSToolStripMenuItem.Name = "aSSISTIDOSToolStripMenuItem";
            this.aSSISTIDOSToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iNFOToolStripMenuItem});
            this.aJUDAToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.aJUDAToolStripMenuItem.Text = "AJUDA";
            // 
            // iNFOToolStripMenuItem
            // 
            this.iNFOToolStripMenuItem.Name = "iNFOToolStripMenuItem";
            this.iNFOToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.iNFOToolStripMenuItem.Text = "INFO";
            // 
            // lblDiretor
            // 
            this.lblDiretor.AutoSize = true;
            this.lblDiretor.BackColor = System.Drawing.Color.Transparent;
            this.lblDiretor.ForeColor = System.Drawing.Color.Silver;
            this.lblDiretor.Location = new System.Drawing.Point(203, 256);
            this.lblDiretor.Name = "lblDiretor";
            this.lblDiretor.Size = new System.Drawing.Size(56, 13);
            this.lblDiretor.TabIndex = 31;
            this.lblDiretor.Text = "DIRETOR";
            // 
            // txtDiretor
            // 
            this.txtDiretor.BackColor = System.Drawing.Color.Silver;
            this.txtDiretor.Location = new System.Drawing.Point(292, 256);
            this.txtDiretor.Name = "txtDiretor";
            this.txtDiretor.Size = new System.Drawing.Size(222, 20);
            this.txtDiretor.TabIndex = 17;
            // 
            // lblAtor
            // 
            this.lblAtor.AutoSize = true;
            this.lblAtor.BackColor = System.Drawing.Color.Transparent;
            this.lblAtor.ForeColor = System.Drawing.Color.Silver;
            this.lblAtor.Location = new System.Drawing.Point(203, 229);
            this.lblAtor.Name = "lblAtor";
            this.lblAtor.Size = new System.Drawing.Size(37, 13);
            this.lblAtor.TabIndex = 33;
            this.lblAtor.Text = "ATOR";
            // 
            // txtAtor
            // 
            this.txtAtor.BackColor = System.Drawing.Color.Silver;
            this.txtAtor.Location = new System.Drawing.Point(292, 221);
            this.txtAtor.Name = "txtAtor";
            this.txtAtor.Size = new System.Drawing.Size(222, 20);
            this.txtAtor.TabIndex = 15;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 355);
            this.Controls.Add(this.txtAtor);
            this.Controls.Add(this.lblAtor);
            this.Controls.Add(this.txtDiretor);
            this.Controls.Add(this.lblDiretor);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.linkLabel7);
            this.Controls.Add(this.linkLabel6);
            this.Controls.Add(this.linkLabel5);
            this.Controls.Add(this.linkLabel4);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAtor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboAno);
            this.Controls.Add(this.rbtNao);
            this.Controls.Add(this.rbtSim);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtCodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.Text = "MARCADE FILMES";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.RadioButton rbtSim;
        private System.Windows.Forms.RadioButton rbtNao;
        private System.Windows.Forms.ComboBox cboAno;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAtor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cADASTROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROCURARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aSSISTIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFOToolStripMenuItem;
        private System.Windows.Forms.Label lblDiretor;
        private System.Windows.Forms.TextBox txtDiretor;
        private System.Windows.Forms.Label lblAtor;
        private System.Windows.Forms.TextBox txtAtor;
    }
}