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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }
        bool definirVisibilidadeDaSenha;


        private void btnVerSenha_Click(object sender, EventArgs e)
        {
            VerSenha();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {

                tb_usuario objUsuario = new tb_usuario();
                UsuarioDAO objDAO = new UsuarioDAO();

                bool verificarEmail = objDAO.ValidarEmail(txtEmail.Text);


                if (verificarEmail == true)
                {
                    
                    objUsuario.usuario_nome = txtNome.Text.Trim();
                    objUsuario.usuario_email = txtEmail.Text.Trim();
                    objUsuario.usuario_senha = txtSenha.Text.Trim();

                    try
                    {
                        objDAO.CadastrarUsuario(objUsuario);
                        MessageBox.Show("Usuario Cadastrado com sucesso", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ERRO ao cadastrar usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Email ja cadastrado no banco de dados", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            bool ret = true;
            string campos = "";

            if (txtNome.Text.Trim() == "")
            {
                ret = false;
                campos += "- Nome \n";
            }
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
            else if (txtSenha.Text != txtRepetirSenha.Text)
            {
                ret = false;
                campos += " - As senhas digitadas são diferentes:";
            }
            if (!ret)
            {
                MessageBox.Show("Preencha o(s) campo(s) abaixo: \n\n " + campos, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return ret;
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtSenha.Clear();
            txtRepetirSenha.Clear();
        }

        private void VerSenha()
        {
            if (definirVisibilidadeDaSenha == false)
            {
                txtSenha.PasswordChar = '\0';
                txtRepetirSenha.PasswordChar = '\0';
                definirVisibilidadeDaSenha = true;
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtRepetirSenha.PasswordChar = '*';
                definirVisibilidadeDaSenha = false;
            }
        }
    }
}
