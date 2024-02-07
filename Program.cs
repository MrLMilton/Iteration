using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Numerics;

namespace Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int total = 0;
            //for (int i = 0; i < 7; i++)
            //{
            //    int maxtemp = Convert.ToInt32(Console.ReadLine());
            //    total += maxtemp;
            //}
            //Console.WriteLine($"the average temperature this week is {total / 7}");

            //bool email = false;
            //while (email == false)
            //{
            //    Console.WriteLine("enter email");
            //    string useremail = Console.ReadLine();
            //    //for (int x = 0; x<useremail.Length; x++)
            //    foreach (char c in useremail)
            //    {
            //        if (c == '@')
            //            email = true;

            //    }
            //}
            //Console.WriteLine("email valid");
            //bool email = false;
            //do
            //{
            //    Console.WriteLine("enter email");
            //    string useremail = Console.ReadLine();
            //    foreach (char c in useremail)
            //    {
            //        if (c == '@')
            //            email = true;

            //    }
            //}while (email == false);
            //Console.WriteLine("email valid");
            //BigInteger z  = new BigInteger (1000000000000001);
            //for (int i = 0; i <z ; i+=10)
            //{
            //    Console.Write($"I'm watching you, Aun. Always watching. Always.");
            //}

            ////challenge 17
            //for (int i = 1; i < 11; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //int x = 1;
            //while (x < 11) 
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            ////challenge 18
            //for (int i = 0; i < 21; i+=5)
            //{
            //        Console.WriteLine(i);
            //}
            // challenge 19
            //int guess = 0;
            //while (guess != 7) 
            //{
            //    Console.WriteLine("please guess my number");
            //    guess = Convert.ToInt16(Console.ReadLine());
            //}
            //Console.WriteLine("Well done");
            //int guess = 0;
            //do
            //{
            //    Console.WriteLine("please guess my number");
            //    guess = Convert.ToInt16(Console.ReadLine());
            //} while (guess != 7);
            //Console.WriteLine("Well done");
            string usersname = "mrhall";
            string userspassword = "pass123";
            string username = " ";
            string password = " ";
            int attempts = 0;
            bool valid = false;
            while (valid == false || attempts <4)
            {
                do
                {
                    Console.WriteLine("enter your username");
                    username = Console.ReadLine();
                    Console.WriteLine("enter your password");
                    password = Console.ReadLine();
                    attempts++;
                } while (usersname != username && userspassword != password);
                valid = true;
            }
            Console.WriteLine("too many incorrect attempt");
        }
    }
}
