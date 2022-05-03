using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void procedimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAtendimento atendimento = new frmAtendimento();
            atendimento.ShowDialog();
        }

        private void cadastroClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();  
            cliente.ShowDialog();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColaborador medico = new frmColaborador();
            medico.ShowDialog();
        }

        private void serviçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmServico servico = new frmServico();
            servico.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarAtendimento consultar = new frmConsultarAtendimento();  
            consultar.ShowDialog();
        }
    }
}
