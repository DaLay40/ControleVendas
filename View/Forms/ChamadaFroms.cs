using Model;
using System;
using Utilitarios;
using Utilitarios.Enumerators;

namespace View.Forms
{
    public class ChamadaFroms
    {

        public static DevExpress.XtraEditors.XtraForm Inicial()
        {
            CtrlSession.GerarListas();
            return new frmInicio();
        }

        public static void TelaPedidos()
        {
            using (FrmPedido form = new FrmPedido())
                form.ShowDialog();
            CtrlSession.AtualizarListaPedidos();
        }

        public static void TelaPedidos(Pedido oPedido)
        {
            using (FrmPedido form = new FrmPedido(oPedido))
            {
                form.ShowDialog();
            }
            CtrlSession.AtualizarListaPedidos();
        }

        public static void Marca()
        {
            using (frmMarca form = new frmMarca())
                form.ShowDialog();
            CtrlSession.AtualizarListaMarcas();
        }

        public static object Consultar(ETipoConsulta Tipo)
        {
            using (FrmConsulta form = new FrmConsulta(Tipo))
                return form.Consultar();
        }

        public static void Observacao(ETipoObservacao Tipo,Int64 IdPrimary)
        {
            using (frmObservacao form = new frmObservacao(Tipo,IdPrimary))
            {
                form.ShowDialog();
            }
            Model.Observacao.GeraLista();
        }

        public static decimal CalcularValor()
        {
            using (frmEstipularValor form = new frmEstipularValor())
                return form.Abrir();
        }
        public static decimal CalcularValor(decimal valor)
        {
            using (frmEstipularValor form = new frmEstipularValor(valor))
                return form.Abrir();
        }

        public static void Produtos()
        {
            using (frmProdutos form = new frmProdutos())
                 form.ShowDialog();
            CtrlSession.AtualizarListaProdutos();
        }

        public static void Rel001()
        {
            frmRel001ProdutosMaisVendidos form = new frmRel001ProdutosMaisVendidos();
            form.Show();
        }
        public static void Estoque()
        {
            frmEstoqueProdutos form = new frmEstoqueProdutos();
            form.Show();
        }
    }
}
