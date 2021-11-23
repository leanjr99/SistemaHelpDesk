
namespace Suporte
{
    partial class Chamados
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
            this.dgvChamados = new System.Windows.Forms.DataGridView();
            this.BtnAbertos = new System.Windows.Forms.Button();
            this.BtnEncerrados = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChamados
            // 
            this.dgvChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamados.Location = new System.Drawing.Point(3, 12);
            this.dgvChamados.Name = "dgvChamados";
            this.dgvChamados.RowTemplate.Height = 25;
            this.dgvChamados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamados.Size = new System.Drawing.Size(1290, 374);
            this.dgvChamados.TabIndex = 0;
            this.dgvChamados.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvChamados_CellDoubleClick);
            // 
            // BtnAbertos
            // 
            this.BtnAbertos.Location = new System.Drawing.Point(72, 415);
            this.BtnAbertos.Name = "BtnAbertos";
            this.BtnAbertos.Size = new System.Drawing.Size(142, 23);
            this.BtnAbertos.TabIndex = 1;
            this.BtnAbertos.Text = "Chamados Abertos";
            this.BtnAbertos.UseVisualStyleBackColor = true;
            this.BtnAbertos.Click += new System.EventHandler(this.BtnAbertos_Click);
            // 
            // BtnEncerrados
            // 
            this.BtnEncerrados.Location = new System.Drawing.Point(273, 415);
            this.BtnEncerrados.Name = "BtnEncerrados";
            this.BtnEncerrados.Size = new System.Drawing.Size(167, 23);
            this.BtnEncerrados.TabIndex = 2;
            this.BtnEncerrados.Text = "Chamados Encerrados";
            this.BtnEncerrados.UseVisualStyleBackColor = true;
            this.BtnEncerrados.Click += new System.EventHandler(this.BtnEncerrados_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(1207, 415);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(75, 23);
            this.BtnSair.TabIndex = 3;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // Chamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1305, 450);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnEncerrados);
            this.Controls.Add(this.BtnAbertos);
            this.Controls.Add(this.dgvChamados);
            this.Name = "Chamados";
            this.Text = "Chamados";
            this.Load += new System.EventHandler(this.Chamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChamados;
        private System.Windows.Forms.Button BtnAbertos;
        private System.Windows.Forms.Button BtnEncerrados;
        private System.Windows.Forms.Button BtnSair;
    }
}