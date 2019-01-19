using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VProzzleFix
{
    class Property
    {
        public string name;

        public string Nama
        {
            set
            {
                if(value.Length == 0)
                    value = "Anonymous";
                name = value;
            }
            get
            {
                return name;
            }
        }
    }
}
