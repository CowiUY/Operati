﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operati2
{
    static class Program
    {















        //////////////////////////////////////////////////////////////////
        
        public static ADODB.Connection conexion = new ADODB.Connection();

        //////////////////////////////////////////////////////////////////





        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frmuno());
        }
    }
}
