using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Games
{
    public class Game
    {
        public bool Divisible3(int Number)
        {
            if ((Number%3)==0)
            {
                return true;
            }
            return false;
        }
        public bool Divisible5(int Number)
        {
            if ((Number % 5) == 0)
            {
                return true;
            }
            return false;
        }
        public bool Divisible5and3(int Number)
        {
            if (Divisible5(Number)&&Divisible3(Number))
            {
                return true;
            }
            return false;
        }
        public string Gameflow()
        {
            for (int i = 0; i < 10000; i++)
            {
                if (Divisible5and3(i))
                {
                    return i + ":bizzbuzz";
                }
                else if (Divisible3(i))
                {
                    return i + ":fizz";
                }
                else if (Divisible5(i))
                {
                    return i + ":buzz";
                }
                return "";

            }
            return "";
        }
    }
}
