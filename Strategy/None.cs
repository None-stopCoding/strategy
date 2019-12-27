using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class None : ILineEnding
    {
        public string getName()
        {
            return "None";
        }
    }
}
