using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day24UserRegistrationUseCase12
{
    public class UseCase12
    {
        string fname, lname, mail, pass, contact;
        Regex regf = new Regex("^([A-Z]+[A-Za-z])");
        Regex regl = new Regex("^([A-Z]+[A-Za-z])");
        Regex regm = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([azA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        Regex regc = new Regex("^91[0-9]{9}");
        Regex regp1 = new Regex(@".{8,}");
        Regex regp2 = new Regex(@"[A-Z]+");
        Regex regp3 = new Regex(@"[0-9]+");
        Regex regp4 = new Regex(@"[#?!@$%^&*-]+");
        public void insertFname()
        {
            Console.WriteLine("Enter first name");
            fname = Console.ReadLine();
            if (regf.IsMatch(fname) && fname.Length >= 3)
                insertLname();
            else
                throw(new InvalidDetailsException("Invalid first name"));
                
        }
        public void insertLname()
        {
            Console.WriteLine("Enter last name");
            lname = Console.ReadLine();
            if (regl.IsMatch(lname) && lname.Length >= 3)
                insertContact();
            else
                throw (new InvalidDetailsException("Invalid last name"));
            
        }
        public void insertContact()
        {
            Console.WriteLine("Enter contact number");
            contact = Console.ReadLine();
            if (regc.IsMatch(contact))
                insertMail();
            else
                throw (new InvalidDetailsException("Invalid contact"));
            
        }
        public void insertMail()
        {
            Console.WriteLine("Enter email address");
            mail = Console.ReadLine();
            if (regm.IsMatch(mail))
                insertPassword();
            else
                throw (new InvalidDetailsException("Invalid mail"));
            
        }
        public void insertPassword()
        {
            Console.WriteLine("Enter password");
            pass = Console.ReadLine();
            if (regp1.IsMatch(pass) && regp2.IsMatch(pass) && regp3.IsMatch(pass) && regp4.IsMatch(pass))
                displayData();
            else
                throw (new InvalidDetailsException("Invalid password"));
            
        }
        public void displayData()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Entry Successful");
            Console.WriteLine("First Name : " + fname);
            Console.WriteLine("Last Name : " + lname);
            Console.WriteLine("Contact : " + contact);
            Console.WriteLine("Mail-id : " + mail);
            Console.WriteLine("Password : " + pass);

        }
    }
}
