using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using static CourseworkDenisZhukov.TripleDES;
using static CourseworkDenisZhukov.Auxiliary;

namespace CourseworkDenisZhukov {
    public static class Extensions {

        /// <summary>
        /// Writes line-by-col information from a file to a list.
        /// </summary>
        /// <param name="sr">StreamReader.</param>
        /// <param name="list">List of values.</param>
        /// <param name="delimiter">Delimiter in file.</param>
        /// <param name="regex">Regular expression for string matching.</param>
        /// <param name="changedCol">If you need to change the main element of the list, then you need to specify its number in the division.</param>
        public static void ToList(this StreamReader sr, List<string> list, char delimiter, Regex regex, int changedCol = 0, bool uniq = true) {
            string str;
            while (( str = sr.ReadLine() ) != null) {
                if (str == "") continue;
                str = Decrypt(str);
                if (!regex.Match(str).Success) continue;
                string[] col = str.Split(delimiter);
                Array.Resize(ref col, list.Capacity);
                col = col.Select(el => el.Trim()).ToArray();
                if (changedCol < col.Length) (col[0], col[changedCol]) = (col[changedCol], col[0]);
                if (!uniq || !list.Contains(col[0])) list.Add(col);
            }
        }

        /// <summary>
        /// Save information column-by-row from the list to a file.
        /// </summary>
        /// <param name="list">List with data.</param>
        /// <param name="path">The path to the file where you want to save the information.</param>
        /// <param name="delimiter">Split between information in line.</param>
        /// <param name="append">Append or rewrite file.</param>
        public static void ToFile(this List<string> list, string path, char delimiter, bool append = false) {
            try {
                if (!File.Exists(path)) File.Create(path).Dispose();
                using (StreamWriter sw = new StreamWriter(path, append)) {
                    string line;
                    for (int i = 0; i < list.Count; i++) {
                        line = String.Join(delimiter.ToString(), list[i]);
                        sw.WriteLine(Encrypt(line + delimiter));
                    }
                }
            }
            catch (Exception e) { Logger("Ошибка записи файла", path.Split('/').Last(), e); }
        }

        public static bool ContainsString(this List<string> list, string value, bool deepSearch = false) {
            if (value == null) throw new Exception($"Method Contains dont accept value null");
            foreach (List<string> l in list) {
                if (l.Value.ToLower().Trim().CompareTo(value.ToLower().Trim()) == 0) return true;
            }
            if (deepSearch) {
                for (int i = 0; i < list.Count; i++) {
                    string[] arr = list[i];
                    for (int j = 0; j < list.Capacity; j++) {
                        if (arr[j] != null && arr[j].ToLower().Trim().CompareTo(value.ToLower().Trim()) == 0) return true;
                    }
                }
            }
            return false;
        }
    }
}
