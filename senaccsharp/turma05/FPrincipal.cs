using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace turma05
{
    public partial class FPrincipal : Form
    {
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FCliente frmCliente = new FCliente();
            frmCliente.Show();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CadastroLivro frmCadastroLivro = new CadastroLivro();
            frmCadastroLivro.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaLeitor frmConsultaLeitor = new ConsultaLeitor();
            frmConsultaLeitor.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExcluirLeitor frmExcluirLeitor = new ExcluirLeitor();
            frmExcluirLeitor.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaLivro frmConsultaLivro = new ConsultaLivro();
            frmConsultaLivro.Show();
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExcluirLivro frmExcluirLivro = new ExcluirLivro();
            frmExcluirLivro.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlteraLeitor1 frmAlteraLeitor1 = new AlteraLeitor1();
            frmAlteraLeitor1.Show();
        }

        private void alterarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AlteraLivro1 frmAlteraLivro = new AlteraLivro1();
            frmAlteraLivro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void incluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarEmprestimo frmCadastrarEmprestimo = new CadastrarEmprestimo();
            frmCadastrarEmprestimo.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ConsultarEmprestimo frmConsultarEmprestimo = new ConsultarEmprestimo();
            frmConsultarEmprestimo.Show();
        }

        private void devoluçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devolucao frmDevolucao = new Devolucao();
            frmDevolucao.Show();
        }
    }
}
