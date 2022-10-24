using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Constants;
using static CourseworkDenisZhukov.Auxiliary;
using System.Threading.Tasks;

namespace CourseworkDenisZhukov.Forms {
    public partial class FindProductForm : Form {
        CancellationTokenSource exited = new CancellationTokenSource();
        List<string> list;
        public FindProductForm(Form mainForm) {
            InitializeComponent();

            backBtn.Click += (s, e) => {
                exited.Cancel();
                BackToMain(mainForm, this);
            };

            foreach (DataGridViewColumn column in table.Columns)
                if (column.Name != "ProductName")
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            table.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            FirstLoad();

            productNamesPanel.Click += (s, e) => productNames.Focus();
            backBtn.Click += (s, e) => BackToMain(mainForm, this);
            this.FormClosing += (s, e) => Application.Exit();
        }

        public async void FirstLoad() {
            list = new List<string>(4);
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
                    string[] row = new string[list.Capacity];
                    Array.Copy(list[i], row, list.Capacity);
                    (row[2], row[3]) = (row[2].Replace('.', ','), row[3].Replace('.', ','));

                    if (InvokeRequired) {
                        if (exited.IsCancellationRequested) return;
                        Invoke(new Action(() => {
                            table.Rows.Add(row);
                        }));
                    }
                    else {
                        if (exited.IsCancellationRequested) return;
                        table.Rows.Add(row);
                    }
                }
            });
            backBtn.Enabled = true;
            loadText.Hide();
        }

        private async void SearchProduct(object sender, EventArgs e) {
            loadText.Show();
            productNames.Enabled = false;
            backBtn.Enabled = false;
            table.Rows.Clear();
            string product = productNames.Text;
            List<string> listMatchable = new List<string>(4);
            await Task.Run(() => {
                for (int i = 0; i < list.Count; i++)
                    if (list[i, 0].ToLower().Contains(product.ToLower()))
                        listMatchable.Add(list[i]);
                for (int i = 0; i < listMatchable.Count; i++) {
                    if (InvokeRequired)
                        Invoke(new Action(() => table.Rows.Add(listMatchable[i])));
                    else table.Rows.Add(listMatchable[i]);
                }
            });
            productNames.Enabled = true;
            loadText.Hide();
            productNames.Focus();
            table.Refresh();
            table.Update();
            backBtn.Enabled = true;
        }
    }
}
