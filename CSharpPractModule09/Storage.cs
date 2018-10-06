using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    public abstract class Storage
    {
        public string NameStorage { set; get; }
        public string ModelStorage { set; get; }

        public double storageCapacity = 0;

        public abstract double GetStorageCapacity();
        public abstract void CopyToStorage();
        public abstract double GetStorageFreeCapacity();
        public abstract string GetStorageInfo();

    }
}
