using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_DZ_Test
{
    class Class1
    {
        public int num
        {
            get { return num; }
            set
            {
                if (value == 4)
                    num = value;
            }
        }

        public int Get()
        {
            return Get();
        }
        public void Set(int value)
        {
            if (value == 4)
                Set(value);
        }
    }
}
