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

namespace Suporte
{
    public partial class Chamados : Form
    {
        public Chamados()
        {
            InitializeComponent();
        }
        readonly DAL acesso = new();
        private void Chamados_Load(object sender, EventArgs e)
        {
            dgvChamados.ReadOnly = true;
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgvChamados.DataSource = acesso.GetTodosRegistros();
        }

        private void DgvChamados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Fechamento formb = new();
            formb.Show();
            formb.NumChamado.Text     = dgvChamados.CurrentRow.Cells[0].Value.ToString();
            formb.txtNome.Text        = dgvChamados.CurrentRow.Cells[1].Value.ToString();
            formb.txtSetor.Text       = dgvChamados.CurrentRow.Cells[2].Value.ToString();
            formb.txtPredio.Text      = dgvChamados.CurrentRow.Cells[3].Value.ToString();
            formb.txtSolicitacao.Text = dgvChamados.CurrentRow.Cells[4].Value.ToString();
            formb.TxtRamal.Text       = dgvChamados.CurrentRow.Cells[5].Value.ToString();
            formb.txtDescricao.Text   = dgvChamados.CurrentRow.Cells[6].Value.ToString();
            formb.txtDataAbertura.Text= dgvChamados.CurrentRow.Cells[8].Value.ToString();
            formb.txtAtuacao.Text = dgvChamados.CurrentRow.Cells[10].Value.ToString();
        }

        private void BtnEncerrados_Click(object sender, EventArgs e)
        {
            dgvChamados.DataSource = acesso.GetRegistrosInativos();
        }

        private void BtnAbertos_Click(object sender, EventArgs e)
        {
            dgvChamados.DataSource = acesso.GetTodosRegistros();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
