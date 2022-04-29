using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G6_5_interface_SDA
{
        class Count : IComparer<Company>
        {
            public int Compare(Company x, Company y)
            {
                if (x.Persons > y.Persons)
                    return 1;
                else if (x.Persons < y.Persons)
                    return -1;
                else return 0;
            }
        }
}
