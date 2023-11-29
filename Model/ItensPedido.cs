//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    using Utilitarios.Enumerators;
    using Utilitarios.Extencions;

    public partial class ItensPedido
    {
        public long Id { get; set; }
        public Nullable<long> PedidoId { get; set; }
        public Nullable<byte> Situacao { get; set; }
        public Nullable<long> ProdutoId { get; set; }
        public Nullable<int> Quantidade { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
    
        public virtual Produto Produto { get; set; }

        public virtual String ValorTotalFormatado { get { return this.ValorTotal.Value.ToString("C"); } }
        public virtual String ProdutoDescricao { get { return this.Produto.IsNull() ? "" : this.Produto.Descricao; } }
        public virtual String ValorProdutoFormatado { get { return this.Produto.IsNull() ? "" : this.Produto.ValorProduto.Value.ToString("C"); } }
        public virtual String CodigoProduto { get { return this.Produto.IsNull() ? "" : this.Produto.CodigoProduto.ToString(); } }
        public virtual String ProdutoMarca { get { return this.Produto.IsNull() ? "" : this.Produto.MarcaNome; } }
        public virtual String ObservacaosConcatenadas { get { return Observacao.GetObservacoes(ETipoObservacao.ItemPedido, this.Id); } }

    }
}
