using System;
using System.Text.RegularExpressions;

namespace CourseworkDenisZhukov {
    public static class Constants {
        public const string storage = "./storage.txt"; 
        public const string importExport = "./importExport.txt"; 
        public const string logger = "./logger.log";
        public static string reportOfStorage { get; } = $"./{DateTime.Now.Ticks}_report.txt";

        public const string accounts = "/Program Files/accounts.txt";

        public static Regex regexLogin { get; } = new Regex(@"^[a-zA-Z]{1}[a-zA-Z0-9_-]{1,31}$");
        public static Regex regexPassword { get; } = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*~_])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*~_]{6,32}$");

        public static Regex regexAccount { get; } = new Regex(@"^[a-zA-Z]{1}[a-zA-Z0-9_-]{1,31};[\w+\/]{22}\=\=;(Админ|Пользователь);$");
        public static Regex regexStorage { get; } = new Regex(@"^([^\;])+?\s?;\s?([^\;])+?\s?;\s?(0|[1-9]\d*?)([\.,]\d{0,4})?\s?;\s?(0|[1-9]\d*?)([\.,]\d{0,2})?\s?;$");
        public static Regex regexImportExport { get; } = new Regex(@"^(?:(?:31(\.)(?:0?[13578]|1[02]))\1|(?:(?:29|30)(\.)(?:0?[1,3-9]|1[0-2])\2))(?:(?:1[6-9]|[2-9]\d)?\d{2})|^(?:29(\.)0?2\3(?:(?:(?:1[6-9]|[2-9]\d)?(?:0[48]|[2468][048]|[13579][26])|(?:(?:16|[2468][048]|[3579][26])00))))|^(?:0?[1-9]|1\d|2[0-8])(\.)(?:(?:0?[1-9])|(?:1[0-2]))\4(?:(?:1[6-9]|[2-9]\d)?\d{2});([^\;])+?\s?;[+\-]\d+([\.,]\d{0,4})?;");
    }
}
