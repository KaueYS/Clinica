using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class ClienteDAO1
    {
        public void CadastrarCliente(tb_cliente objCliente)
        {
            banco objBanco = new banco();
            objBanco.tb_cliente.Add(objCliente);
            objBanco.SaveChanges();
        }



        public List<tb_cliente> ConsultarCliente(int codigoLogado)
        {
            banco objBanco = new banco();
            List<tb_cliente> objList = objBanco.tb_cliente.Where(cli => cli.usuario_id == codigoLogado).ToList();
            return objList;
        }
    }
}
