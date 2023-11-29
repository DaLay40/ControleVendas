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
using Utilitarios.Enumerators;
using Model;
using Utilitarios.Extencions;
using Utilitarios;
using Utilitarios.MyMsg;
using View.Forms;

namespace View
{
    public partial class frmObservacao : DevExpress.XtraEditors.XtraForm
    {
        private ETipoObservacao Tipo;
        private Int64 IdPrimary;
        private Observacao oObservacao = new Observacao();
        public frmObservacao(ETipoObservacao Tipo,Int64 IdPrimary)
        {
            InitializeComponent();
            this.Tipo = Tipo;
            this.IdPrimary = IdPrimary;
            DelegarEventos();
        }

        private void DelegarEventos()
        {
            this.btnSalvar.Click += EventoSalvar;
            this.btnEditar.Click += EventoConsultar;
        }

        private void EventoConsultar(object sender, EventArgs e)
        {
            oObservacao = (Observacao)ChamadaFroms.Consultar(ETipoConsulta.Observacao);
            if (oObservacao.IsNotNull())
            {
                this.txtObservacao.Text = oObservacao.Descricao;
            }
        }

        private void EventoSalvar(object sender, EventArgs e)
        {
            if (this.txtObservacao.Text.IsNullOrEmpty())
            {
                if (MyMsgBox.Exibir("Você deseja excluir essa observação ?", "Controle Vendas", EBotoesMyMsgBox.SimNao, EIconeMyMsgBox.Pergunta) == DialogResult.Yes)
                {
                    CtrlSession.context.Observacao.Remove(this.oObservacao);
                }
                else
                {
                    MyMsgBox.Exibir("Nenhuma alteração foi realizada", "Controle Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Aviso);
                    return;
                }
            }
            else
            {
                if (this.oObservacao.Id == 0)
                {
                    Observacao oObservacao = new Observacao()
                    {
                        Descricao = this.txtObservacao.Text,
                        Data = DateTime.Now,
                        Tipo = (byte)Tipo,
                        IdPrimary = IdPrimary
                    };

                    CtrlSession.context.Observacao.Add(oObservacao);
                }
                else
                {
                    this.oObservacao.Descricao = this.txtObservacao.Text;
                }
            }
            CtrlSession.context.SaveChanges();
            MyMsgBox.Exibir("Alterações realizadas com sucesso", "Controle Vendas", EBotoesMyMsgBox.Ok, EIconeMyMsgBox.Sucesso);
            this.Close();

        }
    }
}