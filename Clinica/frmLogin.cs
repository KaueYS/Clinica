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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        bool definirVisibilidadeDaSenha;

        private void VerSenha()
        {


            if (definirVisibilidadeDaSenha == false)
            {
                txtSenha.PasswordChar = '\0';

                definirVisibilidadeDaSenha = true;
            }

            else
            {
                txtSenha.PasswordChar = '*';

                definirVisibilidadeDaSenha = false;
            }

        }
        private void btnAcessar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                UsuarioDAO usuarioDAO = new UsuarioDAO();
                int codLogado;

                codLogado = usuarioDAO.ValidarLogin(txtEmail.Text.Trim(), txtSenha.Text.Trim());

                if (codLogado == -1)
                {

                    MessageBox.Show("Usuario nao encontrado", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else
                {
                    Util.CodigoLogado = codLogado;
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastro frmCadastro = new frmCadastro();
            frmCadastro.ShowDialog();
        }

        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            VerSenha();
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";


            if (txtEmail.Text.Trim() == "")
            {
                ret = false;
                campos += " - Email\n";
            }
            if (txtSenha.Text.Trim() == "")
            {
                ret = false;
                campos += " - Senha \n";
            }
            else if (txtSenha.Text.Length < 6)
            {
                ret = false;
                campos += " - A senha deverá conter pelo menos 6 caracteres";
            }

            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s) abaixo: \n\n " + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }
    }
}
