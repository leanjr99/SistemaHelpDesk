using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Suporte
{
    public partial class Fechamento : Form
    {
        public Fechamento()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Label9_Click(object sender, EventArgs e)
        {
           Label9.TextAlign = ContentAlignment.TopCenter;
        }

        private void NumChamado_Click(object sender, EventArgs e)
        {
            NumChamado.TextAlign = ContentAlignment.TopCenter;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                DAL acesso = new();
                acesso.AtualizaChamado(txtAtuacao.Text, int.Parse(NumChamado.Text));
                MessageBox.Show("OK");
            }
            catch (Exception)
            {
                throw;
            }
            
        }


        private void TxtSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
