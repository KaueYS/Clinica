using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace DAO1
{
    public class ConsultarAtendimentoDAO
    {
        

        public List<ConsultarAtendimentoVO> FiltrarMovimento(int procedimento, DateTime dataInicial, DateTime dataFinal, int usuario)
        {
            banco objbanco = new banco();

            List<ConsultarAtendimentoVO> listaRetorno = new List<ConsultarAtendimentoVO>();

            List<tb_atendimento> listaConsulta = new List<tb_atendimento>();



            if (procedimento != -1)
            {
               listaConsulta = objbanco.tb_atendimento.Include("tb_servico")
                                                       .Include("tb_colaborador")
                                                       .Include("tb_cliente")
                                                       .Include("tb_usuario")


                                                  .Where(at =>
                                                  at.servico_id == procedimento &&
                                                  at.usuario_id == usuario &&
                                                  at.atendimento_data >= dataInicial &&
                                                  at.atendimento_data <= dataFinal).ToList();

            }
            else
            {
                

            }
            for (int i = 0; i < listaConsulta.Count; i++)
            {
                ConsultarAtendimentoVO vo = new ConsultarAtendimentoVO();
                vo.Id = listaConsulta[i].usuario_id;
                vo.Valor = Convert.ToString(listaConsulta[i].atendimento_valor);
                vo.Data = Convert.ToString(listaConsulta[i].atendimento_data);
                vo.Historia = listaConsulta[i].atendimento_historia;
                vo.Colaborador = listaConsulta[i].tb_colaborador.colaborador_nome;
                vo.Cliente = listaConsulta[i].tb_cliente.cliente_nomeCompleto;
                vo.Procedimento = listaConsulta[i].tb_servico.servico_nomeProcedimento;

                listaRetorno.Add(vo);

            }
            return listaRetorno;
        }

    }

}
