﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace çarpım_tablosu_oluşturma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 1; i <= 10; i++) 
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.Write("{0}*{1}={2}\t",i, j,(i * j));
                }
                Console.WriteLine();
                    
            }

            
            Console.Read();
        }
    }
}
