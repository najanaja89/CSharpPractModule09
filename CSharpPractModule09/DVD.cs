using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    class DVD : Storage
    {
        protected const double SPEED = 0.1032;
        protected  double DvdCapacity;
        protected double DvdFreeCapacity { set; get; }

        public DVD(string nameStorage, string modelStorage, double dvdCapacity = 4.7) : base(nameStorage, modelStorage)
        {
            DvdCapacity = dvdCapacity;
        }

        public override void CopyToStorage(double info)
        {
            int count = 0;
            if (info > DvdCapacity)
            {
                count = (int)(info / DvdCapacity) + 1;
                Console.WriteLine($"You need {count} flash drives to copy info");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
            else
            {
                DvdFreeCapacity -= DvdCapacity - info;
                Console.WriteLine($"Copied {info} GB's");
                Console.WriteLine($"Time to copy {SPEED * info} sec.");
            }
        }

        public override double GetStorageCapacity()
        {
            return DvdCapacity;
        }

        public override double GetStorageFreeCapacity()
        {
           return DvdFreeCapacity;
        }

        public override void GetStorageInfo()
        {
            Console.WriteLine("Storage info:");
            Console.WriteLine($"storage name is {base.NameStorage}");
            Console.WriteLine($"storage model is {base.ModelStorage}");
            Console.WriteLine($"storage speed is {DVD.SPEED}");
        }
    }
}
