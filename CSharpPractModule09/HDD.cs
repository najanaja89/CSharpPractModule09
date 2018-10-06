using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    public class HDD : Storage
    {
        protected HDD():base
        {
           
        }

        public int SpindleSpeed { set; get; }

        
    }
}
