using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _if_DzNomber6
{
    public class SmartKettle
    {
        private bool _turnOn = false;
        private int _WaterLevel = 0;
        private string _name = "SmartKettle";


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name can't be empty");
                }
                _name = value;
            }
        }

        public int WaterLevel
        {
            get
            {
                return _WaterLevel;
            }
            set
            {
                _WaterLevel = value;
                if (!TurnOn && value > 0)
                {
                    TurnOn = !TurnOn;
                }
                
            }
        }


        public bool TurnOn
        {
            get
            {
                return _turnOn;
            }
            set
            {
                if (_turnOn == value)
                {
                    throw new InvalidOperationException("u can't turn ");
                }
                else if (value && WaterLevel == 0) 
                {
                    throw new ArgumentException("u can't turn On while Water Level = 0");
                }
                _turnOn = !_turnOn;
                Thread.Sleep(180);
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} - {(TurnOn ? $"Is on level = {WaterLevel}" : "Is off ")}");
        }

        public override string ToString()
        {
            return $"{Name} - {(TurnOn ? $"Is on level = {WaterLevel}" : "Is off ")}"; 
        }

        public SmartKettle(string name) 
        {
            Name = name;

        }
        public SmartKettle() { }
    }

}
