using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetClicker
{
    internal static class RandomCustom
    {
        public static byte RandByte(byte maxValue)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            return (byte)r.Next(maxValue);
        }
        public static byte RandByte(byte minValue, byte maxValue)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            return (byte)r.Next(minValue, maxValue);
        }
        public static byte RandByte()
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            return (byte)r.Next(0, byte.MaxValue);
        }

        public static ulong RandULong(ulong maxValue)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            ulong number;

            number = (ulong)(r.NextDouble() * maxValue);
            return number;
        }
        public static ulong RandULong(ulong minValue, ulong maxValue)
        {
            Random r = new Random ((int)DateTime.Now.Ticks);
            ulong number;
            ulong range = maxValue - minValue;

            number = (ulong)(r.NextDouble() * range) + minValue;
            return number;
        }

        public static double RandDouble(double minRange, double maxRange)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            double range = maxRange - minRange;

            double sample = r.NextDouble();
            return (sample * range) + minRange;
        }

        public static float RandFloat(float minRange, float maxRange)
        {
            Random r = new Random((int)DateTime.Now.Ticks);
            float range = maxRange - minRange;

            double sample = r.NextDouble();
            double scaled = (sample * range) + minRange;

            return (float)scaled;
        }
    }
}
