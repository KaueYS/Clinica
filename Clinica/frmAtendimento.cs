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
    public partial class frmAtendimento : Form
    {
        public frmAtendimento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AtendimentoDAO1 objDAO = new AtendimentoDAO1();
                tb_atendimento objAtendimento = new tb_atendimento();

                objAtendimento.atendimento_valor = Convert.ToDecimal(txtValor.Text.Trim());
                objAtendimento.atendimento_data = dtDataAtendimento.Value.Date;
                objAtendimento.atendimento_historia = txtHistoria.Text.Trim();
                objAtendimento.cliente_id = Convert.ToInt32(cbNomePaciente.SelectedValue);
                objAtendimento.servico_id = Convert.ToInt32(cbProcedimentoExecutado.SelectedValue);
                objAtendimento.colaborador_id = Convert.ToInt32(cbMedico.SelectedValue);
                objAtendimento.usuario_id = Util.CodigoLogado;

                try
                {
                    objDAO.CadastrarAtendimento(objAtendimento);
                    MessageBox.Show("Atendimento Cadastrado com sucessso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimparCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Atendimento Não Cadastrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                CarregarGrd();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                AtendimentoDAO1 objDAO = new AtendimentoDAO1();
                tb_atendimento objAtendimento = new tb_atendimento();

                objAtendimento.atendimento_data = dtDataAtendimento.Value.Date;
                objAtendimento.atendimento_valor = Convert.ToDecimal(txtValor.Text);
                objAtendimento.atendimento_id = Convert.ToInt32(txtCodigo.Text);
                objAtendimento.atendimento_historia = txtHistoria.Text;
                objAtendimento.cliente_id = Convert.ToInt32(cbNomePaciente.SelectedValue);
                objAtendimento.colaborador_id = Convert.ToInt32(cbMedico.SelectedValue);
                objAtendimento.servico_id = Convert.ToInt32(cbProcedimentoExecutado.SelectedValue);

                try
                {
                    objDAO.AlterarAtendimento(objAtendimento);
                    MessageBox.Show("Alterações Cadastradas com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregarGrd();
                    LimparCampos();
                    ControlarTela(1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel Alterar o atendimento", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AtendimentoDAO1 objAtendimentoDAO1 = new AtendimentoDAO1();
            int cod = Convert.ToInt32(txtCodigo.Text);

            try
            {
                objAtendimentoDAO1.ExcluirAtendimento(cod);

                MessageBox.Show("Exclusao realizada com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrd();

                LimparCampos();
                ControlarTela(1);
            }
            catch (Exception)
            {
                MessageBox.Show("Exclusao realizada, possivelmente ja existem itens salvos", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAtendimentos_Load(object sender, EventArgs e)
        {
            CarregarComboProcedimento();
            CarregarComboColaborador();
            CarregarComboCliente();
            CarregarGrd();

            ControlarTela(1);
        }

        //Carregar combo procedimento
        public void CarregarComboProcedimento()
        {
            ServicoDAO objDAO = new ServicoDAO();
            List<tb_servico> lstAtendimento = objDAO.ConsultarProcedimento(Util.CodigoLogado);

            cbProcedimentoExecutado.ValueMember = "servico_id";
            cbProcedimentoExecutado.DisplayMember = "servico_nomeProcedimento";

            cbProcedimentoExecutado.DataSource = lstAtendimento;

            cbProcedimentoExecutado.SelectedIndex = -1;

            cbProcedimentoExecutado.Focus();
        }

        //Carregar combo cliente
        public void CarregarComboCliente()
        {
            ClienteDAO1 objDAO = new ClienteDAO1();
            List<tb_cliente> lstCliente = objDAO.ConsultarCliente(Util.CodigoLogado);

            cbNomePaciente.ValueMember = "cliente_id";
            cbNomePaciente.DisplayMember = "cliente_nomeCompleto";

            cbNomePaciente.DataSource = lstCliente;

            cbNomePaciente.SelectedIndex = -1;
        }

        //Carregar combo Colaborador
        public void CarregarComboColaborador()
        {
            ColaboradorDAO1 objDAO = new ColaboradorDAO1();
            List<tb_colaborador> lstCliente = objDAO.ConsultarColaborador(Util.CodigoLogado);

            cbMedico.ValueMember = "colaborador_id";
            cbMedico.DisplayMember = "colaborador_Nome";

            cbMedico.DataSource = lstCliente;

            cbMedico.SelectedIndex = -1;
        }
        //================================================================

        private void ControlarTela(int estadoDaTela)
        {
            switch (estadoDaTela)
            {
                case 1:
                    btnCadastrar.Enabled = true;
                    btnAlterar.Enabled = false;
                    btnExcluir.Enabled = false;
                    break;
                case 2:
                    btnCadastrar.Enabled = false;
                    btnAlterar.Enabled = true;
                    btnExcluir.Enabled = true;
                    break;
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (cbProcedimentoExecutado.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Procedimento executado \n";
            }
            if (cbNomePaciente.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Nome do paciente \n";
            }
            if (txtValor.Text == "")
            {
                ret = false;
                campos += "- Valor \n";
            }
            if (cbMedico.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Profissional \n";
            }
            if (!ret)
            {
                MessageBox.Show("Para continuar, Preencha os campos abaixo: \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void LimparCampos()
        {
            txtHistoria.Clear();
            txtValor.Clear();
            cbMedico.SelectedIndex = -1;
            cbNomePaciente.SelectedIndex = -1;
            cbProcedimentoExecutado.SelectedIndex = -1;
            ControlarTela(1);
        }

        private void grdAtendimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdAtendimento.RowCount > 0)
            {
                AtendimentoVO objLinha = grdAtendimento.CurrentRow.DataBoundItem as AtendimentoVO;
                tb_atendimento objPreencherGrid = objLinha.objAtend;

                dtDataAtendimento.Value = objPreencherGrid.atendimento_data;
                cbProcedimentoExecutado.SelectedValue = objPreencherGrid.servico_id;
                cbNomePaciente.SelectedValue = objPreencherGrid.cliente_id;
                txtValor.Text = Convert.ToString(objPreencherGrid.atendimento_valor);
                cbMedico.SelectedValue = objPreencherGrid.colaborador_id;
                txtHistoria.Text = objPreencherGrid.atendimento_historia;
                txtCodigo.Text = Convert.ToString(objPreencherGrid.atendimento_id);
                
                ControlarTela(2);
            }
        }

        private void CarregarGrd()
        {

            {
                AtendimentoDAO1 atendimentoDAO = new AtendimentoDAO1();

                List<AtendimentoVO> lista = new List<AtendimentoVO>();
                lista = atendimentoDAO.CarregarGridAtendimento(Util.CodigoLogado);

                if (lista.Count > 0)
                {
                    grdAtendimento.DataSource = lista;
                    grdAtendimento.Columns["Id"].Visible = false;
                    grdAtendimento.Columns["objAtend"].Visible = false;
                }
                else
                {
                    grdAtendimento.DataSource = null;
                    MessageBox.Show("A lista esta vazia, cadastre um procedimento antes de filtrar");
                }
            }
        }
    }
}
