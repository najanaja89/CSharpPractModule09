using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule09
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string capacity;
                string menu;
                int capacityInt;
                int size = 3;
                string submenu = "";
                Flash flash = new Flash("Trancend", "ux-2100");

                Storage[] storage = new Storage[5];

                while (true)
                {
                    submenu = "";
                Console.WriteLine();
                Console.WriteLine("Choose device");
                Console.WriteLine("Press 1 to choose Flash");
                Console.WriteLine("Press 2 to choose HDD");
                Console.WriteLine("Press 3 to choose DVD 4.7");
                Console.WriteLine("Press 4 to choose DVD 9");
                Console.WriteLine("Any key to exit");

                menu = Console.ReadLine();

                    if (menu == "1")
                    {
                        submenu = "";
                        Console.WriteLine("Enter capacity of storage");
                        capacity = Console.ReadLine();
                        capacityInt = int.Parse(capacity);
                        storage[0] = new Flash("Trancend", "ux-2100", capacityInt);
                        while (submenu != "0")
                        {
                            Console.WriteLine();
                            Console.WriteLine("Press 1 to copy data to flash");
                            Console.WriteLine("Press 2 to view device info");
                            Console.WriteLine("Press 3 to view device capacity");
                            Console.WriteLine("Press 4 to view device free space");
                            Console.WriteLine("Press any key return previous menu");
                            submenu = Console.ReadLine();

                            if (submenu == "1")
                            {
                                Console.WriteLine("enter data size");
                                string info = Console.ReadLine();
                                double infoInt = int.Parse(info);
                                storage[0].CopyToStorage(infoInt);
                            }

                            else if (submenu == "2")
                            {
                                storage[0].GetStorageInfo();
                                Console.ReadLine();
                            }

                            else if (submenu == "3")
                            {
                                Console.WriteLine(storage[0].GetStorageCapacity());
                            }

                            else if (submenu == "4")
                            {
                                Console.WriteLine(storage[0].GetStorageFreeCapacity());
                            }

                            else submenu = "0";

                        }
                    }

                    else if (menu == "2")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Enter capacity of storage");
                        capacity = Console.ReadLine();
                        capacityInt = int.Parse(capacity);
                        storage[1] = new HDD("SiliconPower", "sil2110", capacityInt);
                        while (submenu != "0")
                        {
                            Console.WriteLine("Press 1 to copy data to HDD");
                            Console.WriteLine("Press 2 to view device info");
                            Console.WriteLine("Press 3 to view device capacity");
                            Console.WriteLine("Press 4 to view device free space");
                            Console.WriteLine("Press any key return previous menu");
                            submenu = Console.ReadLine();

                            if (submenu == "1")
                            {
                                Console.WriteLine("enter data size");
                                string info = Console.ReadLine();
                                double infoInt = int.Parse(info);
                                storage[1].CopyToStorage(infoInt);
                            }

                            else if (submenu == "2")
                            {
                                storage[1].GetStorageInfo();
                                Console.ReadLine();
                            }

                            else if (submenu == "3")
                            {
                                Console.WriteLine(storage[1].GetStorageCapacity());
                            }

                            else if (submenu == "4")
                            {
                                Console.WriteLine(storage[1].GetStorageFreeCapacity());
                            }

                            else submenu = "0";

                        }
                    }

                    else if (menu == "3")
                    {
                        Console.WriteLine();
                        storage[2] = new DVD("MiramaxDVD", "iso2100");
                        while (submenu != "0")
                        {
                            Console.WriteLine("Press 1 to copy data to DVD");
                            Console.WriteLine("Press 2 to view device info");
                            Console.WriteLine("Press 3 to view device capacity");
                            Console.WriteLine("Press 4 to view device free space");
                            Console.WriteLine("Press any key return previous menu");
                            submenu = Console.ReadLine();

                            if (submenu == "1")
                            {
                                Console.WriteLine("enter data size");
                                string info = Console.ReadLine();
                                double infoInt = int.Parse(info);
                                storage[2].CopyToStorage(infoInt);
                            }

                            else if (submenu == "2")
                            {
                                storage[2].GetStorageInfo();
                                Console.ReadLine();
                            }

                            else if (submenu == "3")
                            {
                                Console.WriteLine(storage[2].GetStorageCapacity());
                            }

                            else if (submenu == "4")
                            {
                                Console.WriteLine(storage[2].GetStorageFreeCapacity());
                            }

                            else submenu = "0";

                        }
                    }

                    else if (menu == "4")
                    {
                        submenu = "";
                        Console.WriteLine();
                        storage[3] = new DVD("MiramaxDVD", "iso2109", 9);
                        while (submenu != "0")
                        {
                            Console.WriteLine("Press 1 to copy data to DVD");
                            Console.WriteLine("Press 2 to view device info");
                            Console.WriteLine("Press 3 to view device capacity");
                            Console.WriteLine("Press 4 to view device free space");
                            Console.WriteLine("Press any key return previous menu");
                            submenu = Console.ReadLine();

                            if (submenu == "1")
                            {
                                Console.WriteLine("enter data size");
                                string info = Console.ReadLine();
                                double infoInt = int.Parse(info);
                                storage[3].CopyToStorage(infoInt);
                            }

                            else if (submenu == "2")
                            {
                                storage[3].GetStorageInfo();
                                Console.ReadLine();
                            }

                            else if (submenu == "3")
                            {
                                Console.WriteLine(storage[3].GetStorageCapacity());
                            }

                            else if (submenu == "4")
                            {
                                Console.WriteLine(storage[3].GetStorageFreeCapacity());
                            }

                            else submenu = "0";

                        }
                    }
                    else Environment.Exit(0);
                }
            }

            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (TypeAccessException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (RankException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
