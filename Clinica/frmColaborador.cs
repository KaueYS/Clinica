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
    public partial class frmColaborador : Form
    {
        public frmColaborador()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                tb_colaborador objColaborador = new tb_colaborador();
                ColaboradorDAO1 objDao = new ColaboradorDAO1();

                objColaborador.colaborador_nome = txtNomeColaborador.Text.Trim();
                objColaborador.colaborador_funcao = txtFuncaoColaborador.Text.Trim();
                objColaborador.usuario_id = Util.CodigoLogado;

                try
                {
                    objDao.CadastrarColaborador(objColaborador);
                    MessageBox.Show("Colaborador cadastrado com sucessso!,", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Nao foi possivel cadastrar o colaborador", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ColaboradorDAO1 obDAO = new ColaboradorDAO1();
                tb_colaborador objColaborador = new tb_colaborador();

                objColaborador.colaborador_nome = txtNomeColaborador.Text;
                objColaborador.colaborador_funcao = txtFuncaoColaborador.Text;
                objColaborador.colaborador_id = Convert.ToInt32(txtCodigo.Text);

                try
                {
                    obDAO.AlterarColaborador(objColaborador);

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
            ColaboradorDAO1 colaboradorDAO1 = new ColaboradorDAO1();
            int cod = Convert.ToInt32(txtCodigo.Text);

            try
            {
                colaboradorDAO1.ExcluirColaborador(cod);
                MessageBox.Show("Colaborador excluido com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CarregarGrid();
                LimparCampos();
                ControlarTela(1);
            }
            catch (Exception)
            {
                MessageBox.Show("Colaborador Nao pode ser excluido, Possivelmente existem dados ja armazenados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            CarregarGrid();
            ControlarTela(1);

        }

        public void CarregarGrid()
        {
            ColaboradorDAO1 objDAO = new ColaboradorDAO1();
            List<tb_colaborador> listColaborador = objDAO.ConsultarColaborador(Util.CodigoLogado);
            grdCadastroDeColaborador.DataSource = listColaborador;

            grdCadastroDeColaborador.Columns["colaborador_id"].Visible = false;
            grdCadastroDeColaborador.Columns["usuario_id"].Visible = false;
            grdCadastroDeColaborador.Columns["tb_atendimento"].Visible = false;
            grdCadastroDeColaborador.Columns["tb_usuario"].Visible = false;
            //=============================================================
            grdCadastroDeColaborador.Columns["colaborador_nome"].HeaderText = "Nome do Colaborador";
            grdCadastroDeColaborador.Columns["colaborador_funcao"].HeaderText = "Função do Colaborador";

        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNomeColaborador.Text == "")
            {
                ret = false;
                campos += "- Nome do Colaborador \n";
            }
            if (txtFuncaoColaborador.Text.Trim() == "")
            {
                ret = false;
                campos += "- Função do Colaborador \n";
            }
            if (!ret)
            {
                MessageBox.Show("Preencha o campo abaixo: \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void LimparCampos()
        {
            txtNomeColaborador.Clear();
            txtFuncaoColaborador.Clear();
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

        private void grdCadastroDeColaborador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(grdCadastroDeColaborador.RowCount > 0)
            {
                tb_colaborador objLinhaClicada = grdCadastroDeColaborador.CurrentRow.DataBoundItem as tb_colaborador;
                txtCodigo.Text = objLinhaClicada.colaborador_id.ToString();
                txtNomeColaborador.Text = objLinhaClicada.colaborador_nome;
                txtFuncaoColaborador.Text = objLinhaClicada.colaborador_funcao;
                ControlarTela(2);
            }
        }
    }
}
