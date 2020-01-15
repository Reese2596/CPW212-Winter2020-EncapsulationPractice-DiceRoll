using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationPractice_DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            //Die myDice = new Die();
            //Console.WriteLine(myDice.FaceValue);

            //myDice.Roll();

            //Console.WriteLine(myDice.FaceValue);
            Die[] dice = new Die[5]; //Create five die
            InitDice(dice);
            PrintDieFaceValues(dice);

            Console.WriteLine("\n\n\nHolding first 3 Die\n\n\n");
            //Hold the first 3 dice
            dice[0].IsHeld = true;
            dice[1].IsHeld = true;
            dice[2].IsHeld = true;
            RollAllDie(dice);
            PrintDieFaceValues(dice);

            Console.ReadKey();
        }

        private static void RollAllDie(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i].Roll();
            }
        }

        private static void PrintDieFaceValues(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                Console.WriteLine(dice[i].FaceValue);//print out the values
            }
        }

        /// <summary>
        /// Initailizes all die in a given array.
        /// assumes array has been given a length
        /// </summary>
        /// <param name="dice"></param>
        private static void InitDice(Die[] dice)
        {
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
            }
        }
    }
}
