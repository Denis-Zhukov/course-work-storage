using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class UserMainForm : Form {
        private Access account;
        private Form loginForm;

        public UserMainForm(Access account, Form loginForm) {
            this.account = account;
            this.loginForm = loginForm;

            InitializeComponent();

            this.loginAccount.Text += account.Login;
            this.accessAccount.Text += account.GetAccess.ToLower();
            this.Text += $" | {account.GetAccess}";

            if (this.account.GetAccess == "Гость")
                foreach (Button btn in Controls.OfType<Button>())
                    btn.Enabled = false;


            storageProductBtn.Click += (s, e) => ChangeWindow(this, new StorageProductForm(this));

            showHistoryMovementProductsBtn.Click += (s, e) => ChangeWindow(this, new HistoryMovementProductsForm(this));
            addMovementBtn.Click += (s, e) => ChangeWindow(this, new AddMovementForm(this));

            storageFileBtn.Click += (s, e) => OpenFile(storage);
            loggerFileBtn.Click += (s, e) => OpenFile(logger);

            this.FormClosing += (s, e) => Application.Exit();
        }

        private void SignOutMouseEnter(object s, EventArgs e) {
            signOutImg.BackColor = Color.FromArgb(80, 80, 80);
            SignOutImgPanel.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void SignOutMouseLeave(object s, EventArgs e) {
            signOutImg.BackColor = Color.FromArgb(44, 44, 44);
            SignOutImgPanel.BackColor = Color.FromArgb(44, 44, 44); ;
        }

        public static void OpenFile(string path) {
            try {
                if (!File.Exists(path)) File.Create(path).Dispose();
                Application.OpenForms["DisplayingEncodedFileForm"]?.Dispose();
                if (Application.OpenForms["DisplayingEncodedFileForm"] == null) {
                    Form def = new DisplayingEncodedFileForm(path, path != logger);
                    def.Show();
                    def.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 300, Screen.PrimaryScreen.Bounds.Height / 2 - 200);
                }
            }
            catch (Exception ex) { Logger("Ошибка открытия файла", path, ex); }
        }

        private void SignOut_Click(object sender, EventArgs e) {
            if (this.account.GetAccess == "Гость") BackToMain(loginForm, this);
            else {
                string answer = MessageBox.Show("Выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();
                if (answer == "Yes") {
                    Application.OpenForms["DisplayingEncodedFileForm"]?.Dispose();
                    BackToMain(loginForm, this);
                }
            }
        }
    }
}
