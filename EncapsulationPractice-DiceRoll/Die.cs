using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice_DiceRoll
{
    /// <summary>
    /// Represents a single 6-sided die
    /// </summary>
    class Die
    {
        //static members get shared across all instances of this class
        private static Random rand;

        /// <summary>
        /// Runs once before any die obj is created and initailizes random obj once
        /// </summary>
        static Die()
        {
            rand = new Random();
        }

        public Die()
        {
            Roll();
        }
        /// <summary>
        /// current value of the die
        /// </summary>
        public byte FaceValue { get; private set; } //face value set so cant give value of die in other class.
        /// <summary>
        /// die that are held are not rolled
        /// </summary>
        public bool IsHeld { get; set; }

        /// <summary>
        /// Generates a new random face value
        /// sets face value
        /// returns the generated face value
        /// </summary>
        public byte Roll()
        {
            //if current die is held return the curr value
            if (IsHeld)
            {
                return FaceValue;
            }
            const byte MinValue = 1;
            const byte MaxValue = 6;
            //Offset is used for exclusive range Random.Next()
            const byte Offset = 1;
            byte newValue = (byte)rand.Next(MinValue, MaxValue + Offset);

            FaceValue = newValue;
            return newValue;
        }
    }
}
