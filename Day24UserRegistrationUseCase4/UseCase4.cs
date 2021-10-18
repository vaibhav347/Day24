using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21UserRegistrationUseCase4
{
    public class UseCase4
    {
        public void insertData()
        {
            try
            {
                Regex reg = new Regex("^91[0-9]{9}");
                Console.WriteLine("Enter Mobile Number");
                string mobile = Console.ReadLine();
                if (reg.IsMatch(mobile))
                    Console.WriteLine("Mobile : " + mobile);
                else
                    Console.WriteLine("Enter Valid Number");
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
