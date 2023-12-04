using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class LivingOrganism
    {
        public int Age { get; set; }
        public int Energy { get; set; }
        public double Size { get; set; }

        public LivingOrganism(int energy, int age, double size)
        {
            Age = age;
            Energy = energy;
            Size = size;
        }
    }
}
