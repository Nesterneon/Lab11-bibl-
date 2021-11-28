using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_bibl_
{
    public struct Equation
    {
        public int k;
        public double b;

        public int K
        {
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("Недопустимое значание k!");
                }
                else
                {
                    k = value;
                }
            }
            get
            {
                return k;
            }
        }
        public Equation(int k, int b)
        {
            this.k = k;
            this.b = b;
        }
        public void Root()
        {
            double x = -b / k;
            Console.Write("х={0}", x);
        }
    }
}
