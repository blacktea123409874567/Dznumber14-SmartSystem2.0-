using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace _if_DzNomber6
{
    public class SmartLamp
    {
        private bool _turnOn = false;
        private int _lightlevel  = 0;
        private string _name = "SmartLamp";


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

        public int lightlevel
        {
            get
            {
                return _lightlevel;
            }
            set
            {
                if (!TurnOn && value > 0)
                {
                    TurnOn = !TurnOn;
                }
                _lightlevel = value;
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
                _turnOn = !_turnOn;
            }
        }

        public void Turn(bool turn) 
        {
            if (_turnOn == turn)
            {
                throw new InvalidOperationException("u can't turn ");
            }
            TurnOn = !TurnOn;
        } 

        public void DisplayInfo() 
        {
            Console.WriteLine($"{Name} - {(TurnOn ? $"Is on level = {lightlevel}" : "Is off ")}");
        }
        public override string ToString()
        {
            return $"{Name} - {(TurnOn ? $"Is on level = {lightlevel}" : "Is off ")}";
        }

        public SmartLamp(string name)
        {
            Name = name;
        }
        public SmartLamp() { }
        
    }
}
