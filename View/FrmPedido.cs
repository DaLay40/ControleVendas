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
using Utilitarios;
using Model;
using Utilitarios.Enumerators;
using Utilitarios.Extencions;
using Utilitarios.MyMsg;
using View.Forms;

namespace View
{
    public partial class FrmPedido : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bindingItems = new BindingSource();

        private List<ItensPedido> Items = new List<ItensPedido>();
        private Pedido oPedido = new Pedido();
        private bool Salvo;
        public FrmPedido()
        {
            InitializeComponent();
            DelegarEventos();
            DataLoad();
        }

        public FrmPedido(Pedido oPedidoParam)
        {
            InitializeComponent();
            DelegarEventos();
            this.oPedido = oPedidoParam;
            DataLoad();
        }

        private void DelegarEventos()
        {
            this.btnAdicionarNovoCliente.Click += EventoAdicionarNovoCliente;
            this.btnAdicionarProduto.Click += EventoAdicionarProduto;
            this.btnEstipularValor.Click += EventoEstipularValor;
            this.btnSalvarPedido.Click += EventoSalvarPedido;
            this.btnNovaMarca.Click += EventoNovaMarca;
            this.spinNumeroParcelas.EditValueChanged += EventoChengeNumeroParcelas;
            this.contextMenuPedido.Opening += EventoAbrirMenuStrip;
            this.excluirItemToolStripMenuItem.Click += EventoExcluirItem;
            this.btnIncluirObservacao.Click += EventoIncluirObservacaoItemPedido;
            this.FormClosing += EventoFechamentoDaTela;
        }

        #region Eventos

