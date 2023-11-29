using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Model.DTOS;
using System.Collections.Generic;
using System.Linq;

namespace View.Relatorios
{
    public partial class Rel001ProdutosMaisVendidos : DevExpress.XtraReports.UI.XtraReport
    {
        public Rel001ProdutosMaisVendidos(List<rel001ProdutosMaisVendidos> lista)
        {
            InitializeComponent();

            this.lblDataInicio.DataBindings.Add(new XRBinding("Text", lista, "dataInicial", "{0:dd/MM/yyyy}"));
            this.lblDataFim.DataBindings.Add(new XRBinding("Text", lista, "datafinal", "{0:dd/MM/yyyy}"));
            this.lblDataImpressao.Text = "Impresso em: " + DateTime.Now.ToShortDateString();

            this.CellId.DataBindings.Add(new XRBinding("Text", lista, "Id"));
            this.CellProduto.DataBindings.Add(new XRBinding("Text", lista, "Descricao"));
            this.CellMarca.DataBindings.Add(new XRBinding("Text", lista, "Marca"));
            this.CellQuantidade.DataBindings.Add(new XRBinding("Text", lista, "Quantidade"));
            this.CellValor.DataBindings.Add(new XRBinding("Text", lista, "ValorTotal"));

            this.xrLabelContagem.Text = lista.Sum(x => x.Quantidade).ToString();
            this.xrLabelSoma.Text = lista.Sum(x => x.ValorTotal.Value).ToString("C");

            this.DataSource = lista;

        }

    }
}
