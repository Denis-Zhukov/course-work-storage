using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using static CourseworkDenisZhukov.Auxiliary;
using static CourseworkDenisZhukov.Constants;
using static CourseworkDenisZhukov.TripleDES;

namespace CourseworkDenisZhukov {
    public class Access {
        private static string AdminKey = "XL41iV4fls/QiZK739WPtQ=="; // ANYA

        private string _login;
        public string Login => this._login;

        private string _access;
        public string GetAccess => this._access;

        public Access(string login, string access) {
            this._login = login;
            this._access = access;
        }

        public static bool AddAccount(string login, string password, string secretKey) {
            try {
                if (!File.Exists(accounts)) File.Create(accounts).Dispose();

                // Login check
                using (StreamReader sr = new StreamReader(accounts)) {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                        if (Decrypt(line).Split(';')[0] == login) return false;
                }

                using (StreamWriter sw = new StreamWriter(accounts, true))
                using (MD5 md5 = MD5.Create()) {
                    string role = AdminKey == Convert.ToBase64String(md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(secretKey))) ? "Админ" : "Пользователь";
                    sw.WriteLine(Encrypt($"{login};{Convert.ToBase64String(md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password)))};{role};"));
                }
            }
            catch (Exception e) {
                Logger("Ошибка записи файла", accounts.Split('/').Last(), e);
                MessageBox.Show("Произошла ошибка при создании аккаунта.\nДля подробностей просмотрите файл logger.log", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static Access SignInAccount(string login, string password) {
            try {
                if (!File.Exists(accounts)) File.Create(accounts).Dispose();

                using (StreamReader sr = new StreamReader(accounts)) {
                    string line;
                    while ((line = sr.ReadLine()) != null) {
                        line = Decrypt(line);
                        string[] data = line.Split(';');
                        if (regexAccount.IsMatch(line) && data[0] == login) {
                            using (MD5 md5 = MD5.Create())
                                if (Convert.ToBase64String(md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password))) == data[1])
                                    return new Access(data[0], data[2]);
                            break;
                        }
                    }
                }
            }
            catch (Exception e) {
                Logger("Ошибка записи файла", accounts.Split('/').Last(), e);
                MessageBox.Show("Произошла ошибка при авторизации в аккаунт.\nДля подробностей просмотрите файл logger.log", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }
    }
}
