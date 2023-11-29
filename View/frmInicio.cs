using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using View.Forms;
using Utilitarios;
using Utilitarios.Enumerators;
using Model;
using Utilitarios.Extencions;
using Utilitarios.Classes;

namespace View
{
    public partial class frmInicio : DevExpress.XtraEditors.XtraForm
    {

        BindingSource bindingPedidos = new BindingSource();

        public frmInicio()
        {
            InitializeComponent();
            DelegaEventos();
            DataLoad();
        }

        private void DelegaEventos()
        {
            this.btnNovoPedido.Click += EventoClickNovoPedido;
            this.btnMarca.Click += EventoClickMarca;
            this.btnProdutos.Click += EventoClickProdutos;
            this.btnEditarPedido.Click += EventoEditarPedido;
            this.btnFinalizarPedido.Click += EventoMudarSituacaoPedido;
            this.btnCancelarPedido.Click += EventoMudarSituacaoPedido;
            this.btnIncluirObservacoes.Click += EventoIncluirObservacao;

            this.cboMarca.EditValueChanged += EventoFiltrar;
            this.cboSituacao.EditValueChanged += EventoFiltrar;
            this.dtInicio.EditValueChanged += EventoFiltrar;
            this.dtFim.EditValueChanged += EventoFiltrar;

            this.btnRel001_MaisVendidos.Click += EventoTelaFiltroRel001;
            this.btnEstoque.Click += EventoAbrirEstoque;
        }




        #region Eventos 
        private void EventoEditarPedido(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            ChamadaFroms.TelaPedidos(pedido);
           
        }
        private void EventoClickNovoPedido(object sender, EventArgs e)
        {
            ChamadaFroms.TelaPedidos();
            CtrlSession.AtualizarListaPedidos();
            DataLoad();
        }
        private void EventoClickMarca(object sender, EventArgs e)
        {
            ChamadaFroms.Marca();
        }
        private void EventoFiltrar(object sender, EventArgs e)
        {
            Int64? IdMarca = null;
            int? IdSituacao = null;
            DateTime? DataInicio = null;
            DateTime? DataFim = null;

            DataInicio = this.dtInicio.DateTime;
            DataFim = this.dtFim.DateTime;

            if (this.cboMarca.Validar())
                IdMarca = (Int64)this.cboMarca.SelectedValue;

            if (this.cboSituacao.Validar())
                IdSituacao = (int)this.cboSituacao.SelectedValue;

            List<Pedido> lista = (from p in CtrlSession.Pedidos where (IdMarca.IsNull() || p.ItensPedido.Any(x => x.Produto.MarcaId == IdMarca))
                                  && (IdSituacao.IsNull() || p.Situacao == IdSituacao)
                                  && p.Data >= DataInicio && p.Data <= DataFim select p).ToList();

            AtualizarListaPedidos(lista);
        }
        private void EventoMudarSituacaoPedido(object sender, EventArgs e)
        {
            Pedido oPedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;

            if (sender.Equals(this.btnFinalizarPedido))
            {
                oPedido.Situacao = (Byte)ESituacaoPedido.Finalizado;
            }
            else if (sender.Equals(this.btnCancelarPedido))
            {
                oPedido.Situacao = (Byte)ESituacaoPedido.Cancelado;
            }
            CtrlSession.context.SaveChanges();
            this.gridPedidos.RefreshDataSource();
        }
        private void EventoIncluirObservacao(object sender, EventArgs e)
        {
            Pedido pedido = (Pedido)this.bindingPedidos.CurrencyManager.Current;
            ChamadaFroms.Observacao(ETipoObservacao.Pedido, pedido.Id);

        }
        private void EventoClickProdutos(object sender, EventArgs e)
        {
            ChamadaFroms.Produtos();
        }
        private void EventoTelaFiltroRel001(object sender, EventArgs e)
        {
            ChamadaFroms.Rel001();
        }

        private void EventoAbrirEstoque(object sender, EventArgs e)
        {
            ChamadaFroms.Estoque();
        }
        #endregion

        #region Metodos

        private void DataLoad()
        {
            AtualizarListaPedidos(CtrlSession.Pedidos);
            CarregarComboMarca();
            CarregarComboSituacao();
            SetValorPadrao();
            CalcularValorComissao();
        }

        private void CarregarComboMarca()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca", true);
        }

        private void CarregarComboSituacao()
        {
            this.cboSituacao.SetDataSource(Util.GetDataSource(typeof(ESituacaoPedido)), "Value", "Key", "Key", "Situação",true);
        }

        private void AtualizarListaPedidos(List<Pedido> lista)
        {
            this.bindingPedidos.DataSource = lista;
            this.gridPedidos.DataSource = this.bindingPedidos;
            this.gridPedidos.RefreshDataSource();
        }

        private void SetValorPadrao()
        {
            DateTime primeiroDia = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1);
            DateTime ultimoDia = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month));
            this.dtInicio.DateTime = primeiroDia;
            this.dtFim.DateTime = ultimoDia;
            this.cboSituacao.SelectedValue = ESituacaoPedido.EmAndamento;
        }

        private void CalcularValorComissao()
        {
            this.lblValorTotalComissao.Text = CtrlSession.Pedidos.Sum(x => x.ValorTotalComicao.Value).ToString("C");
        }

        #endregion

        
    }
}