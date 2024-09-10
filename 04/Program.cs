﻿namespace Gendalf
{
    class Eating
    {
        static void Main()
        {
            try
            {
                List<string> list = new List<string>();

                string[] input = Console.ReadLine().Split(' ');

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ";")
                    {
                        break;
                    }
                    list.Add(input[i]);
                }

                Food food = new Food(list);
                int Mood = food.CalculateMoodGendalf();
                Console.WriteLine(Mood);

                if (Mood < -5)
                {
                    Console.WriteLine("Angry");
                }
                else if (Mood > -5 || Mood < 0)
                {
                    Console.WriteLine("Sad");
                }
                else if (Mood >= 1 || Mood <= 15)
                {
                    Console.WriteLine("Happy");
                }
                else
                {
                    Console.WriteLine("Bliss");
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}