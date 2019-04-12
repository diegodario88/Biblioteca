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
    public partial class ExcluirLeitor : Form
    {
        //CHAMANDO A CONEXÃO PARA TODO PROJETO
        SqlConnection con;
        bancodedados banco = new bancodedados();
        int codigo_leitor;
        public ExcluirLeitor()
        {
            InitializeComponent();
            con = banco.abrir_conexao();
            btnExcluir.Enabled = false;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            String strNome = txtNome.Text;

            string selecionar = @"SELECT nome,Id_cliente, endereco, numero, bairro, cidade FROM clientes where nome like '%" + strNome + "%'";

            SqlDataAdapter adaptador = new SqlDataAdapter(selecionar, con);
            DataTable tabela = new DataTable();
            adaptador.Fill(tabela);
            data.DataSource = tabela;
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que Deseja Excluir?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                //DELETAR REGISTRO

                
                string deletar = @"DELETE FROM clientes WHERE Id_cliente='" + codigo_leitor + "';";

                con = banco.abrir_conexao();
                SqlCommand _cmd = new SqlCommand(deletar, con);
                _cmd.ExecuteNonQuery();
                txtNome.Text = "";

                //ATUALILZA DATA

                string selecionar = @"SELECT nome, Id_cliente, endereco, numero, bairro, cidade FROM clientes";
                SqlDataAdapter a = new SqlDataAdapter(selecionar, con);
                DataTable t = new DataTable();
                a.Fill(t);
                data.DataSource = t;
                btnExcluir.Enabled = false;



            }

        }

        private void data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigo_leitor = Convert.ToInt32(data.Rows[e.RowIndex].Cells[1].Value);
            btnExcluir.Enabled = true;
        }

        private void ExcluirLeitor_Load(object sender, EventArgs e)
        {

        }
    }
}
