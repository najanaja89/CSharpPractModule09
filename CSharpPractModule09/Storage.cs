using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    public abstract class Storage

    {
        protected string NameStorage { set; get; }
        protected string ModelStorage { set; get; }
        public Storage(string nameStorage, string modelStorage)
        {
            NameStorage = nameStorage;
            ModelStorage = modelStorage;
        }
        public double storageCapacity = 0;

        public abstract double GetStorageCapacity();
        public abstract void CopyToStorage(double info);
        public abstract double GetStorageFreeCapacity();
        public abstract void GetStorageInfo();
        

    }
}
