using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearn
{
    class Human
    {

        private int height;
        private int weight;

        public Human(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }

        public int Height
        {
            get { return height; }
            set { if(value > 0 )height = value; }

        }

        public int Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }

        }

        public int getWeight
        {
            get { return weight; }
        }

    }
}
