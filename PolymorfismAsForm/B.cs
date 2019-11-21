using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorfismAsForm
{
    class B: A
    {
        public new string Description()
        {
            return "Objektet är av typ B";
        }
    }
}
