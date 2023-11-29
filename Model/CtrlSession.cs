using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Model
{
    public static class CtrlSession
    {

        public static ControleVendasEntities context = new ControleVendasEntities();

        public static List<Cliente> Clientes = new List<Cliente>();    
        public static List<Marca> Marcas = new List<Marca>();
        public static List<Pedido> Pedidos = new List<Pedido>();
        public static List<Produto> Produtos = new List<Produto>();

        public static void GerarListas()
        {
            AtualizarListaClientes();
            AtualizarListaMarcas();
            AtualizarListaPedidos();
            AtualizarListaProdutos();
            Observacao.GeraLista();
        }

        public static void AtualizarListaMarcas()
        {
            Marcas = context.Marca.ToList();

        }
        public static void AtualizarListaClientes()
        {
            Clientes = context.Cliente.ToList();
        }
        public static void AtualizarListaPedidos()
        {
            Pedidos = context.Pedido.ToList();
        }
        public static void AtualizarListaProdutos()
        {
            Produtos = context.Produto.ToList();
        }

        public static decimal CalcularComissao(this List<ItensPedido> lista)
        {
            decimal valor = 0;
            foreach (var i in lista)
            {
                decimal porcentagem = i.Produto.Marca.PorcentagemComicao.Value;
                decimal valorProd = i.Produto.ValorProduto.Value;

                if (valor == 0)
                    valor = ((porcentagem * valorProd) / 100);
                else
                    valor += ((porcentagem * valorProd) / 100);

            }
            return valor;
        }
    }
}
