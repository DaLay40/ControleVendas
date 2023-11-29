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
using Utilitarios;
using Utilitarios.Enumerators;
using Model;
using Utilitarios.MyMsg;
using View.Forms;

namespace View
{
    public partial class frmMarca : DevExpress.XtraEditors.XtraForm
    {
        private Marca oMarca = new Marca();

        public frmMarca()
        {
            InitializeComponent();
            DelegarEventos();
        }


        private void DelegarEventos()
        {
            this.btnConsultar.Click += EventoConsultarMarcas;
            this.btnSalvar.Click += EventoSalvar;
        }

        #region Eventos

        private void EventoSalvar(object sender, EventArgs e)
        {
            if (this.txtNome.Text.IsNullOrEmpty())
                throw new MyExeption("Informe o nome da marca.", ETipoException.Aviso);

            if (this.txtComissao.Text.IsNullOrEmpty())
                throw new MyExeption("Informe a porcentagem de comissão da marca.", ETipoException.Aviso);

            if(CtrlSession.Marcas.Any(x => x.Nome == this.txtNome.Text) && (oMarca.Id == 0 || oMarca.Nome != this.txtNome.Text))
                throw new MyExeption("Uma marca com esse nome ja esta cadastrada.", ETipoException.Aviso);


            using (ControleVendasEntities context = new ControleVendasEntities())
            {
                if(oMarca.Id == 0)
                {
                    Marca oMarcaNova = new Marca()
                    {
                        Nome = this.txtNome.Text,
                        PorcentagemComicao = Convert.ToDecimal(this.txtComissao.Text)
                    };
                    context.Marca.Add(oMarcaNova);
                    context.SaveChanges();
                }
                else
                {

                    oMarca = context.Marca.Where(x => x.Id == oMarca.Id).Single();
                    oMarca.Nome = this.txtNome.Text;
                    oMarca.PorcentagemComicao = Convert.ToDecimal(this.txtComissao.Text);
                    context.SaveChanges();

                }
            }

            this.LimparCampos();

            MyMsgBox.Exibir("Marca cadastrada com sucesso","Controle de Vendas",EBotoesMyMsgBox.Ok,EIconeMyMsgBox.Sucesso);
        }

        private void EventoConsultarMarcas(object sender, EventArgs e)
        {
            this.oMarca = (Marca)ChamadaFroms.Consultar(ETipoConsulta.Marca);

            if (this.oMarca.IsNotNull())
            {
                this.txtNome.Text = oMarca.Nome;
                this.txtComissao.Text = oMarca.PorcentagemComicao.Value.ToString("N2");
            }
            else
            {
                this.oMarca = new Marca();
            }
        }

        #endregion
    }
}