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
using Model;
using Utilitarios.Enumerators;
using View.Forms;
using Utilitarios.Extencions;

namespace View
{
    public partial class frmEstoqueProdutos : DevExpress.XtraEditors.XtraForm
    {
        BindingSource bindingProdutos = new BindingSource();
        public frmEstoqueProdutos()
        {
            InitializeComponent();
            DataLoad();
            DelegarEventos();
        }

        private void DelegarEventos()
        {
            this.btnNovoProduto.Click += EventoNovoProduto;
            this.btnAdicionarProduto.Click += EventoAdicionar;

        }

        private void EventoAdicionar(object sender, EventArgs e)
        {
            cboProduto.ValidarComMsg();
            txtQuantidade.Validar();

            Int64 idProduto = (Int64)this.cboProduto.SelectedValue;

            CtrlSession.context.Produto.Find(idProduto).Estoque += this.txtQuantidade.Text.ToInt32();
            CtrlSession.context.SaveChanges();
            this.AtualizaLista();

        }

        private void EventoNovoProduto(object sender, EventArgs e)
        {
            ChamadaFroms.Produtos();
            DataLoad();
        }

        private void DataLoad()
        {
            CarregarCboProdutos();
            AtualizaLista();
        }

        private void CarregarCboProdutos()
        {
            this.cboProduto.SetDataSource(CtrlSession.Produtos.Where(x => x.Tipo == (byte)ETipoProduto.ProtaEntrega), "Id", "CodigoDescricao", "CodigoDescricao", "Produto", true);
        }

        private void AtualizaLista()
        {
            this.bindingProdutos.DataSource = CtrlSession.Produtos.Where(x => x.Tipo == (byte)ETipoProduto.ProtaEntrega);
            this.gridProdutos.DataSource = this.bindingProdutos;
            this.gridProdutos.RefreshDataSource();
        }
    }
}