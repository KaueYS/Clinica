using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class UsuarioDAO
    {
        public void CadastrarUsuario(tb_usuario objUsuario)
        {
            //Instanciar o banco de dado (banco)
            banco objbanco = new banco();
            
            //Adiciona a tabela usuario na variavel
            objbanco.tb_usuario.Add(objUsuario);
            
            // Salvar o banco de dados
            objbanco.SaveChanges();

        }

        public int ValidarLogin(string email, string senha)
        {
            banco objbanco = new banco();
            tb_usuario userLogado = objbanco.tb_usuario.Where(u => u.usuario_email == email && u.usuario_senha == senha).FirstOrDefault();

            if (userLogado == null)
            {
                return -1;
            }
            else
            {
                return userLogado.usuario_id;
            }
        }

        public bool ValidarEmail(string emailCadastrado)
        {
            banco objbanco = new banco();

            tb_usuario emailDuplicado = objbanco.tb_usuario.Where(e => e.usuario_email == emailCadastrado).FirstOrDefault();



            if (emailDuplicado == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
