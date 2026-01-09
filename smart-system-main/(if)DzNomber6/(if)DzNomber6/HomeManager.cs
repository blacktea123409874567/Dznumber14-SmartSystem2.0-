using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _if_DzNomber6
{
    public class HomeManager
    {
        private SmartLamp[] SmartLamps;
        private SmartKettle[] SmartKettles;

        
        public HomeManager()
        {
            SmartLamps = new SmartLamp[]
            {
            new SmartLamp("Лампа в гостиной"),
            new SmartLamp{Name = "lamp in bedroom",lightlevel = 10},
            new SmartLamp("Лампа на кухне")
            };

            SmartKettles = new SmartKettle[]
            {
            new SmartKettle("Чайник на кухне"),
            new SmartKettle{Name = "lamp in bedroom",WaterLevel = 10},

            new SmartKettle("Чайник в спальне")
            };

            
            SmartLamps[0].Turn(true);
        }

        
        public SmartLamp FindSmartLampByName(string name)
        {
            SmartLamp foundSmartLamp = SmartLamps.SingleOrDefault(l => l.Name == name);

            if (foundSmartLamp == null)
            {
                throw new Exception($"Лампа с именем '{name}' не найдена.");
            }
            return foundSmartLamp;
        }

        public SmartKettle FindSmartKettleByName(string name)
        {
            SmartKettle foundSmartKettle = SmartKettles.SingleOrDefault(k => k.Name == name);

            if (foundSmartKettle == null)
            {
                throw new Exception($"Чайник с именем '{name}' не найден.");
            }
            return foundSmartKettle;
        }

        public void DisplayAllDevicesStatus()
        {
            Console.WriteLine("Лампы:");
            foreach (var SmartLamp in SmartLamps)
            {
                Console.WriteLine(SmartLamp);
            }

            Console.WriteLine("\nЧайники:");
            foreach (var SmartKettle in SmartKettles)
            {
                Console.WriteLine(SmartKettle);
            }
        }
    }

}
