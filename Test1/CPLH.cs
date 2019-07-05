using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    class CPLH : CMarshal
    {
        public string NAME;
        public string ID;
        public int SEQ;
    }
}
           