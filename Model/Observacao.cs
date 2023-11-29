using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios.Enumerators;
using Utilitarios.Extencions;

namespace Model
{
    public class Observacao
    {

        public Int64 Id { get; set; }
        public String Descricao { get; set; } 
        public DateTime? Data { get; set; }
        public byte? Tipo { get; set; }
        public Int64? IdPrimary { get; set; }

        private static List<Observacao> Observacoes { get; set; }

        public static void GeraLista()
        {
            Observacoes = CtrlSession.context.Observacao.ToList();
        }

        public static String GetObservacoes(ETipoObservacao tipoObservacao, Int64 IdPrimary)
        {

            string _obs = "";
            if (Observacoes.IsNotNull() && Observacoes.Count > 0)
            {
                foreach (var item in Observacoes.Where(x => x.Tipo == (byte)tipoObservacao && x.IdPrimary == IdPrimary))
                {
                    if (_obs != "")
                        _obs += "\n" + item.Descricao;
                    else
                        _obs += item.Descricao;
                }
            }
            return _obs;
        }
        public static void DeletarObservacoes(ETipoObservacao tipoObservacao, Int64 IdPrimary)
        {
            foreach (var i in Observacoes.Where(x => x.Tipo == (byte)tipoObservacao && x.IdPrimary == IdPrimary))
            {
                CtrlSession.context.Observacao.Remove(i);
            }
            CtrlSession.context.SaveChanges();
            GeraLista();
        }
    }
}
