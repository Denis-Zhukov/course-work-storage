using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Constants;
using static CourseworkDenisZhukov.Auxiliary;
using System.Threading.Tasks;

namespace CourseworkDenisZhukov.Forms {
    public partial class RemoveProductForm : Form {
        CancellationTokenSource exited = new CancellationTokenSource();
        public RemoveProductForm(Form mainForm) {
            InitializeComponent();

            foreach (DataGridViewColumn column in table.Columns)
                if (column.Name != "ProductName")
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            table.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            table.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            FirstLoad();

            backBtn.Click += (s, e) => {
                exited.Cancel();
                BackToMain(mainForm, this);
            };
            productNamesPanel.Click += (s, e) => productNames.Focus();
            productNames.SelectedIndexChanged += (s, e) => deleteProductBtn.Focus();
            this.FormClosing += (s, e) => Application.Exit();
        }


        public void LoadStorage(List<string> list) {
            table?.Refresh();
            table?.Rows?.Clear();
            productNames?.Items?.Clear();
            productNames.Text = "";

            for (int i = 0; i < list.Count && !exited.IsCancellationRequested; i++) {
                string[] row = new string[5];
                Array.Copy(list[i], row, list.Capacity);
                row[2] = row[2].Replace('.', ',');
                row[3] = row[3].Replace('.', ',');
                row[4] = $"{Convert.ToDouble(row[2]) * Convert.ToDouble(row[3])}";
                if (!exited.IsCancellationRequested) table?.Rows.Add(row);
            }
            table?.Refresh();

            loadText.Hide();
            deleteProductBtn.Enabled = true;
        }

        public async void FirstLoad() {
            loadText.Show();
            deleteProductBtn.Enabled = false;
            List<string> list = new List<string>(4);

            await Task.Run(() => {
                try {
                    if (!File.Exists(storage)) File.Create(storage).Dispose();
                    using (StreamReader sr = new StreamReader(storage))
                        sr.ToList(list, ';', regexStorage);
                }
                catch (Exception ex) { Logger("Ошибка чтения файла", storage, ex); }

                if (InvokeRequired)
                    Invoke(new Action(() => LoadStorage(list)));
                else LoadStorage(list);
            });

            for (int i = 0; i < list?.Count; i++)
                productNames?.Items.Add(list[i][0].Trim());

            loadText.Hide();
            deleteProductBtn.Enabled = true;
        }

        private async void DeleteProduct_Click(object sender, EventArgs e) {
            if (productNames.SelectedIndex == -1) return;
            List<string> list = new List<string>(4);
            loadText.Show();
            deleteProductBtn.Enabled = false;
            await Task.Run(() => {
                try {
                    if (!File.Exists(storage)) File.Create(storage).Close();
                    using (StreamReader sr = new StreamReader(storage))
                        sr.ToList(list, ';', regexStorage);
                    for (int i = 0; i < list.Count; i++)
                        if (list[i][0] == productNames.Text) list.Remove(i);
                }
                catch (Exception ex) { Logger("Ошибка чтения файла", storage, ex); }

                list.ToFile(storage, ';');

                if (InvokeRequired)
                    Invoke(new Action(() => LoadStorage(list)));
                else LoadStorage(list);
            });
            loadText.Hide();
            deleteProductBtn.Enabled = true;

            for (int i = 0; i < list?.Count && !exited.IsCancellationRequested; i++)
                productNames?.Items.Add(list[i][0].Trim());
            productNames.SelectedIndex = -1;
        }
    }
}
