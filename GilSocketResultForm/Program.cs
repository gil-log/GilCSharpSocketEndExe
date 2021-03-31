using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GilSocketResultForm
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            String[] args = Environment.GetCommandLineArgs();

            SocketResultForm form = new SocketResultForm(args);

            //Application.Run(new SocketResultForm(args));
        }
    }
}
