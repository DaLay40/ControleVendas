using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios.Enumerators;
using Utilitarios.Extencions;

namespace Utilitarios.Classes
{
    public static class Util
    {

        public static IList GetDataSource(Type enumType)
        {
            if (enumType == null || !enumType.IsEnum)
                throw new MyExeption("Não foi possível obter o GetDataDource", ETipoException.Erro);

            IList lista = new ArrayList();
            Array EnumValues = Enum.GetValues(enumType);

            foreach (Enum en in EnumValues)
            {
                KeyValuePair<String, Enum> kv = new KeyValuePair<String, Enum>(en.Descricao(), en);
                lista.Add(kv);
            }
            return lista;
        }

        public static Image GetImage(byte[] array)
        {
            MemoryStream oStreamImagem = new MemoryStream();
            oStreamImagem.Write(array, 0, array.Length);
            return System.Drawing.Image.FromStream(oStreamImagem);
        }

    }

}
