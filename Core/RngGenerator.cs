
using System;
using System.Security.Cryptography;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ATowerDefenceGame
{
    static class RngGenerator
    {
        public static uint GetUInt32()
        {
            byte[] rand = new byte[4];
            RandomNumberGenerator.Create().GetBytes(rand);

            return BitConverter.ToUInt32(rand, 0);
        }

        public static bool GetBool()
        {
            byte[] rand = new byte[1];
            RandomNumberGenerator.Create().GetBytes(rand);

            return rand[0] % 2 == 0;
        }
    }
}