using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_Practise
{
    internal class DataList
    {
        public string[] datas = new string[10];

        public string this[int index]
        {
            get
            {
                return datas[index];
            }
            set
            {
                datas[index] = value;
            }
        }







    }
}
