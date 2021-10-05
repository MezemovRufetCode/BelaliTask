using System;

namespace Weapon
{
    class Program
    {
        static void Main(string[] args)
        {
            Rifle rf1 = new Rifle();
            Console.WriteLine("Total ammo:");
            int T_ammo = int.Parse(Console.ReadLine());
            rf1.Ammo = T_ammo;
            Console.WriteLine("Magazine capacity:");
            int cap = int.Parse(Console.ReadLine());       
            rf1.Magazine = cap;          

            if (T_ammo >= cap) {
                Console.WriteLine("Currently used magazine ammo count:");
                int usedammo = int.Parse(Console.ReadLine());
                rf1.UAmmo = usedammo;
                rf1.Reload(); 
            }     
            rf1.Shot();
        }
    }
}
