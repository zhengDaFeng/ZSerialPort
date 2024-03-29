﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZSerialPort.Test.Winform
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm view = new MainForm();
            view.StartPosition = FormStartPosition.CenterScreen;
            IController controller = new IController(view);

            Application.Run(view);
        }
    }
}
