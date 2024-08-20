using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Rental
{
    internal interface IRentable
    {
        public void Rent() { }

        public void Return() { }
    }
}
