using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfLists
{
    internal class Car
    {
        string model;
        string colour;
        int year;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
