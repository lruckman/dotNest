using System.Collections.Generic;

namespace dotNest
{
    public class Structure
    {
        public Structure(dynamic structure)
        {
            Devices = new Dictionary<string, Device>();

            //todo: map the rest

            foreach (var device in structure.devices)
            {
                var deviceId = device.Split('.')[1];
                Devices.Add(deviceId, null);
            }
        }

        public IDictionary<string, Device> Devices { get; internal set; }
    }
}