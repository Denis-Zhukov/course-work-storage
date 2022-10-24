using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class ReportOfStorageForm : Form {
        CancellationTokenSource exited = new CancellationTokenSource();
        public ReportOfStorageForm(Form mainForm) {
            InitializeComponent();
            backBtn.Click += (s, e) => { exited.Cancel(); BackToMain(mainForm, this); };
            this.FormClosing += (s, e) => Application.Exit();
        }

        private async void CreateReport_Click(object sender, EventArgs e) {
            createReportButton.Enabled = false;
            createReportButton.Text = "(Загрузка...)";
            DateTime choosedDate = DateTime.Parse(String.Join(".", this.date.Text.Split('.').Reverse().ToArray()));
            await Task.Run(() => {
                List<string> listStorage = new List<string>(3);
                using (StreamReader sr = new StreamReader(storage))
                    sr.ToList(listStorage, ';', regexStorage, 0);

                Dictionary<string, double> productCount = new Dictionary<string, double>();
                for (int i = 0; i < listStorage.Count; i++)
                    productCount.Add(listStorage[i, 0], Double.Parse(listStorage[i, 2]));

                List<string> listImpExp = new List<string>(3);
                using (StreamReader sr = new StreamReader(importExport))
                    sr.ToList(listImpExp, ';', regexImportExport, 0);

                for (int i = 0; i < listImpExp.Count && !exited.IsCancellationRequested; i++) {
                    DateTime dateFromList = DateTime.Parse(String.Join(".", listImpExp[i, 0].Split('.').Reverse().ToArray()));
                    string[] row = listImpExp[i];
                    if (dateFromList > choosedDate.Date || !productCount.ContainsKey(row[1])) continue;
                    productCount[row[1]] += Double.Parse(row[2]);
                }

                string reportFile = reportOfStorage;
                File.Create(reportFile).Dispose();
                using (StreamWriter sw = new StreamWriter(reportFile)) {
                    sw.WriteLine($"Отчет на: {choosedDate.ToString("dd.MM.yyyy:")}");
                    foreach (KeyValuePair<string, double> val in productCount)
                        sw.WriteLine($"{val.Key}: {val.Value}");
                }
            });

            createReportButton.Text = "Создать отчет";
            createReportButton.Enabled = true;
        }
    }
}
