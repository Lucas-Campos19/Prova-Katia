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
    public partial class TelaOnibus : Form
    {
        public TelaOnibus()
        {
            InitializeComponent();
        }
        Onibus oni;

        private void TelaOnibus_Load(object sender, EventArgs e)
        {
            new Onibus().CriarTabela();
            Carrega_DataGrid();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            oni = new Onibus();
            oni.ID = Convert.ToInt32(txtId.Text);
            foreach (Onibus o in oni.Buscar())
            {
                txtId.Text = o.ID.ToString();
                txtDestino.Text = o.Destino;
                txtHora.Text = o.Horario;
                txtMotorista.Text = o.Motorista;
                txtAluno.Text = o.Aluno;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            oni = new Onibus();
            if (txtId.Text != "")
            {
                oni.ID = int.Parse(txtId.Text);
                MessageBox.Show("Atualizado com sucesso");
            }
            oni.Destino = txtDestino.Text;
            oni.Horario = txtHora.Text;
            oni.Motorista = txtMotorista.Text;
            oni.Aluno = txtAluno.Text;
            MessageBox.Show("Salvo com sucesso");
            oni.Salvar();
            Carrega_DataGrid();
            Limpar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var retorno = MessageBox.Show("Tem certeza que deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                oni = new Onibus();
                oni.ID = Convert.ToInt32(txtId.Text);
                oni.Excluir();
            }
            Carrega_DataGrid();
            Limpar();
        }
        private void Carrega_DataGrid()
        {
            oni = new Onibus();
            Dados.AutoGenerateColumns = false;
            Dados.DataSource = oni.Todos();
        }
        private void Limpar()
        {
            txtId.Text = null;
            txtDestino.Text = null;
            txtHora.Text = null;
            txtMotorista.Text = null;
            txtAluno.Text = null;
        }

       
    }
}
