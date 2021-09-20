using System;
using System.Collections.Generic;
using System.Text;

namespace CarSimulator
{
    public class Physics1D
    {
        public static double compute_position(double x0, double v, double dt)
        {
            return v * dt + x0;
        }
        public static double compute_velocity(double v0, double a, double dt)
        {
            return a * dt + v0;
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        {
            return (x1 - x0) / (t1 - t0);
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        {
            return (v1 - v0) / (t1 - t0);
        }
        public static double compute_acceleration(double f, double m)
        {
            return f / m;
        }
    }
}
