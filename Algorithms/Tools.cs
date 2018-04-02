using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Algorithms
{
    static class Tools
    {

        public static List<int> CreateRandomNumbers(int min, int max)
        {
            List<int> randomNumbers = new List<int>();
            Random rnd = new Random();
            for (int i = min; i <= max; i++)
            {
                randomNumbers.Add(rnd.Next(min, max)); // creates a number between A and B
            }
            return randomNumbers;
        }

        public static List<string> ShowMethodNames()
        {
            List<string> mp = new List<string>();    
            MethodInfo[] methodInfo = typeof(SortAlgorithms).GetMethods();
            foreach (var methodName in methodInfo)
            {
                if (methodName.DeclaringType.Name == "SortAlgorithms") mp.Add(methodName.Name);
            }
            return mp;
        }

    }
}
