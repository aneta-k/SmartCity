using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCity.Devices;

namespace SmartCity
{
    public class SmartCityManagement
    {
        public List<Gateway> Gateways { get; set; }

        public SmartCityManagement()
        {
            Gateways = new List<Gateway>();
        }

        public void AddGateway(Gateway gateway)
        {
            Gateways.Add(gateway);
        }

        public int GetTotalDevicesAmount()
        {
            return Gateways.Sum(g => g.GetDevicesAmount());
        }

        public List<Device> GetAllDevicesWithErrorStatus()
        {
            return Gateways.SelectMany(g => g.GetDevicesWithErrorStatus()).ToList();
        }
    }
}
