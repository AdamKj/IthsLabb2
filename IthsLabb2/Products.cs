using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IthsLabb2
{
    class Products
    {
        public string Apple { get; set; }
        public string Pear { get; set; }
        public string Banana { get; set; }

        public Products(string apple, string pear, string banana)
        {
            Apple = apple;
            Pear = pear;
            Banana = banana;
        }
    }
}
