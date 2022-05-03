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
    public partial class frmServico : Form
    {
        public frmServico()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_servico objPrecedimento = new tb_servico();
                ServicoDAO objDAO = new ServicoDAO();

                objPrecedimento.servico_nomeProcedimento = txtProcedimento.Text.Trim();
                objPrecedimento.usuario_id = Util.CodigoLogado;

                try
                {
                    objDAO.CadastrarProcedimento(objPrecedimento);
                    MessageBox.Show("Procedimento cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel cadastrar o procedimento", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CarregarGrid();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            ControlarTela(1);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ServicoDAO objDAO = new ServicoDAO();
                tb_servico objServico = new tb_servico();

                objServico.servico_nomeProcedimento = txtProcedimento.Text.Trim();
                objServico.servico_id = Convert.ToInt32(txtCodigo.Text.Trim());

                try
                {
                    objDAO.AlterarServico(objServico);
                    MessageBox.Show("Colaborador e função Alterada com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CarregarGrid();
                    LimparCampos();
                    ControlarTela(1);

                }
                catch (Exception)
                {

                    MessageBox.Show("Colaborador e/ou função Não pode ser alterada", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ServicoDAO objDAO = new ServicoDAO();
            int cod = Convert.ToInt32(txtCodigo.Text);

            try
            {
                objDAO.ExcluirServico(cod);
                MessageBox.Show("Procedimento excluido com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                LimparCampos();
                ControlarTela(1);
            }
            catch (Exception)
            {
                MessageBox.Show("Exclusao nao pode ser completada, esta sendo utilizada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                        
        }

        private void frmServico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ControlarTela(1);
        }

        private void grdCadastroDeProcedimento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCadastroDeProcedimento.Rows.Count > 0)
            {
                tb_servico objlinhaClicada = grdCadastroDeProcedimento.CurrentRow.DataBoundItem as tb_servico;

                txtCodigo.Text = objlinhaClicada.servico_id.ToString();
                txtProcedimento.Text = objlinhaClicada.servico_nomeProcedimento;
                ControlarTela(2);

            }
        }

        private void CarregarGrid()
        {
            ServicoDAO objDAO = new ServicoDAO();
            List<tb_servico> listServico = objDAO.ConsultarProcedimento(Util.CodigoLogado);
            grdCadastroDeProcedimento.DataSource = listServico;

            grdCadastroDeProcedimento.Columns["servico_id"].Visible = false;

            grdCadastroDeProcedimento.Columns["usuario_id"].Visible = false;
            grdCadastroDeProcedimento.Columns["tb_usuario"].Visible = false;
            grdCadastroDeProcedimento.Columns["tb_atendimento"].Visible = false;
            grdCadastroDeProcedimento.Columns["servico_nomeProcedimento"].HeaderText = "Nome do Procedimento";

        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtProcedimento.Text == "")
            {
                ret = false;
                campos += "- Nome do Procedimento \n";
            }
            if (!ret)
            {
                MessageBox.Show("Preencha o campo abaixo \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void ControlarTela(int estado)
        {
            switch (estado)
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

        private void LimparCampos()
        {
            txtProcedimento.Clear();
        }
    }
}
