using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace utilizacion_componentes
{
    /// <summary>
    /// Nombre del programa: Utilizacion componentes
    /// Fecha de creacion: 4/mayo/2023
    /// Nombre de creador: Juliana Herrera
    ///  Realice la aplicación que reutilice el Windows Media Player,
    ///  la lectura de archivos PDF y un navegador web.
    /// </summary>

    internal static class Program
    {

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_Elegir());
        }
    }
}
