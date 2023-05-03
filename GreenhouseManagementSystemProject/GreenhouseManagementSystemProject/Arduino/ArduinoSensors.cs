using System;
using System.IO.Ports;

namespace GreenhouseManagementSystemProject.Arduino
{
    class ArduinoSensors
    {
        static void Main(string[] args)
        {
            SerialPort port = new SerialPort("COM3", 9600); // replace "COM3" with the actual serial port of your Arduino

            port.Open();

            while (true)
            {
                string message = port.ReadLine();
                string[] values = message.Split(',');

                float temperature = float.Parse(values[0]);
                float humidity = float.Parse(values[1]);
                int soilMoisture = int.Parse(values[2]);

                Console.WriteLine("Temperature: {0} °C", temperature);
                Console.WriteLine("Humidity: {0} %", humidity);
                Console.WriteLine("Soil moisture: {0}", soilMoisture);
                Console.WriteLine();
            }
        }
    }
}