using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTOS
{
    public class rel001ProdutosMaisVendidos : relBase
    {

        public Int64? Id { get; set; }
        public String Descricao { get; set; }
        public Int32? Quantidade { get; set; }
        public Decimal? ValorTotal { get; set; }
        public String Marca { get; set; }

    }
}
