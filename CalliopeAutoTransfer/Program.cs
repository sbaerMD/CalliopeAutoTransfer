using System;
using System.Windows.Forms;
using CalliopeAutoTransfer.externalSystems;

namespace CalliopeAutoTransfer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //WinForms-Stuff
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create
            var form = new MainForm();
            var view = (IView) form;
            var logic = new Logic(new SettingsStore(), view);

            //startup
            logic.Start();
            Application.Run(form);
        }
    }
}
