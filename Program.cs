using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay6Ex01
{
    public class ValidationExc : Exception
    {
        public ValidationExc(string msg): base(msg) { }
    }
    public class UserRegSys
    {

        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("User Registration : ");
                    Console.WriteLine("Enter Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter your password");
                    string pswd = Console.ReadLine();
                    Validate(name);
                    Validate(email);
                    Validate(pswd);
                    checkLength(name);
                    checkLength(pswd);
                    Console.WriteLine("Registration Successful");
                }
                catch (ValidationExc ex) { Console.WriteLine("Validation Unsuccessful : "+ex.Message); }
                catch (Exception ex) { Console.WriteLine(" Error !!! " + ex.Message); }
                finally { Console.WriteLine("** End of Program **");
                    Console.ReadKey();
                }

            }
            public static void Validate(string token)
            {
                if (string.IsNullOrEmpty(token))
                {
                    throw new ValidationExc("Validation Error ");
                }
            }
            public static void checkLength(string token) {  if (token.Length <= 6)
                {
                    throw new ValidationExc($"{token} length is too small ");
                } }
        }
    }
}
