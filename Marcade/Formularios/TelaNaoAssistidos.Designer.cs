namespace Marcade.Formularios
{
    partial class frmAssistidos
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
            this.dgvAssistidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAssistidos
            // 
            this.dgvAssistidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssistidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAssistidos.Location = new System.Drawing.Point(12, 12);
            this.dgvAssistidos.Name = "dgvAssistidos";
            this.dgvAssistidos.Size = new System.Drawing.Size(635, 215);
            this.dgvAssistidos.TabIndex = 0;
            // 
            // frmAssistidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 261);
            this.Controls.Add(this.dgvAssistidos);
            this.Name = "frmAssistidos";
            this.Text = "Filmes À Assistir";
            this.Load += new System.EventHandler(this.frmAssistidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssistidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAssistidos;
    }
}