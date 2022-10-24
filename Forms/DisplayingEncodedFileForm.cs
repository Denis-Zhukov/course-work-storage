using System;
using System.IO;
using System.Windows.Forms;
using static CourseworkDenisZhukov.TripleDES;
using static CourseworkDenisZhukov.Auxiliary;

namespace CourseworkDenisZhukov.Forms {
    public partial class DisplayingEncodedFileForm : Form {
        public DisplayingEncodedFileForm(string path, bool encrypted) {
            InitializeComponent();

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    string line;
                    if (encrypted)
                        while ((line = sr.ReadLine()) != null) {
                            if (line != "") textBox.Text += $"{Decrypt(line)}\r\n";
                        }
                    else
                        while ((line = sr.ReadLine()) != null) {
                            if (line != "") textBox.Text += $"{line}\r\n";
                        }
                }
            }
            catch (Exception ex) { Logger("Ошибка чтения файла", path, ex); }
            textBox.SelectionLength = 0;
            textBox.SelectionStart = 0;
            
        }
    }
}
