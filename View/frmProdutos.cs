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
using Utilitarios.Extencions;
using Model;
using Utilitarios.Enumerators;
using Utilitarios.Classes;
using Utilitarios.MyMsg;
using System.IO;

namespace View
{
    public partial class frmProdutos : DevExpress.XtraEditors.XtraForm
    {
        private Produto oProduto = new Produto();
        private bool ProdutoSalvo = false;
        public frmProdutos()
        {
            InitializeComponent();
            DataLoad();
            DelegarEventos();
        }

        private void DelegarEventos()
        {
            this.btnEstipularValor.Click += EventoEstipularValor;
            this.btnNovaMarca.Click += EventoNovaMarca;
            this.btnConsultar.Click += EventoConsulta;
            this.btnSalvar.Click += EventoSalvar;
            this.FormClosing += EventoFechamentoTela;
            this.btnCarregarImagem.Click += EventoCarregarImagem;
            this.btnApagarImagem.Click += EventoApagarImagem;
        }

        private void EventoApagarImagem(object sender, EventArgs e)
        {
            pictureFotoProduto.Image = null;
            if (oProduto.IsNotNull())
            {
                oProduto.Imagem = null;
            }
        }

        private void EventoCarregarImagem(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Carregar imagem do comprovante de pagamento";
            fileDialog.Filter = ("Fotos (*jpg; *png; *jpeg) | *jpg; *png; *jpeg");
            fileDialog.Multiselect = false;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureFotoProduto.Image = System.Drawing.Image.FromFile(fileDialog.FileName);
                oProduto.Imagem = System.IO.File.ReadAllBytes(fileDialog.FileName);
            }
        }

        private void EventoFechamentoTela(object sender, FormClosingEventArgs e)
        {
            if (!ProdutoSalvo)
            {
                if (MyMsgBox.Exibir("Os dados não foram salvos. Deseja descartar as alterações?", "Controle Vendas", EBotoesMyMsgBox.SimNao, EIconeMyMsgBox.Pergunta) != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }

        private void EventoSalvar(object sender, EventArgs e)
        {

            this.Validar();

            if (this.oProduto.Id == 0)
                CadastrarNovoProduto();
            else
                AlterarProduto();
            CtrlSession.context.SaveChanges();

            this.groupControl1.LimparCampos();
            CtrlSession.AtualizarListaProdutos();

            MyMsgBox.Exibir("Produto Salvo com sucesso.", "Controle de Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            ProdutoSalvo = true;
        }

        private void EventoConsulta(object sender, EventArgs e)
        {
            oProduto = (Produto)ChamadaFroms.Consultar(ETipoConsulta.Produto);

            if (this.oProduto.IsNotNull())
            {
                this.txtCodigo.Text = oProduto.CodigoProduto.ToString();
                this.txtProduto.Text = oProduto.Descricao;
                this.txtValorProduto.Text = oProduto.ValorProduto.ToString();
                this.cboMarca.SelectedValue = oProduto.MarcaId;
                this.txtObservacao.Text = oProduto.Observacao;
                this.cboTipoProduto.SelectedValue = (ETipoProduto)oProduto.Tipo;
                this.txtValorCompraProduto.Text = oProduto.ValorCompra.HasValue ? oProduto.ValorCompra.ToString() : "0,00";
                this.txtQuantidadeEstoque.Text = oProduto.Estoque.HasValue ? oProduto.Estoque.ToString() : "0";
                if(oProduto.Imagem.IsNotNull() && oProduto.Imagem.Length > 0)
                {
                    MemoryStream oStreamImagem = new MemoryStream();
                    oStreamImagem.Write(oProduto.Imagem, 0, oProduto.Imagem.Length);
                    this.pictureFotoProduto.Image = System.Drawing.Image.FromStream(oStreamImagem);
                }

                ProdutoSalvo = false;
            }

        }

        private void EventoNovaMarca(object sender, EventArgs e)
        {
            ChamadaFroms.Marca();
            this.CarregarCboMarca();
        }

        private void EventoEstipularValor(object sender, EventArgs e)
        {
            this.txtValorProduto.Text = ChamadaFroms.CalcularValor(this.txtValorCompraProduto.Text.ToDecimal()).ToString();
        }

        #region Metodos
        private void CadastrarNovoProduto()
        {

            Produto oProduto = new Produto()
            {
                Descricao = this.txtProduto.Text,
                CodigoProduto = this.txtCodigo.Text.ToInt32(),
                MarcaId = (Int64)this.cboMarca.SelectedValue,
                ValorProduto = this.txtValorProduto.Text.ToDecimal(),
                Tipo = (byte)(ETipoProduto)this.cboTipoProduto.SelectedValue,
                Estoque = this.txtQuantidadeEstoque.Text.ToInt32(),
                ValorCompra = this.txtValorCompraProduto.Text.ToDecimal(),
                Observacao = this.txtObservacao.Text
            };

            CtrlSession.context.Produto.Add(oProduto);
        }
        private void AlterarProduto()
        {

            oProduto.Descricao = this.txtProduto.Text;
            oProduto.CodigoProduto = this.txtCodigo.Text.ToInt32();
            oProduto.MarcaId = (Int64)this.cboMarca.SelectedValue;
            oProduto.ValorProduto = this.txtValorProduto.Text.ToDecimal();
            oProduto.Tipo = (byte)(ETipoProduto)this.cboTipoProduto.SelectedValue;
            oProduto.Estoque = this.txtQuantidadeEstoque.Text.ToInt32();
            oProduto.ValorCompra = this.txtValorCompraProduto.Text.ToDecimal();
            oProduto.Observacao = this.txtObservacao.Text;

        }
        private void DataLoad()
        {
            CarregarCboMarca();
            CarregarCboTipo();
        }
        private void Validar()
        {
            this.txtProduto.Validar();
            this.txtCodigo.Validar();
            this.txtValorProduto.Validar();
            this.cboMarca.Validar();

            if ((ETipoProduto)this.cboTipoProduto.SelectedValue == ETipoProduto.ProtaEntrega)
            {
                this.txtValorCompraProduto.Validar();
                this.txtQuantidadeEstoque.Validar();
            }
            

        }
        private void CarregarCboMarca()
        {
            this.cboMarca.SetDataSource(CtrlSession.Marcas, "Id", "Nome", "Nome", "Marca");
        }
        private void CarregarCboTipo()
        {
            this.cboTipoProduto.SetDataSource(Util.GetDataSource(typeof(ETipoProduto)), "Value", "Key", "Key", "Tipo Produto");
        }

        #endregion


    }
}