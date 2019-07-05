using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple =true)]
    public class LengthAttribute:Attribute
    {
        private int length;
        public LengthAttribute(int nLen)
        {
            this.Length = nLen;

        }

        public int Length { get => length; set => length = value; }
    }
}
