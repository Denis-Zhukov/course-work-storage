using CourseworkDenisZhukov.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;

namespace CourseworkDenisZhukov.Forms {
    public partial class SignInForm : Form {
        public SignInForm() {
            InitializeComponent();
            this.Click += (s, e) => signInBtn.Focus();
            this.FormClosing += (s, e) => Application.Exit();
        }

        // Any event that leads to field
        private void ToLogin(object s, EventArgs e) => login.Focus();
        private void ToLogin(object s, MouseEventArgs e) => login.Focus();
        private void ToPassword(object s, EventArgs e) => password.Focus();
        private void ToPassword(object s, MouseEventArgs e) => password.Focus();

        // Linked text hover
        private void LinkedText_MouseEnter(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.FromArgb(255, 255, 0);
        private void LinkedText_MouseLeave(object sender, EventArgs e) => ((Label)sender).ForeColor = Color.FromArgb(255, 255, 255);

        // Sign in to an account
        private void SignIn_Click(object s, EventArgs e) {
            Access acc = Access.SignInAccount(login.Text, password.Text);
            if (acc == null) {
                MessageBox.Show("Неверный логин и/или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (acc?.GetAccess == "Админ") ChangeWindow(this, new AdminMainForm(acc, this));
            else if (acc?.GetAccess != null) ChangeWindow(this, new UserMainForm(acc, this));
            else {
                MessageBox.Show("Неверный логин и/или пароль.", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if ((string)passwordVisible.Tag == "showed") PasswordVisible_Toggle(passwordVisible, null);
            password.Text = "";
        }

        // Sign in like guest
        private void SignInGuest_Click(object s, EventArgs e) {
            if ((string)passwordVisible.Tag == "showed")
                PasswordVisible_Toggle(passwordVisible, null);
            password.Text = "";

            ChangeWindow(this, new UserMainForm(new Access("-", "Гость"), this));
        }

        // Eye "Show/hide password"
        private void PasswordVisible_Toggle(object s, EventArgs e) {
            if ((string)passwordVisible.Tag == "hidden") {
                passwordVisible.Image = Resources.showed;
                passwordVisible.Tag = "showed";
                password.PasswordChar = '\0';
            }
            else {
                passwordVisible.Image = Resources.hidden;
                passwordVisible.Tag = "hidden";
                password.PasswordChar = '*';
            }
        }

        // Sign up new account
        private void SignUp_Click(object s, EventArgs e) {
            if ((string)passwordVisible.Tag == "showed")
                PasswordVisible_Toggle(passwordVisible, null);
            password.Text = "";

            ChangeWindow(this, new SignUpForm(this));
        }
    }
}
