using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Devices
{
    public class SmartLight : Device
    {
        public int Power { get; set; }

        public SmartLight(LightType type)
        {
            if (type == LightType.Led)
            {
                Power = 150;
            }
            else if (type == LightType.Halogen)
            {
                Power = 200;
            }
        }
    }

    public enum LightType
    {
        Led,
        Halogen,
    }
}
