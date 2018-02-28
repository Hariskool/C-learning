using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; //for regular exp
using System.Threading.Tasks;

namespace regularExpression
{
    class Program
    {
        //Regular Expression

        //date
        static void CheckDate(string Uinput)
        {
            string Datepattern = @"(([a-zA-Z]+) (\d{2}))";  // month day

            
            ///single match
            //Match match = Regex.Match(Uinput, pattern);
            //if (match.Success)
            //{
            //    Console.WriteLine(match.Value);
               
            //}
            
            // for multiple match
            MatchCollection matchc = Regex.Matches(Uinput,Datepattern);
            foreach (Match mVar in matchc)
            {
                Console.WriteLine(mVar.Value);
            }
            //date formate Dxx-Mxx-Y2012

            string Datepattern2 = @"((0[1-9]|[12]\d)|3[01])(-|/)((0[1-9])|(1[012]))(-|/)\d{4}";
            MatchCollection matchD2 = Regex.Matches(Uinput, Datepattern2);
            foreach (Match mVar in matchD2)
            {
                Console.WriteLine(mVar.Value);
            }


        }

        //phonenumber
        static void CheckPhoneNumber(string Uinput)
        {
            //0321-4315215
            //string pattern = @"(\d{4})(-| )(\d{7})";
            //MatchCollection matchp = Regex.Matches(Uinput, pattern);
            //{
            //    foreach (Match var in matchp)
            //    {
            //        Console.WriteLine(var.Value);
            //    }

            //}
            //+92321-7862567

            string pattern = @"([+92]\d{5})(-| )(\d{7})";
            MatchCollection matchp = Regex.Matches(Uinput, pattern);
            {
                foreach (Match var in matchp)
                {
                    Console.WriteLine(var.Value);
                }

            }

        }
        
        //email checker
        static void CheckEmail(string Uinput)
        {
            //atleast 4 character and 4 domains allowed
            string Emailpattern = @"([\w\d]{4,})+@[gmail|yahoo|hotmail]+.com";

            MatchCollection matchc = Regex.Matches(Uinput, Emailpattern);
            foreach (Match mVar in matchc)
            {
                Console.WriteLine(mVar.Value);
            }
        }
        static void Main(string[] args)
        {

            // Program.CheckDate(@"this is 22/12/2021");
            //  Program.CheckPhoneNumber(@"this is my phone number 92321 3214564");

          //  Program.CheckEmail(@"shis@yahoo.com");

        }
    }
}
