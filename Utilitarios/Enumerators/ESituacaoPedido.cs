using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.Enumerators
{
    public enum ESituacaoPedido
    {
        [Description("Em Andamento")]
        EmAndamento,
        [Description("Cancelado")]
        Cancelado,
        [Description("Finalizado")]
        Finalizado
    }
}
