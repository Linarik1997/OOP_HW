using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.Strings
{
    /// <summary>
    /// DTO class to read from txt with Names and Emails
    /// </summary>
    public class Info
    {
        public string Name { get; set; }
        public string Mail { get; set; }

        public Info(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }
        public override string ToString()
        {
            return String.Concat(Name, " & ", Mail);
        }
        public void AddToSource()
        {
            StringHelper stringHelper = new StringHelper();
            try
            {
                using (StreamWriter sw = new StreamWriter(stringHelper._sourcePath, true, Encoding.UTF8))
                {
                    sw.WriteLine(this.ToString());
                    Console.WriteLine($"Writer Executed successful\r\nAdded new info:{ToString()}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    public class StringHelper
    {
        public string s;
        internal static readonly char[] separators = { '&' };
        internal readonly string _sourcePath = @"C:\Users\l.khamitov\Desktop\Linar\Studies\OOP\OOP_HW\Strings\Name_Mail.txt";
        internal readonly string _destinationPath = @"C:\Users\l.khamitov\Desktop\Linar\Studies\OOP\OOP_HW\Strings\Mails.txt";


        public StringHelper() { }




        public string Reverse(string s)
        {
            string result = string.Empty;
            for(int i = s.Length-1; i >= 0; i--)
            {
                result += s[i];
            }
            return result;
        }
        public void SearchMail(ref string s)
        {
            var data = GetInfoFromFile();
            foreach(var mail in data)
            {
                s += mail.Mail + "\r\n";
            }
            WriteMails(ref s);
        }



        private List<Info> GetInfoFromFile()
        {
            List<Info> result = new List<Info>();
            try
            {
                using (StreamReader sr = new StreamReader(_sourcePath, System.Text.Encoding.UTF8))
                {
                    string lineToRead;
                    while ((lineToRead = sr.ReadLine()) != null)
                    {
                        var line = lineToRead.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                        result.Add(new Info(line[0], line[1]));
                    }
                    Console.WriteLine("Reader executed successful");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
        private void WriteMails(ref string s)
        {
            try
            {
                using(StreamWriter sw = new StreamWriter(_destinationPath, false, System.Text.Encoding.Default))
                {
                    sw.Write(s);
                    Console.WriteLine("Writer Executed successful");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }       
    }
}
