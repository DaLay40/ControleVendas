using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using View.Forms;
using Utilitarios;
using Model;

namespace ControleVendas
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MyExeption MyException = new MyExeption();
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(MyException.OnMyException);
            Application.Run(ChamadaFroms.Inicial());
        }
    }
}
