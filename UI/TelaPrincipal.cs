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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }
        Form tela;
        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnMotoristas_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaMotorista
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            telaPainel.Controls.Add(tela);
            tela.Show();
        }

        private void telaPainel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAluno_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaAluno
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None,
            };
            telaPainel.Controls.Add(tela);
            tela.Show();

        }
    }
}
