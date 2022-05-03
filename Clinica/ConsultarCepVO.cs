using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica
{
    public class ConsultarCepVO
    {
        public ConsultarCepVO(string cidade, string bairro, string rua)
        {
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
        }

        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
    }
}
