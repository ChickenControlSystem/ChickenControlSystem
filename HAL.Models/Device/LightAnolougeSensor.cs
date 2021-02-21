﻿using HAL.Models.Contract;

namespace HAL.Models.Device
{
    public class LightAnolougeSensor : ILightSensor
    {
        public byte Id { get; } = 1;
        public string Name { get; } = "Light Sensor";
    }
}