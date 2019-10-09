using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Bridgelabz.ObjectOriented.RegularExpressionDemonstration
{
    class RegularExpression
    {
        public static void Main(String[] args)
        {
            String message = "Hello <Username>,We have your full name as <<Full Username>> in our system.\n" +
            "Your contact number is 91-9916022165.Please, let us know in case of any clarification.\n" +
            "Thank you BridgeLabz 01/01/2016.\n";

            String namePattern = @"<[a-zA-Z]+>";
            String fullNamePattern = @"^<+[a-zA-Z]+>+";
            String phonePattern = @"91-[0-9]{10,10}";
            String datePattern = @"0?[1-31]/0?[1-31]/[1-9][0-9][0-9][0-9]";


            String MyName = "Robin";
            String MyFullName = "Robin kumar";
            String MyNumber = "91-9916022167";
            String CurDate = DateTime.Today.ToString();

            
            Regex a = new Regex(namePattern);
            message = a.Replace(message,MyName);
            Console.WriteLine("\n" + message);

            Regex b = new Regex(fullNamePattern);
            message = b.Replace(message, MyFullName);
            Console.WriteLine("\n" + message);

            Regex c = new Regex(phonePattern);
            message = c.Replace(message, MyNumber);
            Console.WriteLine("\n" + message);

            Regex d = new Regex(datePattern);
            message = d.Replace(message, CurDate);
            Console.WriteLine("\n" + message);



            //Console.WriteLine(temp);




        }

        


    }
}
