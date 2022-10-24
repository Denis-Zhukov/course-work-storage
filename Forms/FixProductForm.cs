using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class FixProductForm : Form {
        public FixProductForm(Form mainForm) {
            InitializeComponent();

            ProductName.TextChanged += new EventHandler(this.ChangeText);
            ProductName.Leave += (object sender, EventArgs e) => ProductName.Text = ProductName.Text.Trim();

            unit.TextChanged += new EventHandler(this.ChangeText);
            unit.Leave += (object sender, EventArgs e) => unit.Text = unit.Text.Trim();

            count.TextChanged += new EventHandler(this.ChangeNumber) + new EventHandler(this.CheckAllPrice);
            pricePerUnit.TextChanged += new EventHandler(this.ChangeNumber) + new EventHandler(this.CheckAllPrice);

            foreach (PictureBox pb in Controls.OfType<PictureBox>())
                pb.Tag = "0";

            foreach (TextBox textBox in Controls.OfType<TextBox>())
                if (textBox.Name != "PriceAll")
                    ((Panel)Controls[textBox.Name + "Panel"]).Click += new EventHandler(
                        (object sender, EventArgs e) => textBox.Focus());

            success.Tag = "1";
            failure.Tag = "1";

            backBtn.Click += (s, e) => BackToMain(mainForm, this);
            this.FormClosing += (s, e) => Application.Exit();
        }

        private void ChangeNumber(object sender, EventArgs e) {
            TextBox textBox = ((TextBox)sender);
            string oldText = textBox.Text;
            textBox.Text = textBox.Text.Replace(" ", "").Replace('.', ',');
            if (oldText != textBox.Text) textBox.SelectionStart = textBox.Text.Length;

            PictureBox pic = (PictureBox)Controls.Find(textBox.Name + "Check", true).FirstOrDefault();
            if (Double.TryParse(textBox.Text, out double x) && x >= 0)
                (pic.Image, pic.Tag) = (success.Image, "1");
            else (pic.Image, pic.Tag) = (failure.Image, "0");
        }

        private void ChangeText(object sender, EventArgs e) {
            TextBox textBox = ((TextBox)sender);
            int oldPos = textBox.SelectionStart;
            textBox.Text = textBox.Text.Replace(';', ',');
            textBox.SelectionStart = oldPos < Text.Length ? oldPos : Text.Length;

            PictureBox pic = (PictureBox)Controls.Find(textBox.Name + "Check", true).FirstOrDefault();
            if (textBox.Text.Length > 0)
                (pic.Image, pic.Tag) = (success.Image, "1");
            else (pic.Image, pic.Tag) = (failure.Image, "0");
        }

        private void CheckAllPrice(object sender, EventArgs e) {
            bool isPrice = Double.TryParse(this.pricePerUnit.Text, out double pricePerUnit),
                isCount = Double.TryParse(this.count.Text, out double count);

            if (isPrice && isCount && count >= 0 && pricePerUnit >= 0)
                (priceAll.Text, priceAllCheck.Image, priceAllCheck.Tag) = ($"{count * pricePerUnit}", success.Image, "1");
            else (priceAll.Text, priceAllCheck.Image, priceAllCheck.Tag) = ("-", failure.Image, "0");
        }

        private void FixProduct_Click(object sender, EventArgs e) {
            if (!Controls.OfType<PictureBox>().All(pic => ((string)pic.Tag) == "1")) {
                MessageBox.Show("Введите все данные верно.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> listStorage = new List<string>(4);
            try {
                if (!File.Exists(storage)) File.Create(storage).Dispose();
                using (StreamReader sr = new StreamReader(storage))
                    sr.ToList(listStorage, ';', regexStorage);
            }
            catch (Exception ex) { Logger("Ошибка чтения файла", storage, ex); }

            if (!listStorage.Contains(ProductName.Text)) {
                listStorage.Add(new string[] { ProductName.Text, unit.Text, Math.Round(Double.Parse(count.Text), 4).ToString(), Math.Round(Double.Parse(pricePerUnit.Text), 2).ToString() });
                listStorage.ToFile("./storage.txt", ';');
                MessageBox.Show("Товар успешно зафиксирован.", "Фиксирование товара на скалде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                (ProductName.Text, unit.Text, count.Text, pricePerUnit.Text) = ("", "", "", "");
            }
            else MessageBox.Show("Данный товар уже существует на складе.", "Ошибка фиксирования", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}