using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class StorageProductForm : Form {

        CancellationTokenSource exited = new CancellationTokenSource();
        public StorageProductForm(Form mainForm) {
            InitializeComponent();

            //Выравнивание всех заголовков таблицы по центру, кроме "Название товара"
            foreach (DataGridViewColumn column in Storage.Columns)
                if (column.Name != "ProductName")
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Выравниевание элементов всех заголовков таблицы, кроме "Название товара"
            Storage.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Storage.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Storage.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Storage.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            FirstLoad();

            backBtn.Click += (s, e) => {
                exited.Cancel();
                BackToMain(mainForm, this);
            };
            this.FormClosing += (s, e) => Application.Exit();
        }

        public async void FirstLoad() {
            List<string> list = new List<string>(4);
            await Task.Run(() => {
                try {
                    if (!File.Exists(storage)) File.Create(storage).Dispose();
                    using (StreamReader sr = new StreamReader(storage))
                        sr.ToList(list, ';', regexStorage);
                }
                catch (Exception e) { Logger("Ошибка чтения файла", storage, e); }

                list.QuickSort();
                if (InvokeRequired)
                    Invoke(new Action(() => backBtn.Enabled = false));
                else backBtn.Enabled = false;

                for (int i = 0; i < list.Count; i++) {
                    string[] row = new string[list.Capacity + 1];
                    Array.Copy(list[i], row, list.Capacity);
                    (row[2], row[3]) = (row[2].Replace('.', ','), row[3].Replace('.', ','));
                    row[4] = (Convert.ToDouble(row[2]) * Convert.ToDouble(row[3])).ToString();

                    if (InvokeRequired) {
                        if (exited.IsCancellationRequested) return;
                        Invoke(new Action(() => Storage.Rows.Add(row)));
                    }
                    else {
                        if (exited.IsCancellationRequested) return;
                        Storage.Rows.Add(row);
                    }
                }
            });
            backBtn.Enabled = true;
            loadText.Dispose();
        }
    }
}
