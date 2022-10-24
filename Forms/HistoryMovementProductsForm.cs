using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class HistoryMovementProductsForm : Form {
        CancellationTokenSource exited = new CancellationTokenSource();
        Form mainForm;
        public HistoryMovementProductsForm(Form mainForm) {
            InitializeComponent();

            this.mainForm = mainForm;

            foreach (DataGridViewColumn column in table.Columns)
                if (column.Name != "ProductName")
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            table.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            FirstLoad();

            backBtn.Click += (s, e) => {
                exited.Cancel();
                BackToMain(mainForm, this);
            };
            this.FormClosing += (s, e) => Application.Exit();
        }

        public async void FirstLoad() {
            List<string> list = new List<string>(3);
            await Task.Run(() => {
                try {
                    if (!File.Exists(importExport)) File.Create(importExport).Dispose();
                    using (StreamReader sr = new StreamReader(importExport))
                        sr.ToList(list, ';', regexImportExport, 1, false);
                }
                catch (Exception e) { Logger("Ошибка чтения файла", importExport, e); }

                list.QuickSort();

                for (int i = 0; i < list.Count; i++) {
                    if (exited.IsCancellationRequested) return;
                    string[] row = new string[list.Capacity + 1];
                    string[] rowFromList = list[i];
                    row[0] = rowFromList[1];
                    row[1] = rowFromList[0];
                    row[2] = rowFromList[2].Remove(0, 1);
                    row[3] = rowFromList[2].Remove(1, rowFromList[2].Length - 1) == "+" ? "Приход" : "Расход";
                    if (InvokeRequired)
                        Invoke(new Action(() => {
                            table.Rows.Add(row);
                        }));
                    else table.Rows.Add(row);
                }
            });

            table.ScrollBars = ScrollBars.Vertical;
            table.Refresh();
            loadText.Hide();
        }
    }
}
