using System;
using System.Collections.Generic;
using System.Linq;

namespace Open_Lab_04._06
{
    public class Numbers
    {
        public int[] NoOdds(int[] numbers)
        {
            List<int> evens = new List<int>();
        for (int i = 0; i<numbers.Count(); i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);  
                }
            }
            return evens.ToArray();
        }
    }
}
