using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RMPOKS_PZ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] logins = new string[] {"student","vasya","director","uchitel" };
            //пароль каждого аккаунта по номеру в массиве соотвествует номеру в массиве логинов,
            //т.е. логин student пароль 12345
            string[] passwords = new string[] {"12345","pupkin","wowdirector","gooduchitel"};
            int counter = 3;
                     
            while (counter>0) {
                Console.WriteLine("Enter login: ");
                string login = Console.ReadLine();
                        for (int i = 0; i < logins.Length; i++)
                        {
                            if (logins[i]==login) 
                            {
                                while (counter>0) {
                                    Console.WriteLine("Enter password: ");
                                    string pswdEntered = Console.ReadLine();

                                    if (passwords[i] == pswdEntered)
                                    {
                                        Console.WriteLine("Enter the system");
                                        counter = 0;
                                        i =logins.Length;
                                        break;
                                    }
                                    else
                                    {
                                        counter--;
                                        Console.WriteLine("Incorrect password, please try again. Attempts remaining:" + counter);
                                    }
                                }
                            } 
                        }
                if (counter>0) {
                    counter--;
                    Console.WriteLine("Incorrect login, please try again. Attempts remaining:" + counter);
                }
            }
            Console.ReadLine();
        }
    }
}