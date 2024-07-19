using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    //*************************** Section: 10 Debugging ***************************
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2,3,4,5,6 };
            var smallestList = GetSmallestThree(numbers, 3);

            foreach (var number in smallestList)
            {
                Console.WriteLine(number);
            }
        }

        public static List<int> GetSmallestThree(List<int> list, int count)
        {
            if(count > list.Count || count<=0)
            {
                throw new ArgumentOutOfRangeException("count", "count should be in between 1 and number of elements in list");
            }
            var smallestList = new List<int>();

            while(smallestList.Count< count)
            {
                int min= GetSmallest(list);
                smallestList.Add(min);
                list.Remove(min);
            }
            return smallestList;

        }

        public static int GetSmallest(List<int> list)
        {
            int min = int.MaxValue;
            foreach (var number in list)
            {
                if (number < min)
                    min = number;
            }
            return min;

        }

    }
}
