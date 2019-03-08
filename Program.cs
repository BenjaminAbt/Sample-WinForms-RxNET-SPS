using System;
using System.Windows.Forms;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Forms;
using BenjaminAbt.Samples.WinFormsSpsRxNet.Runtime;

namespace BenjaminAbt.Samples.WinFormsSpsRxNet
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RuntimeProvider runtimeProvider = new RuntimeProvider();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run((DemoForm)runtimeProvider.ServiceProvider.GetService(typeof(DemoForm)));
        }
    }
}
