using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Weapon
    {
        public byte Capacitybullet { get; set; }
        public int Currentbullet { get; set; }
        public bool Firemode { get; set; }
        public Weapon(byte capacitybullet,int currentbullet,bool firemode) 
        { 
           Capacitybullet = capacitybullet;
            Currentbullet = currentbullet;
            Firemode = firemode;
        }
        public void Shoot() 
        { 
            if(Firemode==false) 
            {
               Currentbullet -= Currentbullet;
                Console.WriteLine("tekli gulle atir");
            }
            else 
            {
                Console.WriteLine("gulle  ugurla atilir");
            }
        }
        public int GetRemainBulletCount() 
        {
            return Capacitybullet- Currentbullet;
        }

        public int Reload() 
        {
            Currentbullet = Capacitybullet;
            Console.WriteLine("Daragi yeniden doldur");
            return Capacitybullet;
        }

        public  void ChangeFireMode(bool Firemode) 
        { 
            if (Firemode==false) 
            {
                Console.WriteLine("tekli gulle atilir");
            }
            else if (Firemode==true) 
            {
                Console.WriteLine("avtomatik gulle acilir");
            }
           
            
        }
    }
    
}
