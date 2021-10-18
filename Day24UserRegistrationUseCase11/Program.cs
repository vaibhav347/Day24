using System;

namespace Day24UserRegistrationUseCase11
{
    class Program
    {
        static void Main(string[] args)
        {
            UseCase11 obj = new UseCase11();
            obj.insertData("vaibhav@gmail.com");
            obj.insertData("vaibhavaher347@gmail.com");
            obj.insertData("vaibhav_aher13jabil.com");
            obj.insertData("vaibhav@abc.com.in");

        }
    }
}
