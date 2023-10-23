using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WorldOfTanks
{
    public class Tank
    {
        private string tankName;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;

        public Tank(string name)
        {
            tankName = name;
            Random random = new Random();
            ammunitionLevel = random.Next(0, 101);
            armorLevel = random.Next(0, 101);
            maneuverabilityLevel = random.Next(0, 101);
        }

        public string GetTankParameters()
        {
            return $"Танк: {tankName}, Боезапас: {ammunitionLevel}%, Броня: {armorLevel}%, Маневренность: {maneuverabilityLevel}%";
        }

        public static bool operator ^(Tank t34, Tank pantera)
        {
            int winCriteria = 0;

            if (t34.ammunitionLevel > pantera.ammunitionLevel)
                winCriteria++;
            if (t34.armorLevel > pantera.armorLevel)
                winCriteria++;
            if (t34.maneuverabilityLevel > pantera.maneuverabilityLevel)
                winCriteria++;

            return winCriteria >= 2;
        }
    }
}
