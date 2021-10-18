using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase5
{
    public class UseCase5
    {
        public void insertData()
        {
            try
            {
                Regex reg=new Regex(@".{8,}");
                Console.WriteLine("Enter Password");
                string pass = Console.ReadLine();
                if (reg.IsMatch(pass))
                    Console.WriteLine("Your password : " + pass);
                else
                    Console.WriteLine("Password must contain atleast 8 characters");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
