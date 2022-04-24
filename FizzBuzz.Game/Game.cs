using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Game
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
    }
}
