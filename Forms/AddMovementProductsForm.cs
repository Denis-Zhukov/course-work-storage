using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Constants;
using static CourseworkDenisZhukov.TripleDES;
using static CourseworkDenisZhukov.Auxiliary;

namespace CourseworkDenisZhukov.Forms {
    public partial class AddMovementForm : Form {
        public AddMovementForm(Form mainForm) {
            InitializeComponent();

            List<string> listStorage = new List<string>(1);
            using (StreamReader sr = new StreamReader(storage))
                sr.ToList(listStorage, ';', regexStorage);

            listStorage.QuickSort();

            for (int i = 0; i < listStorage.Count; i++)
                productNames.Items.Add(listStorage[i, 0]);

            backBtn.Click += (s, e) => BackToMain(mainForm, this);
            this.FormClosing += (s, e) => Application.Exit();
        }

        private async void ProductsList_SelectedIndexChanged(object sender, EventArgs e) {
            if (productNames.Text == "") return;
            fixProductBtn.Enabled = false;
            fixProductBtn.Text = "(Загрузка...)";
            string productName = productNames.Text;

            List<string> list = new List<string>(4);
            double valueProduct = 0;
            await Task.Run(() => {
                if (!File.Exists(storage)) File.Create(storage).Dispose();

                try {
                    using (StreamReader sr = new StreamReader(storage))
                        sr.ToList(list, ';', regexStorage, 0, false);
                }
                catch (Exception ex) {
                    Logger($"Ошибка чтения файла.", storage, ex);
                    throw new Exception("Произошла критическая ошибка");
                }

                int productIndex = list.FindIndexes(productName).Item1;
                if (productIndex == -1) return;

                valueProduct = Double.Parse(list[productIndex, 2]);
                for (int i = 0; i < list.Count; i++) {
                    if (list[i, 1] != productName) continue;
                    string impExpValue = list[i, 2];
                    valueProduct += Double.Parse(impExpValue);
                }
            });
            deadStock.Text = valueProduct.ToString();
            fixProductBtn.Text = "Записать товар";
            fixProductBtn.Enabled = true;
        }

        private void CountProduct_TextChanged(object sender, EventArgs e) {
            string oldText = countProduct.Text;
            countProduct.Text = countProduct.Text.Replace('.', ',');
            if (oldText != countProduct.Text) countProduct.SelectionStart = countProduct.Text.Length;
        }

        private async void FixProduct_Click(object sender, EventArgs e) {
            fixProductBtn.Enabled = false;
            backBtn.Enabled = false;
            fixProductBtn.Text = "(Загрузка...)";

            string err = "";

            if (productNames.Text == "") err += "Выберите товар для эскопрта/импорта.\n";
            if (ImpExp.Text == "") err += "Выберите действие с товаром: эскопрт/импорт.\n";

            DateTime impExpDate = DateTime.Parse(String.Join(".", date.Text.Split('.').Reverse().ToArray()));
            if (impExpDate > DateTime.Now.Date) err += "Невозможно экспортировать или принять товар на будущую дату.\n";

            if (!double.TryParse(this.countProduct.Text, out double x) || x <= 0)
                err += "Неверное количество импортируемого/экспортируемого товара.\n";

            if (Double.Parse(deadStock.Text) < x && ImpExp.SelectedIndex == 1)
                err += "Количество экспортируемого товара больше, чем есть на скалде.\n";

            if (err != "") {
                fixProductBtn.Text = "Записать товар";
                fixProductBtn.Enabled = true;
                MessageBox.Show(err, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            List<string> listImpExp = new List<string>(4);
            string impExp = ImpExp.Text;
            string product = productNames.Text;
            string countProduct = this.countProduct.Text;
            await Task.Run(() => {
                try {
                    if (!File.Exists(importExport)) File.Create(importExport).Dispose();
                }
                catch (Exception ex) { Logger("Ошибка создания файла.", importExport, ex); }

                try {
                    using (StreamReader sr = new StreamReader(importExport))
                        sr.ToList(listImpExp, ';', regexImportExport, 0, false);
                }
                catch (Exception ex) {
                    Logger($"Ошибка чтения файла.", importExport, ex);
                    throw new Exception("Произошла критическая ошибка");
                }

                char impExpChar = impExp == "Приход" ? '+' : '-';

                List<string> listStorage = new List<string>(4);

                using (StreamReader sr = new StreamReader(storage))
                    sr.ToList(listStorage, ';', regexStorage);
                int productIndex = listStorage.FindIndexes(product).Item1;
                double valueProduct = Double.Parse(listStorage[productIndex, 2]);

                string[] newNote = listStorage[productIndex];
                newNote[2] = (Math.Round(valueProduct + Double.Parse(impExpChar + countProduct), 4)).ToString();

                try {
                    using (StreamWriter sw = new StreamWriter(importExport, true))
                        sw.WriteLine(Encrypt($"{impExpDate.ToString("dd.MM.yyyy")};{newNote[0]};{impExpChar + countProduct};{newNote[3]};"));
                }
                catch (Exception ex) {
                    Logger($"Ошибка создания файла.", storage, ex);
                    throw new Exception("Произошла критическая ошибка");
                }

                listStorage[productIndex, 2] = newNote[2];
                listStorage.ToFile(storage, ';');
            });

            Invoke(new Action(() => {
                (productNames.SelectedIndex, ImpExp.SelectedIndex) = (-1, -1);
                (this.countProduct.Text, deadStock.Text) = ("", "");
                fixProductBtn.Text = "Записать товар";
                (backBtn.Enabled, fixProductBtn.Enabled) = (true, true);
            }));
        }
    }
}
