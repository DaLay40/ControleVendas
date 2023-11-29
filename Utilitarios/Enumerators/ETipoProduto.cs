using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.Enumerators
{
    public enum ETipoProduto
    {
        [Description("PADRÃO")]
        Padrao = 0,
        [Description("PRONTA ENTREGA")]
        ProtaEntrega = 1
    }
}
