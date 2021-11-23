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
   

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtSenha.Text =="")
            {
                MessageBox.Show("Preencha os campos de login");
            }
            bool blnfound = false;
            
            NpgsqlConnection con = new("Server=127.0.0.1;Port=5432; UserID=postgres; Password=12345;Database=postgres;");
            con.Open();
            NpgsqlCommand cmd = new("Select * from login where usuario ='" + txtUsuario.Text + "'and senha = '" + txtSenha.Text +"'", con);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                blnfound = true;
                var acesso = dr["nivel"].ToString();

                switch (acesso)
                {
                    case "1":
                        Chamados cham = new();
                        cham.Show();
                        this.Hide();
                        break;
                    case "2":
                        Abertura abr = new();
                        abr.Show();
                        this.Hide();
                        break;
                }
            }
            if (blnfound ==false)
            {
                MessageBox.Show("Erro");
            }
            dr.Close();
            con.Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
