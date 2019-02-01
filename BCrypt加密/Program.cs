using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCrypt加密
{
    class Program
    {
        static void Main(string[] args)
        {
            var pwd = "21232f297a57a5a743894a0e4a801fc3";
            while (true)
            {
                string passwordHash = BCrypt.Net.BCrypt.HashPassword(pwd);
                Console.WriteLine("PasswordHash: " + passwordHash);
                Console.WriteLine("HashLenght: " + passwordHash.Length);
                var input = Console.ReadLine();
                var result = BCrypt.Net.BCrypt.Verify(input, passwordHash);
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
