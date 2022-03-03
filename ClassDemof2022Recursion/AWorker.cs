using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

namespace ClassDemof2022Recursion
{
    public class AWorker
    {
        public AWorker()
        {
        }

        public void Start()
        {
            int antal = 1000;

            //TestRukursion(antal);

            
            PrintFibonacciLoop(antal);
            //PrintFibonacci(antal);
            
        }

        

        private void TestRukursion(int tal)
        {
            // 1 step - stop betingelse
            if (tal == 0)
            {
                return; // stopper
            }

            // 2 step - gør noget simpelt
            Console.WriteLine(tal);


            // 3 step - kalder sig selv
            TestRukursion(tal - 1);
        }

        


        private void PrintFibonacci(int nummer)
        {
            if (nummer < 0)
            {
                Console.WriteLine("Kan ikke finde fibonaccii af negative tal");
            }
            else
            {
                for (int i = 1; i < nummer; i++)
                {
                    Console.WriteLine(Fib(i));
                }
            }

        }

        private int Fib(int i)
        {
            // stop
            if (i == 0)
            {
                return 0;
            }

            if (i == 1)
            {
                return 1;
            }

            // rekursive
            return Fib(i - 1) + Fib(i - 2);
        }


        private void PrintFibonacciLoop(int antal)
        {
            List<int> fib = new List<int>();
            fib.Add(0); // dummy på index 0
            for (int i = 1; i <= antal; i++)
            {
                if (i < 3)
                {
                    fib.Add(1);
                }
                else
                {
                    fib.Add( fib[i-1] + fib[i-2]);
                }

            }

            foreach (int i in fib)
            {
                Console.WriteLine(i);
            }

        }

    }


}