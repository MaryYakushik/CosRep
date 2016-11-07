using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    class Parametrs
    {
        // ax + b

        private double a = 0, b = 0;
        private string x;

        public bool setA(string s){
            if (!double.TryParse(s, out a))
            {
                return false;
            }
            return true;
        }

        public double getA()
        {
            return a;
        }

        public bool setB(string s)
        {
            if (!double.TryParse(s, out b))
            {
                return false;
            }
            return true;
        }

        public double getB()
        {
            return b;
        }

        public void setX(string s)
        {
            if (!s.Equals("no dependenses"))
            {
                x = s;
            }
        }

        public string getX()
        {
            return x;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("(" + a.ToString());
            if(x != null)
            {
                result.Append(" * " + x);
                if (b != 0)
                {
                    result.Append(" + " + b.ToString());
                }
            }
            result.Append(")");

            return result.ToString();
        }
    }
}
