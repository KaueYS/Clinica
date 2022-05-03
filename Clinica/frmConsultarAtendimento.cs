using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO1;

namespace Clinica
{
    public partial class frmConsultarAtendimento : Form
    {
        public frmConsultarAtendimento()
        {
            InitializeComponent();
        }

        private void frmConsultarAtendimento_Load(object sender, EventArgs e)
        {
            CarregarComboProcedimento();
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            Filtrar();
        }

        private void Filtrar()
        {
            ConsultarAtendimentoDAO consultarAtendimentoDAO = new ConsultarAtendimentoDAO();
            int procedimento = Convert.ToInt32(cbFiltrarConsutaAtendimento.SelectedValue);
            
            DateTime datainicial = dtFiltrarInicio.Value.Date;
            DateTime datafinal = dtFiltrarFinal.Value.Date;

            List<ConsultarAtendimentoVO> lista = new List<ConsultarAtendimentoVO>();
            lista = consultarAtendimentoDAO.FiltrarMovimento(procedimento, datainicial, datafinal, Util.CodigoLogado);

            if (lista.Count > 0)
            {
                grdFiltroAtendimento.DataSource = lista;
                grdFiltroAtendimento.Columns["Id"].Visible = false;
                
            }
            else
            {
                grdFiltroAtendimento.DataSource = null;
                MessageBox.Show("A lista esta vazia, cadastre um procedimento antes de filtrar");
            }


        }

        public void CarregarComboProcedimento()
        {
            ServicoDAO objDAO = new ServicoDAO();
            List<tb_servico> lstAtendimento = objDAO.ConsultarProcedimento(Util.CodigoLogado);

            cbFiltrarConsutaAtendimento.ValueMember = "servico_id";
            cbFiltrarConsutaAtendimento.DisplayMember = "servico_nomeProcedimento";

            cbFiltrarConsutaAtendimento.DataSource = lstAtendimento;

            cbFiltrarConsutaAtendimento.SelectedIndex = -1;
        }
    }
}
