using System;
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
            if (arg.Length != 0)
                model.Devices.AddRange(ControllerHelper.GetDevices(arg[0]));
            //
            var controller = new ControllerMain(model);
            //
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TesterTU.Views.MainForm(model, controller));
        }
    }
}
