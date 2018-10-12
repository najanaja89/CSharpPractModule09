using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    public class Flash : Storage
    {
        //GB in sec.
        protected const double SPEED = 0.625;
        protected double FlashCapacity { set; get; }
        protected double FlashFreeCapacity { set; get; }

        public Flash(string nameStorage, string modelStorage, double flashCapacity = 8) : base(nameStorage, modelStorage)
        {
            //in gb.
            FlashCapacity = flashCapacity;
            FlashFreeCapacity = FlashCapacity;
        }

        public override double GetStorageCapacity()
        {
            return FlashCapacity;
        }

        public override void CopyToStorage(double info = 1)
        {
            int count = 0;
            if (info > FlashCapacity)
            {
                count = (int)(info / FlashCapacity) + 1;
                Console.WriteLine($"You need {count} flash drives to copy info");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
            else
            {
                FlashFreeCapacity = FlashCapacity - info;
                Console.WriteLine($"Copied {info} GB's");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
        }

        public override double GetStorageFreeCapacity()
        {
            return FlashFreeCapacity;
        }

        public override void GetStorageInfo()
        {
            Console.WriteLine("Storage info:");
            Console.WriteLine($"storage name is {base.NameStorage}");
            Console.WriteLine($"storage model is {base.ModelStorage}");
            Console.WriteLine($"storage speed is {Flash.SPEED}");
        }
    }
}
