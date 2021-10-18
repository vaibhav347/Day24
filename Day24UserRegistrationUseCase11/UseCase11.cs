using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24UserRegistrationUseCase11
{
    public class UseCase11
    {
        public void insertData(string mail)
        {
            try
            {
                Regex reg = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                 if (reg.IsMatch(mail))
                    Console.WriteLine("Your Mail : " + mail);
                else
                    Console.WriteLine("Enter Valid Mail");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
