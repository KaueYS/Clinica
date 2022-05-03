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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }
        //=================================================================

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                ClienteDAO1 objDAO = new ClienteDAO1();
                tb_cliente objCliente = new tb_cliente();

                objCliente.cliente_nomeCompleto = txtNomeCompleto.Text.Trim();
                objCliente.cliente_dataNascimento = dtNascimento.Value.Date;
                objCliente.cliente_nomeMae = txtNomeMae.Text.Trim();
                objCliente.cliente_cpf = mskCPF.Text;
                objCliente.cliente_nomePai = txtNomePai.Text.Trim();
                objCliente.cliente_estadoCivil = Convert.ToInt16(cbEstadoCivil.SelectedIndex);
                objCliente.cliente_nomeConjuge = txtNomeConjuge.Text.Trim();
                objCliente.cliente_email = txtEmail.Text.Trim();
                objCliente.cliente_telefone = mskCelular.Text;
                objCliente.cliente_cep = txtCep.Text.Trim();
                objCliente.cliente_endereco = txtEndereco.Text.Trim();
                objCliente.cliente_numero = txtNumeroCasa.Text.Trim();
                objCliente.cliente_bairro = txtBairro.Text.Trim();
                objCliente.cliente_cidade = txtCidade.Text.Trim();
                objCliente.usuario_id = Util.CodigoLogado;
                
                try
                {
                    objDAO.CadastrarCliente(objCliente);
                    MessageBox.Show("Cliente cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();

                }
                catch (Exception)
                {
                    MessageBox.Show("Cliente nao pode ser cadastrado, refaça a operação", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        //=================================================================

        private void btnCep_Click(object sender, EventArgs e)
        {
            string cidade, bairro, rua;
            ConsultarCepVO res;

            if (txtCep.Text.Trim() == "")
            {
                MessageBox.Show("Preencha o campo CEP corretamente");
            }
            else
            {
                try
                {
                    using (var ws = new WSCorreios.AtendeClienteClient())
                    {
                        var endereco = ws.consultaCEP(txtCep.Text);
                        txtCidade.Text = endereco.cidade;

                        txtBairro.Text = endereco.bairro;
                        txtEndereco.Text = endereco.end;
                    }

                    cidade = txtCidade.Text;
                    bairro = txtBairro.Text;
                    rua = txtEndereco.Text;

                    res = FuncaoConsultarCep(cidade, bairro, rua);

                }
                catch (Exception ex)
                {
                    txtCep.Clear();
                    MessageBox.Show("Digite um CEP válido");
                    txtCep.Focus();
                }
            }
        }

        private ConsultarCepVO FuncaoConsultarCep(string cidade, string bairro, string rua)
        {
            ConsultarCepVO consultarCep = new ConsultarCepVO(cidade, bairro, rua);

            consultarCep.Cidade = cidade;
            consultarCep.Bairro = bairro;
            consultarCep.Rua = rua;
            return consultarCep;
        }


        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNomeCompleto.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome Completo \n ";
            }
            if (txtNomeMae.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome da Mãe \n";
            }
            if (mskCPF.Text == "")
            {
                ret = false;
                campos += "- CPF \n";
            }
            if (txtNomePai.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome do Pai \n";
            }
            if (cbEstadoCivil.SelectedIndex == -1)
            {
                ret = false;
                campos += "- Estado Civil \n";
            }
            

            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += "- E-mail \n";
            }
            if (mskCelular.Text == "")
            {
                ret = false;
                campos += "- Telefone \n";
            }
            if (txtCep.Text == "")
            {
                ret = false;
                campos += "- CEP \n";
            }
            if (txtEndereco.Text.Trim() == "")
            {
                ret = false;
                campos += "- Endereço \n";
            }
            if (txtNumeroCasa.Text.Trim() == "")
            {
                ret = false;
                campos += "- Numero da casa \n";
            }
            if (txtBairro.Text.Trim() == "")
            {
                ret = false;
                campos += "- Bairro \n";
            }
            if (txtCidade.Text.Trim() == "")
            {
                ret = false;
                campos += "- Cidade \n";
            }


            if (!ret)
            {
                MessageBox.Show("Complete os campos solicitados \n\n" + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

            private void LimparCampos()
        {
            txtBairro.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNomeCompleto.Clear();
            txtNomeConjuge.Clear();
            txtNomeMae.Clear();
            txtNomePai.Clear();
            txtNumeroCasa.Clear();
            dtNascimento.Value = DateTime.Now;
            cbEstadoCivil.SelectedIndex = -1;
        }
    }
}
