using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Onibus
{
    public partial class TelaAluno : Form
    {
        public TelaAluno()
        {
            InitializeComponent();
        }
        Aluno al;

        private void TelaAluno_Load(object sender, EventArgs e)
        {
            new Aluno().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            al = new Aluno();
            al.ID = Convert.ToInt32(txtId.Text);
            foreach (Aluno a in al.Buscar())
            {
                txtId.Text = a.ID.ToString();
                txtNome.Text = a.Nome;
                txtCpf.Text = a.Cpf;
                txtRg.Text = a.RG;
                txtEndereco.Text = a.Endereco;
                txtCelular.Text = a.Celular;
                txtFaculdade.Text = a.Faculdade;
                txtValor.Text = a.Valor.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
                al = new Aluno();
                if (txtId.Text != "")
                {
                    al.ID = int.Parse(txtId.Text);
                    MessageBox.Show("Atualizado com sucesso");
                }
                al.Nome = txtNome.Text;
                al.Cpf = txtCpf.Text;
                al.RG = txtRg.Text;
                al.Endereco = txtEndereco.Text;
                al.Celular = txtCelular.Text;
                al.Faculdade = txtFaculdade.Text;
                al.Valor = double.Parse(txtValor.Text);
                MessageBox.Show("Salvo com sucesso");
                al.Salvar();
                Carrega_DataGrid();
                Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                al = new Aluno();
                al.ID = Convert.ToInt32(txtId.Text);
                al.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }
        private void Carrega_DataGrid()
        {
            al = new Aluno();
            Dados.AutoGenerateColumns = false;
            Dados.DataSource = al.Todos();
        }
        private void Limpar()
        {
            txtId.Text = null;
            txtNome.Text = null;
            txtCpf.Text = null;
            txtRg.Text = null;
            txtEndereco.Text = null;
            txtCelular.Text = null;
            txtFaculdade.Text = null;
            txtValor.Text = null;    
        }
    }
}
