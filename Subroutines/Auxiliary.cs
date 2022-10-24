using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CourseworkDenisZhukov.Forms;

namespace CourseworkDenisZhukov {
    public class Auxiliary {

        public static void ChangeWindow(Form cw, Form nw) {
            cw.Hide();
            nw.Show();
            nw.Location = cw.Location;
        }

        /// <summary>
        /// Changes main window to depend window.
        /// </summary>
        /// <param name="mw">Main Window.</param>
        /// <param name="dw">Depend Window.</param>
        public static void BackToMain(Form mw, Form dw) {
            mw.Location = dw.Location;
            mw.Show();
            dw.Dispose();
        }        

        /// <summary>
        /// Create log about error.
        /// </summary>
        /// <param name="susErr">Suspected error.</param>
        /// <param name="path">Path to file that call error.</param>
        /// <param name="e">Exception of error.</param>
        public static void Logger(string susErr, string path, Exception e) {
            try {
                if (!File.Exists("./logger.log")) File.Create("./logger.log").Close();
                using (StreamWriter sw = new StreamWriter("./logger.log", true))
                    sw.WriteLine($"{DateTime.Now}\t[{path.Split('/').Last()}]:\nSuspected error:{susErr}.\nCompiler error:{e.Message}\n\n");
                string answer = MessageBox.Show($"Произошла ошибка.\nДля подробностей проверьте файл logger.log.\nОткрыть logger.log?", "Произошла ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Information).ToString();
                if (answer == "Yes") UserMainForm.OpenFile("./logger.log");
            }
            catch (Exception ex) { MessageBox.Show($"Ошибка логирования.\nПроверьте не открыты ли файлы программы иной программой и имеет ли программа доступ к созданию и редактированию файлов.\nОшибка: {ex.Message}", "Ошибка логирования", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
