using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace ValidationGCSE
{
    class Program
    {
        static void Main(string[] args)
        {
            // Validation Tasks- write the validation routines described below under each comment
            // You will have to use indefinte iteration, not for loops!
            string password;
            // LENGTH
            // 1) user should enter a password(string) with more than 4 characters and less than 10
            // keep prompting the user for a password until they enter one of a valid length
            do
            {
                Console.WriteLine("Type password");
                password = Console.ReadLine();
            } while (password.Length < 4 || password.Length > 10);




            // RANGE
            //2) User should enter an number greater than 5 and less than 10, continue to prompt the user
            // until they enter a valid number

           
            int usernum;
            do
            {
                Console.WriteLine("Enter a number greater than 5 and less than 10");
                usernum = Convert.ToInt32(Console.ReadLine());
            } while (usernum <= 5 || usernum >= 10);


            //3) User should enter a even number, continue to prompt the uer until they enter an even number
            //  Modulus coulf be useful here
            
            int usernum2;
            do
            {
                Console.WriteLine("Enter an even number");
                usernum2 = Convert.ToInt32(Console.ReadLine());
            } while (usernum2 % 2 > 0);


            //FORMAT
            //4 User should enter a string that contains a @ and a .(full stop) continue to prompt the
            // user until they enter a valid string.
            string userstring;
            do
            {
                Console.WriteLine("Write something that contains an @ and a .");
                userstring = Console.ReadLine();
            } while (userstring.IndexOf('@') <= 0 && userstring.IndexOf('.') <= 0);



            //Verification
            // User should enter their password twice, the password should be verified.
            // if user does not enter the same password twice they should continue to be
            //prompted for their password
            string password2;
            do
            {
                Console.WriteLine("Type password again");
                password2 = Console.ReadLine();
            } while (password /= password2);

            // EXTENSION Validation - TYPE
            // User should enter a double(as a string. The program should continue to
            // prompt the user until they enter a string that can be converted to a double
            // eg hello is invalid, 47.89 is valid


            // Extension Validation FORMAT
            // validate a postcode entered by the user



        }


    }
}
