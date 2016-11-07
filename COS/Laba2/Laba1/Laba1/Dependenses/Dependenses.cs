using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.Dependenses
{
    static class Dependenses
    {
        private const int countOfvariables = 3;
        private const string A0 = "A0", w0 = "w0", f0 = "φ0", t = "t";

        private static List<int> simpleDependenses;
        private static List<List<int>> mainDependenses;

        static Dependenses()
        {
            simpleDependenses = new List<int>();
            for (int i = 0; i < countOfvariables; i++)
            {
                simpleDependenses.Add(-1);
            }
        }

        public static List<List<int>> getMainDependenses()
        {
            return mainDependenses;
        }

        public static int getCountOfVariables()
        {
            return countOfvariables;
        }

        public static void setDependenses(String s1, String s2)
        {
            int first = convertStringToInt(s1);
            int second = convertStringToInt(s2);

            setData(first, second);

            calculateDependenses();
        }

        private static int convertStringToInt(String s)
        {
            if (s.Equals(A0))
            {
                return 0;
            }
            if (s.Equals(w0))
            {
                return 1;
            }
            if (s.Equals(f0))
            {
                return 2;
            }
            if (s.Equals(t))
            {
                return 3;
            }

            return -1;
        }

        private static void setData(int row, int col)
        {
            simpleDependenses[row] = col;
        }

        private static void calculateDependenses()
        {
            mainDependenses = new List<List<int>>();
            for (int i = 0; i < countOfvariables; i++)
            {
                mainDependenses.Add(new List<int>());
                mainDependenses[i].Add(i);
                int number = simpleDependenses[i];
                do{
                    if (number != -1 && number != 3)
                    {
                        mainDependenses[i].Add(number);
                        number = simpleDependenses[number];
                    }
                    else
                    {
                        number = -1;
                    }
                }while(number != i && number != -1);
            }
        }

        public static bool hasDependenses(string s1, String s2)
        {
            int first = convertStringToInt(s1);
            int second = convertStringToInt(s2);

            if (mainDependenses != null)
            {
                if (mainDependenses[first].Contains(second))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
