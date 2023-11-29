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
using Utilitarios.Extencions;

namespace View
{
    public partial class frmEstipularValor : DevExpress.XtraEditors.XtraForm
    {
        decimal ValorFinal = 0;
        public frmEstipularValor()
        {
            InitializeComponent();
            DelegarEventos();
            this.txtValorCompra.Text = "0,00";
        }

        public frmEstipularValor(decimal valor)
        {
            InitializeComponent();
            DelegarEventos();
            this.txtValorCompra.Text = valor.ToString();
            SendKeys.Send("{Tab}");
        }

        private void DelegarEventos()
        {
            this.btnCalcular.Click += EventoCalcular;
        }

        private void EventoCalcular(object sender, EventArgs e)
        {
            this.groupControl1.ValidarCamposObrigatorios();

            decimal ValorCompra = this.txtValorCompra.Text.ToDecimal();
            decimal Porcentagem = this.txtPorcentagemLucro.Text.ToDecimal();

            this.ValorFinal = Math.Round((((Porcentagem * ValorCompra) / 100) + ValorCompra),2);

            this.Close();
        }

        public decimal Abrir()
        {
            this.ShowDialog();
            return this.ValorFinal;
        }
    }
}