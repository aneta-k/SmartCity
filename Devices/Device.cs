using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCity.Devices
{
    public abstract class Device
    {
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
        public ConnectionStatus Status { get; set; }
        public int WarrantyMonths { get; set; }
        public string Manufacturer { get; set; }
    }

    public enum ConnectionStatus
    {
        Connected,
        Warning,
        Error,
    }
}
