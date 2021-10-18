using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase2
{
    public class UseCase2
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex("^([A-Z]+[A-Za-z])");
                Console.WriteLine("Enter Last name");
                string fname = Console.ReadLine();
                if (reg.IsMatch(fname) && fname.Length >= 3)
                    Console.WriteLine("Your name is : " + fname);
                else
                    Console.WriteLine("Enter Valid Name");
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }


        }
    }
}
