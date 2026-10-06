using System;
using System.Windows.Forms;
using SistemaRestaurante.Data;
using SistemaRestaurante.Forms;
using SistemaRestaurante.Service;

namespace SistemaRestaurante
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Aquí le decimos que inicie primero la ventana de Login
            Application.Run(new FrmLogin());
        }
    }
}