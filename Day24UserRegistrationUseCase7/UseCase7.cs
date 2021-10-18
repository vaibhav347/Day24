using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase7
{
    public class UseCase7
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex(@"[0-9]+");
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                if (reg.IsMatch(pass))
                    Console.WriteLine("Password : " + pass);
                else
                    Console.WriteLine("Must have one numeric value");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
