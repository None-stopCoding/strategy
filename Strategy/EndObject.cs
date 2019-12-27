using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class EndObject
    {
        private ILineEnding _lineEnding;
        public EndObject(ILineEnding lineEnding)
        {
            _lineEnding = lineEnding;
        }
        public void setLineEnding(ILineEnding lineEnding)
        {
            _lineEnding = lineEnding;
        }
        public string getLineEnding()
        {
            return _lineEnding.getName();
        }
    }
}
