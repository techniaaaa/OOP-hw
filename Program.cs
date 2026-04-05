namespace SpacecraftApp
{
    internal partial class Program
    {

        static void Main(string[] args)
        {
            List<Spacecraft> AllSpacecraft = new List<Spacecraft>


            {
                new Rocket("Aggregat-4", 0.8, 1000),
                new Shuttle("Silbervogel", 0.6,800 ),
                new Satellite("Moon", 0.5,300)

            };

            foreach (var ship in AllSpacecraft)
            {
                ship.Status();
                ship.Launch("To the earth");
            }

            MissionControl control = new MissionControl();

            foreach (var ship in AllSpacecraft)
            {
                control.CreateMission("Pioneer 10", "Pluto", 160, ship);
                control.CompleteCurrentMission(ship);
            }

            List<object> Positions = new List<object> { };
            Coordinates currentPos = new Coordinates { X = 10, Y = 30, Z = 40};
            Positions.Add(currentPos);
            foreach (var obj in Positions)
            {
                if (obj is Coordinates c)
                {
                    Log($"Coordinates: X={c.X}, Y={c.Y}, Z = {c.Z}");
                }
            }

            CalculateTrajectory(Positions, Positions, 45, (Rocket)AllSpacecraft[0]);
            CalculateTrajectory(Positions, Positions, 30, (Shuttle)AllSpacecraft[1]);
            CalculateTrajectory(Positions, Positions, 60, (Satellite)AllSpacecraft[2]);
        }
    }
}
