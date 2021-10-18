using System;

namespace Day24UserRegistrationUseCase12
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase12 obj = new UseCase12();
            try
            {
                obj.insertFname();
            }
            catch (InvalidDetailsException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
