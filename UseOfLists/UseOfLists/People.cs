using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseOfLists
{
    internal class People
    {
        string name;
        string surname;
        string job;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}
