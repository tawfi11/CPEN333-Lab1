using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CarSimulator
{
    class highway
    {
        static void Main(string[] args)
        {
            int fleet = 25;
            List<Tesla> myTeslas = new List<Tesla>();
            for (int i = 0; i < fleet; i++)
            {
                myTeslas.Add(new Tesla());
            }

            List<Prius> myPriuses = new List<Prius>();
            for (int i=0; i < fleet; i++)
            {
                myPriuses.Add(new Prius());
            }

            List<Mazda> myMazdas = new List<Mazda>();
            for(int i = 0; i < fleet; i++)
            {
                myMazdas.Add(new Mazda());
            }

            List<Herbie> myHerbies = new List<Herbie>();
            for(int i = 0; i < fleet; i++)
            {
                myHerbies.Add(new Herbie());
            }

            int dt = 1;
            int maxTime = 60;
            for(int t = 0; t < maxTime; t += dt)
            {
                for(int i = 0; i < fleet; i++)
                {
                    myTeslas[i].drive(dt);
                    myPriuses[i].drive(dt);
                    myMazdas[i].drive(dt);
                    myHerbies[i].drive(dt);

                    Console.WriteLine("Time: {0}\tFleet: {1}", t, i);
                    Console.WriteLine("Tesla\tx = {0}\tv = {1}\ta = {2}", myTeslas[i].myState.position, myTeslas[i].myState.velocity, myTeslas[i].myState.acceleration);
                    Console.WriteLine("Prius\tx = {0}\tv = {1}\ta = {2}", myTeslas[i].myState.position, myTeslas[i].myState.velocity, myTeslas[i].myState.acceleration);
                    Console.WriteLine("Mazda\tx = {0}\tv = {1}\ta = {2}", myMazdas[i].myState.position, myMazdas[i].myState.velocity, myMazdas[i].myState.acceleration);
                    Console.WriteLine("Mazda\tx = {0}\tv = {1}\ta = {2}", myHerbies[i].myState.position, myHerbies[i].myState.velocity, myHerbies[i].myState.acceleration);
                    if (myTeslas[i].myState.position == myHerbies[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and HERBIE {0} collided", i);
                    if (myTeslas[i].myState.position == myPriuses[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and PRIUS {0} collided", i);
                    if (myTeslas[i].myState.position == myMazdas[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and MAZDA {0} collided", i);
                    if (myHerbies[i].myState.position == myPriuses[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and PRIUS {0} collided", i);
                    if (myTeslas[i].myState.position == myHerbies[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and HERBIE {0} collided", i);
                    if (myTeslas[i].myState.position == myHerbies[i].myState.position)
                        Console.WriteLine("\nTESLA {0} and HERBIE {0} collided", i);

                    Console.WriteLine("\n\n");

                }
            }
        }
    }
}
