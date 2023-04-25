using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartCity.Devices;

namespace SmartCity
{
    public class Gateway
    {
        public string Manufacturer { get; set; }
        public string Address { get; set; }
        public List<Device> Devices { get; set; }

        public Gateway(string manufacturer, string address)
        {
            Manufacturer = manufacturer;
            Address = address;
            Devices = new List<Device>();
        }

        public void AddDevice(Device device)
        {
            if (device.Manufacturer == Manufacturer)
            {
                Devices.Add(device);
            }
            else
            {
                throw new Exception("Device and Gateway must have the same manufacturer.");
            }
        }

        public int GetDevicesAmount()
        {
            return Devices.Count;
        }

        public List<Device> GetDevicesWithErrorStatus()
        {
            return Devices.Where(d => d.Status == ConnectionStatus.Error).ToList();
        }
    }
}
