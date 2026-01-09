using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _if_DzNomber6
{
    public class Heater:IHasDisplay
    {
        public int Power {  get; set; }
        public bool IsTurnOn { get; set;}

        public string GetStatus()
        {
            return $"Обогреватель:{(IsTurnOn ? "ВКЛ":" ВЫКЛ")}, Мощность {Power} % ";
        }
    }
}
