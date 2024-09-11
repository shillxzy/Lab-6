using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gendalf
{
    class Food
    {
        private List<string> food;

        public Food (List<string> foods)
        {
            if (foods.Count < 1 || foods.Count > 100)
            {
                throw new Exception("The amount of food is in the range [1...100].");
            }
            food = foods; 
        }

        public int CalculateMoodGendalf()
        {
            int mood = 0;

            for (int i = 0; i < food.Count; i++)
            {
                string item = food[i];
                if (item == "DryBread")
                {
                    mood += 2;
                }
                else if (item == "Lembas")
                {
                    mood += 3;
                }
                else if (item == "Apple")
                {
                    mood += 1;
                }
                else if (item == "Melon")
                {
                    mood += 1;
                }
                else if (item == "HoneyCake")
                {
                    mood += 5;
                }
                else if (item == "Mushrooms")
                {
                    mood -= 10;
                }
                else
                {
                    mood -= 1;
                }
            }

            return mood;
        }
    }
}
