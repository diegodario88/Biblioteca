using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turma05
{
    public partial class FCliente : Form
    {
        public FCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //CRIAR VARIAVEIS
            string strNome = txtNome.Text;
            string strEndereco = txtEndereco.Text;
            string strNumero = txtNumero.Text;
            string strBairro = txtBairro.Text;
            string strCidade = txtCidade.Text;

            //ESTANCIAR BANCO DE DADOS
            bancodedados banco = new bancodedados();

            //CRIAR CONEXAÕ SQL
            SqlConnection con;

            //CHAMAR METODO ABRIR CONEXAO DA CLASSE BANCO
            con = banco.abrir_conexao();

            string inserir = @"Insert into clientes (nome, endereco, numero, bairro, cidade) values ('" + strNome + "','" + strEndereco + "', '" + strNumero + "','" + strBairro + "','" + strCidade + "')";

           //EXECUTAR O COMANDO SQL
            SqlCommand _cmd = new SqlCommand(inserir, con);
            _cmd.ExecuteNonQuery();

            //FECHAR CONEXAO
            con.Close();

            //EXIBE MENSAGEM
            MessageBox.Show("CADASTRO EFETUADO COM SUCESSO!");

            Limpar();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            Limpar();
        }
        public void Limpar()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
        }
    }
}
