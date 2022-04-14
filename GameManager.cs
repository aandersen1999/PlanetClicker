using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetClicker
{
    internal class GameManager
    {
        private static GameManager instance;
        public static GameManager Instance { get { return instance; } }

        private ulong popKilled = 0;
        public ulong PopKilled { get { return popKilled; } }
        private ulong plantetsDestroyed = 0;
        public ulong PlantetsDestroyed { get { return plantetsDestroyed; } }


        public GameManager()
        {
            instance = this;
        }

        public void AddKilled(ulong killed)
        {
            popKilled += killed;
        }

        public void DeleteKilled(ulong killed) 
        {
            popKilled -= killed; 
        }

        public void AddPlanet()
        {
            plantetsDestroyed++;
        }
        public void AddPlanet(ulong destroyed)
        {
            plantetsDestroyed += destroyed;
        }
    }
}
