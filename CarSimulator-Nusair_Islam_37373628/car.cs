using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator
{
    public class car
    {
        protected string model;
        protected double mass;
        protected double engineForce;
        protected double dragArea;
        public state myState;

        public car(string model, double mass, double engineForce, double dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.engineForce = engineForce;
            this.dragArea = dragArea;
            myState = new state();
        }

        public double getMass()
        {
            return mass;
        }

        public string getModel()
        {
            return model;
        }

        public string getState()
        {
            return String.Format("Position: {0}\tVelocity: {1}\tAcceleration: {2}", myState.position, myState.velocity, myState.acceleration);
        }

        public virtual void drive(double dt)
        {
            double fd = 1.0 / 2.0 * dragArea * 1.225 * myState.velocity * myState.velocity;
            double fn = engineForce - fd;

            double a = Physics1D.compute_acceleration(fn, mass);
            double v = Physics1D.compute_velocity(myState.velocity, a, dt);
            double x = Physics1D.compute_position(myState.position, myState.velocity, dt);

            myState.set(x, v, a, myState.time + dt);
        }
    }

    public class Prius : car
    {
        public Prius(string model="Prius", double mass=1000, double engineForce=750, double dragArea=0.51) : base(model, mass, engineForce, dragArea)
        {
        }
    }

    public class Tesla : car
    {
        public Tesla(string model="Tesla", double mass=1500, double engineForce=1000, double dragArea=0.43) : base(model, mass, engineForce, dragArea)
        {

        }
    }

    public class Mazda : car
    {
        public Mazda(string model="Mazda", double mass=750, double engineForce=2000, double dragArea=1.500) : base(model, mass, engineForce, dragArea)
        {

        }

  
    }

    public class Herbie : car
    {
        public Herbie(string model="Herbie", double mass=100, double engineForce=10000, double dragArea=0.10) : base(model, mass, engineForce, dragArea)
        {

        }

        public override void drive(double dt)
        {
            double fd = engineForce / 1.5;
            double fn = engineForce - fd;

            double a = Physics1D.compute_acceleration(fn, mass);
            double v = Physics1D.compute_velocity(myState.velocity, a, dt);
            double x = Physics1D.compute_position(myState.position, myState.velocity, dt);
            Random r = new Random();
            myState.set(x + r.Next(-10,10), v + r.Next(-5,5), a + r.Next(-5,5), myState.time + dt);
        }
    }
}
