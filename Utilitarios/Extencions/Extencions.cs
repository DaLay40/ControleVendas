using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilitarios.Classes;
using Utilitarios.Componentes;

namespace Utilitarios.Extencions
{
    public static class Extencions
    {
        /// <summary>
        /// Retorna o Atributo Description de um Enumerator.
        /// </summary>
        /// <param name="currentEnum">Este Enumerator.</param>
        /// <returns></returns>
        public static string Descricao(this Enum currentEnum)
        {
            if (currentEnum.Equals(null))
                return "";
            string description;

            DescriptionAttribute da;
            FieldInfo fi = currentEnum.GetType().GetField(currentEnum.ToString());

            da = (DescriptionAttribute)Attribute.GetCustomAttribute
                (fi, typeof(DescriptionAttribute));

            if (da != null)
                description = da.Description;
            else
                description = currentEnum.ToString();

            return description;
        }
        
        public static bool IsNull(this object obj)
        {
            if (obj == null)
                return true;
            return false;
        }

        public static bool IsNotNull(this object obj)
        {
            return !obj.IsNull();
        }
       
        public static bool ValidarEmail(this String email)
        {
            if (email.Contains("@gmail.com")) return true;
            if (email.Contains("@outlook.com")) return true;
            if (email.Contains("@hotmail.com")) return true;
            return false;
        }

        public static Int32 ToInt32(this String str)
        {
            try
            {
                return Convert.ToInt32(str);
            }
            catch
            {
                return -1;
            }
        }

        public static String OcultarParteEmail(this String Email)
        {
            if (Email.ValidarEmail())
            {
                int Indice = Email.IndexOf("@");
                string Provedor = Email.Substring(Indice);
                string EmailSemProvedor = Email.Substring(0, Indice);
                string PrimeiraParteEmail = Email.Substring(0, 3);
                string SegundaParteEmail = EmailSemProvedor.Substring(EmailSemProvedor.Length - 4);
                string EmailFormatado = PrimeiraParteEmail + "******" + SegundaParteEmail + Provedor;
                return EmailFormatado;
            }
            else
                return string.Empty;
        }

        public static bool IsNullOrEmpty(this string str)
        {
            return String.IsNullOrEmpty(str);
        }

        public static string SimNao(this bool Boolean)
        {
            return Boolean ? "Sim" : "Não";
        }

        public static void LimparCampos(this Control controlAtual)
        {
            foreach (Control ctr in controlAtual.Controls)
            {
                if (ctr.HasChildren)
                    LimparCampos(ctr);

                if (ctr is MyTextBox)
                    ctr.Text = string.Empty;

                if (ctr is MyComboBox)
                    ((MyComboBox)ctr).SelectedValue = -1;

                if (ctr is DateTimePicker)
                    ((DateTimePicker)ctr).Value = DateTime.Now;

                if (ctr is CheckBox)
                    ((CheckBox)ctr).Checked = false;

                if (ctr is GridControl)
                {
                    ((GridControl)ctr).DataSource = null;
                    ((GridControl)ctr).RefreshDataSource();
                }
            }
        }

        public static void ValidarCamposObrigatorios(this Control controlAtual)
        {
            foreach (Control ctr in controlAtual.Controls)
            {
                if (ctr is MyTextBox)
                    ((MyTextBox)ctr).Validar();

                if (ctr is MyComboBox)
                    ((MyComboBox)ctr).ValidarComMsg();
            }
        }

        public static decimal ToDecimal(this String str)
        {
            return Convert.ToDecimal(str);
        }
        public static double ToDouble(this String str)
        {
            return Convert.ToDouble(str);
        }
            
        public static List<Generico> ToGenerica(this List<object> lista)
        {
            List<Generico> listaConvertida = new List<Generico>();
            foreach(var i in lista)
            {
                Generico generico = new Generico()
                {
                    Id = (long)i.GetType().GetProperty("Id").GetValue(i),
                    Descricao = i.GetType().GetProperty("Descricao").IsNull() 
                    ? (string)i.GetType().GetProperty("Nome").GetValue(i) : (string)i.GetType().GetProperty("Descricao").GetValue(i)
                };
                listaConvertida.Add(generico);
            }
            return listaConvertida;
        }
    }
}
