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
    public partial class AlteraLeitor2 : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();

        public AlteraLeitor2()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
        }
        public void recebedados(string strNome, int intId, string strEndereco, int intNumero, String strBairro, string strCidade)
            {
             txtID.Text = Convert.ToString(intId);
            txtNome.Text = strNome;
            txtEndereco.Text = strEndereco;
            txtNumero.Text = Convert.ToString(intNumero);
            txtBairro.Text = strBairro;
            txtCidade.Text = strCidade;
            }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            int intId = Convert.ToInt16(txtID.Text);
            string strNome = txtNome.Text;
            string strEndereco = txtEndereco.Text;
            int intNumero = Convert.ToInt16(txtNumero.Text);
            string strBairro = txtBairro.Text;
            string strCidade = txtCidade.Text;
            string alterar = @"UPDATE clientes SET nome = '" + strNome + "', endereco = '" + strEndereco + "', numero='" + intNumero + "', bairro='" + strBairro + "', cidade='" + strCidade + "' WHERE id_cliente ='" + intId + "';";
            SqlCommand _cmd = new SqlCommand(alterar, con);

            _cmd.ExecuteNonQuery(); con.Close();


            MessageBox.Show("Atualização Realizada Com Sucesso!!!");
        }
    }
}
