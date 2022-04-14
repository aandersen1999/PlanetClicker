using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetClicker
{
    internal class Planet
    {
        private PlanetType type;
        public PlanetType Type { get { return type; } }
        private float size;
        public float Size { get { return size; } }
        private ulong pop;
        public ulong Pop { get { return pop; } }
        private byte damage;
        public byte Damage { get { return damage;} }
        private string imgPath;
        public string ImagePath { get { return imgPath; } }
        private Uri imgUri;
        public Uri ImageUri { get { return imgUri; } }

        const ulong MAX_PLANET_POP = 10000000000;
        const ulong MIN_PLANET_POP = 1000000000;


        public Planet()
        {
            type = (PlanetType)RandomCustom.RandByte(0, 6);
            size = RandomCustom.RandFloat(.5f, 2.0f);
            pop = CalcPop(size);
            damage = 0;
        }

        private ulong CalcPop(float planetSize)
        {
            ulong pop;
            pop = RandomCustom.RandULong(MIN_PLANET_POP, MAX_PLANET_POP);
            pop = (ulong)(pop * planetSize);
            return pop;
        }

    }

    internal enum PlanetType : byte 
    { 
        Dry,
        Gas1,
        Gas2,
        Ice,
        Islands,
        Lava,
        Wet
    }
}
