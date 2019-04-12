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
    public partial class AlteraLeitor1 : Form
    {
        SqlConnection con;
        bancodedados banco = new bancodedados();

        int intId, intNumero;
        string strNome, strEndereco, strBairro, strCidade;

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlteraLeitor2 frmAlteraLeitor2 = new AlteraLeitor2();
            frmAlteraLeitor2.recebedados(strNome, intId, strEndereco, intNumero, strBairro, strCidade);
            frmAlteraLeitor2.Show();
            this.Close();
        }

        private void SelecioneRegistro(object sender, DataGridViewCellEventArgs e)
        {
            strNome = Convert.ToString(data.Rows[e.RowIndex].Cells[0].Value);
            intId = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            strEndereco=Convert.ToString(data.Rows[e.RowIndex].Cells[2].Value);
            intNumero= Convert.ToInt32(data.Rows[e.RowIndex].Cells[3].Value);
            strBairro= Convert.ToString(data.Rows[e.RowIndex].Cells[4].Value);
            strCidade= Convert.ToString(data.Rows[e.RowIndex].Cells[5].Value);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT nome, Id_cliente, endereco, numero, bairro, cidade FROM clientes where nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
        }

        public AlteraLeitor1()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            //btnAlterar.Enabled = false;
        }

        private void AlteraLeitor1_Load(object sender, EventArgs e)
        {

        }
    }
}
