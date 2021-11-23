using Npgsql;
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
    public partial class Abertura : Form
    {
        public Abertura()
        {
            InitializeComponent();
        }

        readonly DAL acesso = new();
        readonly string Hostname = Dns.GetHostName();
        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();

                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        private void Form1_Load(object sender, EventArgs e)
        { 
            txtIP.Text = Convert.ToString(GetLocalIPAddress());
            txtNome.Text = Hostname;
            lblUsuario.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(TxtRamal.Text, "[^0-9]"))
            {
                MessageBox.Show("Ramal Incorreto");
                TxtRamal.Text = "";
                TxtRamal.Focus();
            }
            else if (txtNome.Text == string.Empty || txtSetor.Text == string.Empty || txtPredio.Text == string.Empty
                || txtSolicitacao.Text == string.Empty || TxtRamal.Text == string.Empty ||
                txtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Preencha os campos corretamente");
            }
            else
            {
                acesso.InserirRegistros(txtNome.Text, txtSetor.Text, txtPredio.Text, txtSolicitacao.Text, int.Parse(TxtRamal.Text), txtDescricao.Text, txtIP.Text);
                MessageBox.Show("Chamado aberto!!\n" +
                                "Aguarde o retorno do Suporte");
                System.Windows.Forms.Application.Exit();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
