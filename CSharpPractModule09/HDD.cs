using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    public class HDD : Storage
    {
        //GB in sec.
        protected const double SPEED = 0.06;
        protected double HddCapacity { set; get; }
        protected double HddFreeCapacity { set; get; }

        public HDD(string nameStorage, string modelStorage, double hddCapacity = 1000) : base(nameStorage, modelStorage)
        {
            //in gb.
            HddCapacity = hddCapacity;
            HddFreeCapacity = HddCapacity;
        }

        public override double GetStorageCapacity()
        {
            return HddCapacity;
        }

        public override void CopyToStorage(double info = 1)
        {
            int count = 0;
            if (info > HddCapacity)
            {
                count = (int)(info / HddCapacity) + 1;
                Console.WriteLine($"You need {count} flash drives to copy info");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
            else
            {
                HddFreeCapacity = HddCapacity - info;
                Console.WriteLine($"Copied {info} GB's");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
        }

        public override double GetStorageFreeCapacity()
        {
            return HddFreeCapacity;
        }

        public override void GetStorageInfo()
        {
            Console.WriteLine("Storage info:");
            Console.WriteLine($"storage name is {base.NameStorage}");
            Console.WriteLine($"storage model is {base.ModelStorage}");
            Console.WriteLine($"storage speed is {HDD.SPEED}");
        }
    }

}

