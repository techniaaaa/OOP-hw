using System;
using System.Collections.Generic;
using System.Text;

namespace SpacecraftApp
{
    internal class MissionControl
    {
        public List<Mission> Missions { get; set; } = new List<Mission>();
        public void CreateMission(string name, string destination, double duration, Spacecraft spacecraft)
        {
            if (spacecraft.CurrentMission != null)
            {
                Program.Log($"The ship {spacecraft.Name} is already busy with a mission. Try later");

            }
            else
            {
                spacecraft.CurrentMission = new Mission(name, destination, duration);
                Missions.Add(spacecraft.CurrentMission);
            }
            

        }

        public void CompleteCurrentMission(Spacecraft spacecraft)
        {
            if (spacecraft.CurrentMission!=null)
            {
                spacecraft.Launch(spacecraft.CurrentMission.Destination);
                spacecraft.CurrentMission = null;

            }
            else
            {
                Program.Log($"No missions found currently for the ship {spacecraft.Name}");
            }
        }


    }
}
