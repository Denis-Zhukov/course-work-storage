using CourseworkDenisZhukov.Properties;
using System;
using System.Linq;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;

namespace CourseworkDenisZhukov.Forms {
    public partial class SignUpForm : Form {
        Form signInForm;
        public SignUpForm(Form signInForm) {
            InitializeComponent();

            this.signInForm = signInForm;
            this.backBtn.Click += ( s, e) => BackToMain(signInForm, this);
            this.FormClosing += (s, e) => Application.Exit();
        }

        // Displaying the correctness of the login
        private void Login_TextChanged(object s, EventArgs e) {
            if (regexLogin.IsMatch(login.Text))
                (loginSuccess.Image, loginSuccess.Tag) = (Resources.success, "1");
            else (loginSuccess.Image, loginSuccess.Tag) = (Resources.failure, "0");
        }

        // Displaying the correctness of the password and confirm password
        private void Password_TextChanged(object s, EventArgs e) {
            if (regexPassword.IsMatch(password.Text) && password.Text != login.Text)
                (passwordSuccess.Image, passwordSuccess.Tag) = (Resources.success, "1");
            else (passwordSuccess.Image, passwordSuccess.Tag) = (Resources.failure, "0");

            if (password.Text == passwordConfirm.Text && (string)passwordSuccess.Tag == "1")
                (passwordConfirmSuccess.Image, passwordConfirmSuccess.Tag) = (Resources.success, "1");
            else (passwordConfirmSuccess.Image, passwordConfirmSuccess.Tag) = (Resources.failure, "0");
        }

        // Switch to hide and show password
        private void ToggleVisible(object sender, EventArgs e) {
            PictureBox pic = (PictureBox)sender;
            string txtBoxNm = pic.Name.Remove(pic.Name.Length - 7, 7);
            if ((string)pic.Tag == "hidden") {
                pic.Image = Resources.showed;
                pic.Tag = "showed";
                ((TextBox)Controls.Find(txtBoxNm, true).First()).PasswordChar = '\0';
            }
            else {
                pic.Image = Resources.hidden;
                pic.Tag = "hidden";
                ((TextBox)Controls.Find(txtBoxNm, true).First()).PasswordChar = '*';
            }
        }

        // Registering a new account
        private void SignUp_Click(object s, EventArgs e) {
            if ((string)loginSuccess.Tag != "1" || (string)passwordSuccess.Tag != "1" || (string)passwordConfirmSuccess.Tag != "1") {
                MessageBox.Show("Введите все данные верно.\nЛогин обязан: содержать только латинский алфавит и быть больше 2 символов.\nПароль обязан: Состоять минимум из 6 символов, иметь в своём составе букву в верхнем и нижнем регистрах, цифру и специальный символ.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            (SignUpBtn.Enabled, backBtn.Enabled) = (false, false);
            
            if (Access.AddAccount(login.Text, password.Text, adminKey.Text)) {
                MessageBox.Show("Аккаунт успешно зарегистрирован.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BackToMain(this.signInForm, this);
            }
            else MessageBox.Show($"Аккаунт с текущим логином({login.Text}) уже зарегистрирован.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);

            (SignUpBtn.Enabled, backBtn.Enabled) = (true, true);
        }

        // Any event that leads to field
        private void ToLogin(object s, EventArgs e) => login.Focus();
        private void ToLogin(object s, MouseEventArgs e) => login.Focus();
        private void ToPassword(object s, EventArgs e) => password.Focus();
        private void ToPassword(object s, MouseEventArgs e) => password.Focus();
        private void ToPasswordConfirm(object s, EventArgs e) => passwordConfirm.Focus();
        private void ToPasswordConfirm(object s, MouseEventArgs e) => passwordConfirm.Focus();
        private void ToSecretKey(object s, EventArgs e) => adminKey.Focus();        
    }
}