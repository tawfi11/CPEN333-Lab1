using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator
{
    public class state
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        public state(double position=0, double velocity=0, double acceleration=0,double time=0)
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;
        }

        public void set(double x, double v, double a, double t)
        {
            position = x;
            velocity = v;
            acceleration = a;
            time = t;

            //Console.WriteLine("time:{0}\tvelocity:{1}\tacceleration:{2}\tposition:{3}", time, velocity, acceleration, position);
        }
        
    }
}
