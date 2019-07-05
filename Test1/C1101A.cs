using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class C1101A
    {
        private string m_ID;
        private string m_NAME;
        private int m_SEQ;


        public C1101A()
        {

        }

        public string ID { get => m_ID; set => m_ID = value; }
        public string NAME { get => m_NAME; set => m_NAME = value; }
        public int SEQ { get => m_SEQ; set => m_SEQ = value; }
    }
}
