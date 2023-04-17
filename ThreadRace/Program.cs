﻿namespace threadRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Read, Set Go...");
            int t1Location = 0;
            int t2Location = 0;

            //Creating Threads
            Thread t1 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Speedy Gonzales";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t1Location);
                }

            });
            Thread t2 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Road Runner";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            // New threads
            Thread t3 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Wile E. Coyote";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            Thread t4 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Bugs Bunny";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            Thread t5 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Daffy Duck";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            Thread t6 = new Thread(delegate ()
            {
                Thread.CurrentThread.Name = "Elmber Fudd";
                for (int i = 0; i < 100; i++)
                {
                    if (t1Location < 100 && t2Location < 100)
                        MoveIt(ref t2Location);

                }
            });

            t4.Priority = ThreadPriority.AboveNormal;

            //Executing the methods
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            Console.WriteLine("Race has ended");
        }
        static void MoveIt(ref int location)
        {
            location++;
            Console.WriteLine($"{Thread.CurrentThread.Name} location={location}");
            if (location >= 100)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is the winner");
                return;
            }
        }

    }
}