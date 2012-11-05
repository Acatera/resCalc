using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace resourceCalculator
{
    public class Part
    {
        public String name;
        public double ammount;

        public Part(String name, int ammount)
        {
            this.name = name;
            this.ammount = ammount;
        }

        public Part(String name, double ammount)
        {
            this.name = name;
            this.ammount = ammount;
        }
    }
}
