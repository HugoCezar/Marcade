namespace Marcade.Formularios
{
    partial class ListaDeFilmesAssistidos
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
            this.dgvListaDeFilmes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeFilmes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaDeFilmes
            // 
            this.dgvListaDeFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDeFilmes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaDeFilmes.Location = new System.Drawing.Point(12, 12);
            this.dgvListaDeFilmes.Name = "dgvListaDeFilmes";
            this.dgvListaDeFilmes.Size = new System.Drawing.Size(634, 221);
            this.dgvListaDeFilmes.TabIndex = 0;
            // 
            // ListaDeFilmesAssistidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 261);
            this.Controls.Add(this.dgvListaDeFilmes);
            this.Name = "ListaDeFilmesAssistidos";
            this.Text = "Lista De Filmes Assistidos";
            this.Load += new System.EventHandler(this.ListaDeFilmesAssistidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDeFilmes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaDeFilmes;
    }
}