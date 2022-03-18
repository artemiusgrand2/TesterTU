using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

using TesterTU.Models;
using TesterTU.Controllers;

namespace TesterTU
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string [] arg)
        {
            var model = new ModelCommon();
            model.Devices.AddRange(ControllerHelper.GetDevices((arg.Length != 0) ? arg[0] : Path.Combine(Environment.CurrentDirectory, "devices.csv")));
            var controller = new ControllerMain(model);
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TesterTU.Views.MainForm(model, controller));
        }
    }
}
