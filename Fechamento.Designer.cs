
namespace Suporte
{
    partial class Fechamento
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
            this.label8 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtSolicitacao = new System.Windows.Forms.ComboBox();
            this.txtPredio = new System.Windows.Forms.ComboBox();
            this.txtSetor = new System.Windows.Forms.ComboBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtRamal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAtuacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.NumChamado = new System.Windows.Forms.Label();
            this.BtnEncerramento = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataAbertura = new System.Windows.Forms.MaskedTextBox();
            this.TxtSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Enabled = false;
            this.txtIP.Location = new System.Drawing.Point(271, 56);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            this.txtIP.TabIndex = 27;
            // 
            // txtSolicitacao
            // 
            this.txtSolicitacao.Enabled = false;
            this.txtSolicitacao.FormattingEnabled = true;
            this.txtSolicitacao.Items.AddRange(new object[] {
            "Manutenção",
            "Alteração",
            "Instalação",
            "Acesso"});
            this.txtSolicitacao.Location = new System.Drawing.Point(76, 114);
            this.txtSolicitacao.Name = "txtSolicitacao";
            this.txtSolicitacao.Size = new System.Drawing.Size(121, 23);
            this.txtSolicitacao.TabIndex = 19;
            // 
            // txtPredio
            // 
            this.txtPredio.Enabled = false;
            this.txtPredio.FormattingEnabled = true;
            this.txtPredio.Items.AddRange(new object[] {
            "Caiapos",
            "Arapoema"});
            this.txtPredio.Location = new System.Drawing.Point(76, 85);
            this.txtPredio.Name = "txtPredio";
            this.txtPredio.Size = new System.Drawing.Size(121, 23);
            this.txtPredio.TabIndex = 15;
            // 
            // txtSetor
            // 
            this.txtSetor.Enabled = false;
            this.txtSetor.FormattingEnabled = true;
            this.txtSetor.Items.AddRange(new object[] {
            "Financeiro",
            "DASM",
            "Comercial",
            "Off-set"});
            this.txtSetor.Location = new System.Drawing.Point(271, 85);
            this.txtSetor.Name = "txtSetor";
            this.txtSetor.Size = new System.Drawing.Size(100, 23);
            this.txtSetor.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(76, 158);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(295, 147);
            this.txtDescricao.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(8, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Descrição";
            // 
            // TxtRamal
            // 
            this.TxtRamal.Enabled = false;
            this.TxtRamal.HideSelection = false;
            this.TxtRamal.Location = new System.Drawing.Point(271, 114);
            this.TxtRamal.MaxLength = 4;
            this.TxtRamal.Name = "TxtRamal";
            this.TxtRamal.Size = new System.Drawing.Size(100, 23);
            this.TxtRamal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(219, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Ramal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Solicitação";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Predio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(219, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Setor";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(76, 56);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "Host";
            // 
            // txtAtuacao
            // 
            this.txtAtuacao.Location = new System.Drawing.Point(76, 341);
            this.txtAtuacao.Multiline = true;
            this.txtAtuacao.Name = "txtAtuacao";
            this.txtAtuacao.Size = new System.Drawing.Size(295, 170);
            this.txtAtuacao.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Atuação";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label9.Location = new System.Drawing.Point(106, 9);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(147, 32);
            this.Label9.TabIndex = 31;
            this.Label9.Text = "Chamado nº";
            this.Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // NumChamado
            // 
            this.NumChamado.AutoSize = true;
            this.NumChamado.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumChamado.Location = new System.Drawing.Point(258, 11);
            this.NumChamado.Name = "NumChamado";
            this.NumChamado.Size = new System.Drawing.Size(148, 30);
            this.NumChamado.TabIndex = 32;
            this.NumChamado.Text = "NumChamado";
            this.NumChamado.Click += new System.EventHandler(this.NumChamado_Click);
            // 
            // BtnEncerramento
            // 
            this.BtnEncerramento.Location = new System.Drawing.Point(258, 517);
            this.BtnEncerramento.Name = "BtnEncerramento";
            this.BtnEncerramento.Size = new System.Drawing.Size(90, 23);
            this.BtnEncerramento.TabIndex = 33;
            this.BtnEncerramento.Text = "Encerramento do chamado";
            this.BtnEncerramento.UseVisualStyleBackColor = true;
            this.BtnEncerramento.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 315);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 35;
            this.label10.Text = "Chamado aberto em:";
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Enabled = false;
            this.txtDataAbertura.Location = new System.Drawing.Point(237, 312);
            this.txtDataAbertura.Mask = "00/00/0000";
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.Size = new System.Drawing.Size(71, 23);
            this.txtDataAbertura.TabIndex = 36;
            this.txtDataAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // TxtSair
            // 
            this.TxtSair.Location = new System.Drawing.Point(90, 518);
            this.TxtSair.Name = "TxtSair";
            this.TxtSair.Size = new System.Drawing.Size(75, 23);
            this.TxtSair.TabIndex = 37;
            this.TxtSair.Text = "Sair";
            this.TxtSair.UseVisualStyleBackColor = true;
            this.TxtSair.Click += new System.EventHandler(this.TxtSair_Click);
            // 
            // Fechamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 553);
            this.Controls.Add(this.TxtSair);
            this.Controls.Add(this.txtDataAbertura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BtnEncerramento);
            this.Controls.Add(this.NumChamado);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAtuacao);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.txtSolicitacao);
            this.Controls.Add(this.txtPredio);
            this.Controls.Add(this.txtSetor);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TxtRamal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Name = "Fechamento";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtIP;
        public System.Windows.Forms.ComboBox txtSolicitacao;
        public System.Windows.Forms.ComboBox txtPredio;
        public System.Windows.Forms.ComboBox txtSetor;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox TxtRamal;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label9;
        public System.Windows.Forms.Label NumChamado;
        private System.Windows.Forms.Button BtnEncerramento;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.MaskedTextBox txtDataAbertura;
        private System.Windows.Forms.Button TxtSair;
        public System.Windows.Forms.TextBox txtAtuacao;
    }
}