        private void EventoAdicionarProduto(object sender, EventArgs e)
        {
            Produto oProduto;

            if (!this.cboProduto.Validar())
                oProduto = CadastrarNovoProduto();
            else
                oProduto = (Produto)this.cboProduto.SelectedItem;

            this.txtQuantidade.Validar();

            int? quantidade = Convert.ToInt32(this.txtQuantidade.Text);

            ItensPedido Item = new ItensPedido()
            {
                ProdutoId = oProduto.Id,
                Quantidade = quantidade,
                ValorTotal = oProduto.ValorProduto * quantidade,
                Produto = oProduto,
                Situacao = (byte)ESituacaoItemPedido.Disponivel
            };

            if (this.Items.Any(x => x.ProdutoId == oProduto.Id))
            {
                this.Items.Where(x => x.ProdutoId == oProduto.Id).Single().Quantidade += quantidade;
            }
            else
                this.Items.Add(Item);

            this.CalcularValorTotal();

            this.groupDadosProduto.LimparCampos();
            this.txtQuantidade.Text = "1";

            this.bindingItems.DataSource = this.Items;
            this.gridProdutos.DataSource = this.bindingItems;
            this.gridProdutos.RefreshDataSource();
            Salvo = false;
        }
        private void EventoSalvarPedido(object sender, EventArgs e)
        {

            if (this.Items.Count == 0)
                throw new MyExeption("Adicione pelo menos um produto a lista do pedido.", ETipoException.Aviso);

            this.cboCliente.ValidarComMsg();

            if (this.oPedido.Id == 0)
                this.CriarNovoPedido();
            else
                this.AtualizarDadosPedido();

            this.pnlInserirDados.LimparCampos();
            this.DestroyList();

            MyMsgBox.Exibir("Pedido Salvo com sucesso.", "Controle de Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            Salvo = true;
        }
        private void EventoAdicionarNovoCliente(object sender, EventArgs e)
        {
            this.txtNomeNovoCliente.Validar();

            if (CtrlSession.Clientes.Any(x => x.Nome == this.txtNomeNovoCliente.Text))
                throw new MyExeption("Ja existe um cliente com esse nome.", ETipoException.Aviso);
            Int64 IdNovoCLiente = 0;
            using (ControleVendasEntities contexto = new ControleVendasEntities())
            {
                Cliente oCliente = new Cliente() { Nome = this.txtNomeNovoCliente.Text };

                contexto.Cliente.Add(oCliente);
                contexto.SaveChanges();
                IdNovoCLiente = oCliente.Id;
            }
            CtrlSession.AtualizarListaClientes();
            CarregarCboClientes();
            this.cboCliente.SelectedValue = IdNovoCLiente;
            this.txtNomeNovoCliente.Text = "";
        }
        private void EventoNovaMarca(object sender, EventArgs e)
        {
            ChamadaFroms.Marca();
            CarregarCboMarcas();
        }
        private void EventoChengeNumeroParcelas(object sender, EventArgs e)
        {
            CalcularValorTotal();

            if (Convert.ToByte(this.spinNumeroParcelas.EditValue) == 1)
            {
                this.lblValorParcela.Visible = false;
                this.lblDescValorParcela.Visible = false;
            }
            else
            {
                this.lblValorParcela.Visible = true;
                this.lblDescValorParcela.Visible = true;
            }
        }
        private void EventoAbrirMenuStrip(object sender,CancelEventArgs e)
        {
            if (this.Items.Count == 0)
                e.Cancel = true;
        }
        private void EventoExcluirItem(object sender, EventArgs e)
        {
            ItensPedido oItem = (ItensPedido)this.bindingItems.CurrencyManager.Current;

            if(this.oPedido.Id == 0)
            {
                this.Items.Remove(oItem);
            }
            else
            {
                this.Items.Remove(oItem);
                CtrlSession.context.ItensPedido.Remove(oItem);
            }
            this.gridProdutos.RefreshDataSource();

            this.CalcularValorTotal();

        }
        private void EventoEstipularValor(object sender, EventArgs e)
        {

            this.txtValorProduto.Text = ChamadaFroms.CalcularValor().ToString();

        }
        private void EventoIncluirObservacaoItemPedido(object sender, EventArgs e)
        {
            ChamadaFroms.Observacao(ETipoObservacao.ItemPedido,((ItensPedido)this.bindingItems.CurrencyManager.Current).Id);
            this.gridProdutos.RefreshDataSource();
        }
        private void EventoFechamentoDaTela(object sender, FormClosingEventArgs e)
        {

            if(!Salvo)
            {
                if (MyMsgBox.Exibir("Os dados não foram salvos. Deseja descartar o pedido?", "Controle Vendas", EBotoesMyMsgBox.SimNao, EIconeMyMsgBox.Pergunta) == DialogResult.Yes)
                {
                    foreach(var i in this.Items)
                    {
                        Observacao.DeletarObservacoes(ETipoObservacao.ItemPedido, i.Id);
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Metodos
        private void CriarNovoPedido()
        {

            Pedido oPedido = new Pedido()
            {
                ClienteId = Convert.ToInt64(this.cboCliente.SelectedValue),
                Data = DateTime.Now,
                Valor = this.Items.Sum(x => x.ValorTotal),
                NumeroParcela = Convert.ToByte(this.spinNumeroParcelas.EditValue),
                ValorTotalComicao = this.Items.CalcularComissao(),
                Situacao = (byte)ESituacaoPedido.EmAndamento,
            };
            CtrlSession.context.Pedido.Add(oPedido);
            CtrlSession.context.SaveChanges();

            foreach (ItensPedido oIten in this.Items)
            {
                oIten.PedidoId = oPedido.Id;
                CtrlSession.context.ItensPedido.Add(oIten);
            }
            CtrlSession.context.SaveChanges();

            if (!this.txtObservacao.Text.IsNullOrEmpty())
            {
                Observacao oObservacao = new Observacao()
                {
                    Descricao = this.txtObservacao.Text,
                    Data = DateTime.Now,
                    Tipo = (byte)ETipoObservacao.Pedido,
                    IdPrimary = oPedido.Id
                };

                CtrlSession.context.Observacao.Add(oObservacao);
                CtrlSession.context.SaveChanges();
                Observacao.GeraLista();
            }

        }
        private void AtualizarDadosPedido()
        {

            oPedido.ClienteId = (long?)this.cboCliente.SelectedValue;
            oPedido.NumeroParcela = Convert.ToByte(this.spinNumeroParcelas.EditValue);
            oPedido.Valor = this.Items.Sum(x => x.ValorTotal);
            oPedido.ValorTotalComicao = this.Items.CalcularComissao();
            oPedido.ItensPedido = this.Items;

            CtrlSession.context.SaveChanges();

        }

        private Produto CadastrarNovoProduto()
        {
            Produto Porduct;

            this.groupDadosNovoProduto.ValidarCamposObrigatorios();

            using (ControleVendasEntities context = new ControleVendasEntities())
            {
                Produto oProduto = new Produto()
                {
                    Descricao = this.txtProduto.Text,
                    CodigoProduto = this.txtCodigo.Text.ToInt32(),
                    MarcaId = (Int64)this.cboMarca.SelectedValue,
                    ValorProduto = this.txtValorProduto.Text.ToDecimal(),
                    Tipo = (byte)ETipoProduto.Padrao

                };

                context.Produto.Add(oProduto);
                context.SaveChanges();
                CtrlSession.AtualizarListaProdutos();
                CarregarCboProdutos();
                Porduct = CtrlSession.Produtos.Last();
            }

            return Porduct;
        }
        private void DataLoad()
        {
            CarregarCboClientes();
            CarregarCboMarcas();
            CarregarCboProdutos();
            this.txtValorProduto.Text = "0,00";
            this.txtQuantidade.Text = "1";
            if(this.oPedido.Id != 0)
            {
                this.Items = this.oPedido.ItensPedido;
                this.bindingItems.DataSource = this.Items;
                this.gridProdutos.DataSource = this.bindingItems;
                this.gridProdutos.RefreshDataSource();

                this.cboCliente.SelectedValue = this.oPedido.ClienteId;
                this.spinNumeroParcelas.EditValue = this.oPedido.NumeroParcela;
                
                this.CalcularValorTotal();
            }
        }
        private void DestroyList()
        {
            this.bindingItems.DataSource = null;
            this.Items.Clear();
            this.gridProdutos.DataSource = null;
            this.gridProdutos.RefreshDataSource();
            this.lblValorParcela.Text = "R$ 0,00";
            this.lblValorTotalPedido.Text = "R$ 0,00";
        }
        private void CarregarCboClientes()
        {
            this.cboCliente.SetDataSource(CtrlSession.Clientes,"Id","Nome","Nome","Cliente");
        }
        private void CarregarCboMarcas()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca");
        }
        private void CarregarCboProdutos()
        {
            this.cboProduto.SetDataSource(CtrlSession.Produtos, "Id", "CodigoDescricao", "CodigoDescricao", "Produto",true);
        }
        private void CalcularValorTotal()
        {
            this.lblValorTotalPedido.Text = this.Items.Sum(x => x.ValorTotal).Value.ToString("C2");
            this.lblValorParcela.Text = (this.Items.Sum(x => x.ValorTotal).Value / Convert.ToByte(this.spinNumeroParcelas.EditValue)).ToString("C2");
            this.Items.ForEach(x => { x.ValorTotal = x.Produto.ValorProduto * x.Quantidade; });
        }

        #endregion

    }
}