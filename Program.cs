using SmartCity.Devices;

namespace SmartCity
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SmartCityManagement Management = new();


            var wasteBin1 = new SmartWasteBin
            {
                ModelName = "WasteBin", 
                SerialNumber = "AKZ543Y",
                Status = ConnectionStatus.Error,
                Manufacturer = "XYZ",
                WarrantyMonths = 12,
                HasCompactor = true,
            };

            var LedLights1 = new SmartLight(LightType.Led)
            {
                ModelName = "LedL",
                SerialNumber = "CDS765U",
                Status = ConnectionStatus.Error,
                Manufacturer = "XYZ",
                WarrantyMonths = 12,
            };

            var LedLights2 = new SmartLight(LightType.Led)
            {
                ModelName = "LLed",
                SerialNumber = "CDS123U",
                Status = ConnectionStatus.Connected,
                Manufacturer = "XYZ",
                WarrantyMonths = 12,
            };

            var HalogenLights1 = new SmartLight(LightType.Halogen)
            {
                ModelName = "Halo",
                SerialNumber = "GTR098T",
                Status = ConnectionStatus.Error,
                Manufacturer = "ABC",
                WarrantyMonths = 12,
            };


            var Gateway1 = new Gateway("XYZ", "Poland");
            Gateway1.AddDevice(wasteBin1);
            Gateway1.AddDevice(LedLights1);
            Gateway1.AddDevice(LedLights2);
            var Gateway2 = new Gateway("ABC", "Poland");
            Gateway2.AddDevice(HalogenLights1);

            Management.AddGateway(Gateway1);
            Management.AddGateway(Gateway2);

            Console.WriteLine(Management.GetTotalDevicesAmount());
            var devicesWithError = Management.GetAllDevicesWithErrorStatus();
            foreach (var device in devicesWithError)
            {
                Console.WriteLine($"{device.ModelName}");
            }
        }
    }
}