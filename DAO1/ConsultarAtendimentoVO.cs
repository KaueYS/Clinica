using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO1
{
    public class ConsultarAtendimentoVO
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public string Cliente { get; set; } 
        public string Procedimento { get; set; }
        public string Colaborador { get; set; }
        public string Valor { get; set; }
        public string Historia { get; set; }
    }
}
