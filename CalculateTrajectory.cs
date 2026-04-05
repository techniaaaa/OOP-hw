using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftApp
{
    internal partial class Program
    {
        public static void CalculateTrajectory(List<object> StartPointCoordinates, List<object> EndPointCoordinates, int angle, Rocket rocket)
        {

            foreach (var pos in StartPointCoordinates)
            {
                if (pos is Coordinates c)
                {

                    ///calculating trajectory using coord-s of the spacecraft using c.X, c.Y, c.Z for a rocket

                }
            }



        }
        public static void CalculateTrajectory(List<object> StartPointCoordinates, List<object> EndPointCoordinates, int angle, Satellite satellite)
        {

            foreach (var pos in StartPointCoordinates)
            {
                if (pos is Coordinates c)
                {

                    ///calculating trajectory using coord-s of the spacecraft using c.X, c.Y, c.Z for a satellite
                }
            }

        }

        public static void CalculateTrajectory(List<object> StartPointCoordinates, List<object> EndPointCoordinates, int angle, Shuttle shuttle)
        {

            foreach (var pos in StartPointCoordinates)
            {
                if (pos is Coordinates c)
                {

                    ///calculating trajectory using coord-s of the spacecraft using c.X, c.Y, c.Z for a shuttle
                }
            }

        }


    }
}
