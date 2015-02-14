﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message;
            string MessageLength;
            string Mess;
    
            Console.WriteLine("==========================Assingnment 2 Project 1=========================");
            Console.WriteLine("Please insert your message, It should be more than 0 and less than 140");
            Console.WriteLine("==========================================================================");
            Console.Write("\n");
            Message = Console.ReadLine();
            Message = Convert.ToString(Message.Length);
            if (Message.Length <= 140)
                 {
                    Console.WriteLine("Since Your Message Has {0} Characters, It Has Less than 140 characters therefore it is accepted", Message);
                 }
            else
                {
                    Console.WriteLine("Since Your Message Has {0} Characters, It Has More than 140 characters therefore it is NOT accepted", Message);
                }
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Press any key to exit ...");
                Console.ReadKey();
            
        }
    }
}
