using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase1
{
    public class UseCase1
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex("^([A-Z]+[A-Za-z])");
                Console.WriteLine("Enter first name");
                string fname = Console.ReadLine();
                if (reg.IsMatch(fname) && fname.Length >= 3)
                    Console.WriteLine("Your name is : " + fname);
                else
                    Console.WriteLine("Enter Valid Name");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
