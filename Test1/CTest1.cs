using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test1
{
    public class CTest1
    {
        [LengthAttribute(30)]
        public int name;

        [LengthAttribute(8)]
        public int id;

        public int Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }



        public int GetLength<T>(T obj)
        {
            
            object[] attrs  = obj.GetType().GetCustomAttributes(false);

            foreach (LengthAttribute item in attrs)
            {
                int l = item.Length;
            }

            return 0;           
        }


    }
}