using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace Money_transfer
{
    class Read
    {
        public static void read(ref List<program.money> m)
        {
            string path = Environment.CurrentDirectory;
            path = path.Replace("bin\\Debug\\net6.0", "dataMoney.csv");
            string[] l = File.ReadAllLines(path, Encoding.Default);
            foreach (var line in l)
            {
                string[] s = line.Split(';');
                program.money a = new program.money();

                check(s[0], out a.rub);
                check(s[1], out a.kop);
                check(s[2], out a.dol);
                check(s[3], out a.euro);
                check(s[4], out a.rup);
                check(s[5], out a.kron);
                check(s[6], out a.yuan);

                m.Add(a);
            }
        }

        static void check(string s, out double a)
        {
            if(Regex.IsMatch(s, @"^[0-9]+$"))
            {
                if (!String.IsNullOrEmpty(s))
                {
                    a = Convert.ToInt32(s);
                }
                else
                {
                    a = 0;
                }
            }
            else
            {
                a = 0;
            }
        }
    }
}