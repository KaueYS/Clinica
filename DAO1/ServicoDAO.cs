using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class ServicoDAO
    {
        public void CadastrarProcedimento(tb_servico objProcedimento)
        {
            banco objBanco = new banco();
            objBanco.tb_servico.Add(objProcedimento);
            objBanco.SaveChanges();

        }

        public List<tb_servico> ConsultarProcedimento(int codigoLogado)
        {
            banco objBanco = new banco();
            List<tb_servico> objList = objBanco.tb_servico.Where(servico => servico.usuario_id == codigoLogado).ToList();
            return objList;
        }
        
        public void AlterarServico(tb_servico objServico)
        {
            banco objBanco = new banco();
            tb_servico objUpdate = objBanco.tb_servico.Where(serv => serv.servico_id == objServico.servico_id).FirstOrDefault();
            objUpdate.servico_nomeProcedimento = objServico.servico_nomeProcedimento;
            objBanco.SaveChanges();
        }

        public void ExcluirServico(int ServicoId)
        {
            banco banco = new banco();
            tb_servico objExcluir = banco.tb_servico.Where(serv => serv.servico_id == ServicoId).FirstOrDefault();
            banco.tb_servico.Remove(objExcluir);
            banco.SaveChanges();

        }

    }
}
