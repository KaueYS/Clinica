using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class ColaboradorDAO1
    {
        public void CadastrarColaborador(tb_colaborador objColaborador)
        {
            // instancia o sql server (banco) para ser utilizado para resgatar os itens
            banco objBanco = new banco();

            objBanco.tb_colaborador.Add(objColaborador);
            objBanco.SaveChanges();
        }

        public List<tb_colaborador> ConsultarColaborador(int codigoLogado)
        {
            banco objBanco = new banco();
            List<tb_colaborador> objList = objBanco.tb_colaborador.Where(colaborador => colaborador.usuario_id == codigoLogado).ToList();
            return objList;

        }

        public void AlterarColaborador(tb_colaborador objColaborador)
        {
            banco objbanco = new banco();
            tb_colaborador objUpDate = objbanco.tb_colaborador.Where(col => col.colaborador_id == objColaborador.colaborador_id).FirstOrDefault();
            objUpDate.colaborador_nome = objColaborador.colaborador_nome;
            objUpDate.colaborador_funcao = objColaborador.colaborador_funcao;
            objbanco.SaveChanges();

        }

        public void ExcluirColaborador(int colaboradorId)
        {
            banco objBanco = new banco();
            tb_colaborador objExcluir = objBanco.tb_colaborador.Where(col => col.colaborador_id == colaboradorId).FirstOrDefault(); 
            objBanco.tb_colaborador.Remove(objExcluir);
            objBanco.SaveChanges();

        }


        
    }
}