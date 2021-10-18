using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase6
{
    public class UseCase6
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex(@"[A-Z]+");
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                if (reg.IsMatch(pass))
                    Console.WriteLine("Password : " + pass);
                else
                    Console.WriteLine("Must have onne upper case character");
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
            
        }
    }
}
