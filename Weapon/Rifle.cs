using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon
{
    class Rifle
    {
        public int Ammo;
        public int UAmmo; 
        private int _magazine;
        public Rifle()
        {

        }
        public Rifle(int magCap, int totalAmmo, int uAmmo)
        {
            _magazine = magCap;
            Ammo = totalAmmo;
            UAmmo = uAmmo;
        }
        public int Magazine {
            get 
            {
                if (_magazine == 0)
                {
                    return -1;
                }
                return _magazine;
            }
            set
            {
                if(value<20 || value >40)
                {
                    Console.WriteLine("Magazine capacity maybe max 40,min 20");
                    return;
                }
                _magazine = value;
            } 
        }
  
        public void Shot()
        {
            for (int i = 1; i <= Ammo; i++)
            {
                if (Ammo < Magazine)
                {
                    Console.WriteLine("U don't have enought ammo.");
                    break;
                }
                if (i == Magazine && Magazine>UAmmo)
                {
                    Ammo -= (Magazine - (Magazine-UAmmo));
                }
                
            }
           
            Console.WriteLine($"Total ammo : {Ammo}");
        }  
        public void Reload()
        {
            if (Magazine >= UAmmo)
            {
                if (Magazine == UAmmo)
                {
                    Console.WriteLine("U should reload!");
                }
                else
                    Console.WriteLine($"U have still {Magazine - UAmmo} ammo in magazine.");
            }
            else Console.WriteLine("Currently used magazine ammo can not be more than capacity!");
        }
    }
}
