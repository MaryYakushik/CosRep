using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1.ParametrsFunctions
{
    class ParametrsFunction
    {
        public List<Parametrs> function;
        public List<List<int>> mainDependenses;
        private const int countOfParametrs = 3;

        public ParametrsFunction()
        {
            function = new List<Parametrs>();

            for (int i = 0; i < countOfParametrs; i++)
            {
                function.Add(new Parametrs());
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("x(t) = ");
            result.Append(function[0].ToString() + " * A0 + ");
            result.Append(function[1].ToString() + " * w0 * t + ");
            result.Append(function[2].ToString() + " * f0");
            return result.ToString();
        }
    }
}
