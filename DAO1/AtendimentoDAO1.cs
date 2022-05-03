using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO1;

namespace DAO1
{
    public class AtendimentoDAO1
    {

        public List<AtendimentoVO> CarregarGridAtendimento(int usuario)
        {
            banco objbanco = new banco();

            List<AtendimentoVO> listaRetorno = new List<AtendimentoVO>();

            List<tb_atendimento> listaConsulta = new List<tb_atendimento>();



            
                listaConsulta = objbanco.tb_atendimento.Include("tb_servico")
                                                        .Include("tb_colaborador")
                                                        .Include("tb_cliente")
                                                        .Include("tb_usuario")
                                    .Where(at => at.usuario_id == usuario).ToList();


            for (int i = 0; i < listaConsulta.Count; i++)
            {
                AtendimentoVO vo = new AtendimentoVO();
                vo.Id = listaConsulta[i].usuario_id;
                vo.Valor = Convert.ToString(listaConsulta[i].atendimento_valor);
                vo.Data = listaConsulta[i].atendimento_data.ToShortDateString();
                vo.Historia = listaConsulta[i].atendimento_historia;
                vo.Colaborador = listaConsulta[i].tb_colaborador.colaborador_nome;
                vo.Cliente = listaConsulta[i].tb_cliente.cliente_nomeCompleto;
                vo.Procedimento = listaConsulta[i].tb_servico.servico_nomeProcedimento;
                
                //popula para editar na grid
                vo.objAtend = listaConsulta[i];

                

                listaRetorno.Add(vo);

            }
            return listaRetorno;
        }

        public void CadastrarAtendimento(tb_atendimento objAtendimento)
        {
            banco objBanco = new banco();
            objBanco.tb_atendimento.Add(objAtendimento);
            objBanco.SaveChanges();

        }


        public void AlterarAtendimento(tb_atendimento objAtendimento)
        {
            banco objBanco = new banco();
            tb_atendimento objUpDate = objBanco.tb_atendimento.Where(atend => atend.atendimento_id == objAtendimento.atendimento_id).FirstOrDefault();

            objUpDate.atendimento_data = objAtendimento.atendimento_data;
            objUpDate.atendimento_historia = objAtendimento.atendimento_historia;
            objUpDate.atendimento_valor = objAtendimento.atendimento_valor;
            objUpDate.cliente_id = objAtendimento.cliente_id;
            objUpDate.colaborador_id = objAtendimento.colaborador_id;
            objUpDate.servico_id = objAtendimento.servico_id;
            objBanco.SaveChanges();
           
        }

        public void ExcluirAtendimento(int atendimentoId)
        {
            banco objBanco = new banco();
            tb_atendimento excluirAtendimentro = objBanco.tb_atendimento.Where(atend => atend.atendimento_id == atendimentoId).FirstOrDefault();
            objBanco.tb_atendimento.Remove(excluirAtendimentro);
            objBanco.SaveChanges();

        }
    }
}
