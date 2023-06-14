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
    public partial class TelaRota: Form
    {
        public TelaRota()
        {
            InitializeComponent();
        }
        Rota rot;

        private void TelaRota_Load(object sender, EventArgs e)
        {
            new Rota().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            rot = new Rota();
            rot.ID = Convert.ToInt32(txtId.Text);
            foreach (Rota r in rot.Buscar())
            {
                txtId.Text = r.ID.ToString();
                txtNumero.Text = r.Numero.ToString();
                txtNome.Text = r.Nome;
                txtPonto.Text = r.pontoReferecia;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                rot = new Rota();
                rot.ID = Convert.ToInt32(txtId.Text);
                rot.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            rot = new Rota();
            if (txtId.Text != "")
            {
                rot.ID = int.Parse(txtId.Text);
                MessageBox.Show("Atualizado com sucesso");
            }
            rot.Numero = int.Parse(txtNumero.Text);
            rot.Nome = txtNome.Text;
            rot.pontoReferecia = txtPonto.Text;
            MessageBox.Show("Salvo com sucesso");
            rot.Salvar();
            Carrega_DataGrid();
            Limpar();
        }
        private void Carrega_DataGrid()
        {
            rot = new Rota();
            Dados.AutoGenerateColumns = false;
            Dados.DataSource = rot.Todos();
        }
        private void Limpar()
        {
            txtId.Text = null;
            txtNumero.Text = null;
            txtNome.Text = null;
            txtPonto.Text = null;
        }
    }
}
