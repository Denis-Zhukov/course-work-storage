using System;
using System.Threading;
using System.Windows.Forms;
using CourseworkDenisZhukov.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.TripleDES;

namespace CourseworkDenisZhukov {
    static class Program {
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ThreadException += new ThreadExceptionEventHandler(UnexpectedException);
            Application.Run(new SignInForm());
        }

        private static void UnexpectedException(object sender, ThreadExceptionEventArgs e) => 
            Logger("Непредвиденная ошибка", "-", e.Exception);
    }
}
