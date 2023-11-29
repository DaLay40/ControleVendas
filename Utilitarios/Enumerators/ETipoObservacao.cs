using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios.Enumerators
{
    public enum ETipoObservacao
    {
        [Description("Item Pedido")]
        ItemPedido,
        [Description("Pedido")]
        Pedido,
        [Description("Produto")]
        Produto

    }
}
