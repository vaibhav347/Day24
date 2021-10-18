using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase8
{
    public class UseCase8
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex(@"[#?!@$%^&*-]+");
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                if (reg.IsMatch(pass))
                    Console.WriteLine("Password : " + pass);
                else
                    Console.WriteLine("Must have one special character");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

    }
}
