using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Square
    {
        public int heigth;
        public int width;
        public Square(int heigth,int width)
        {
            this.heigth = heigth;
            this.width = width;
        }
        public float Area() 
        {
            float area = this.heigth * this.width;
            return area;
               
        }
        public float AreaTraingular()
        {
            float area = this.heigth * this.width / 2;
            return area;
        }
    }
}
