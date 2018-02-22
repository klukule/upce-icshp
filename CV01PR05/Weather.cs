using System.IO;
using System.Net;
using System.Text;
using System.Xml;

namespace CV01PR05
{
    public static class Weather
    {
        public struct TemperatureData
        {
            public double Temperature;
            public string Units;

            public override string ToString()
            {
                return Temperature + "°" + Units;
            }
        }

        public struct WindSpeedData
        {
            public double MPS;

            public override string ToString()
            {
                return MPS + "m/s";
            }
        }

        public struct PressureData
        {
            public double Pressure;
            public string Units;

            public override string ToString()
            {
                return Pressure + Units;
            }
        }

        public static (TemperatureData, WindSpeedData, PressureData) GetWeatherData(GPS gps)
        {
            WebRequest request = WebRequest.Create($"https://api.met.no/weatherapi/locationforecast/1.9/?lat={gps.Latitude}&lon={gps.Longitude}");
            WebResponse response = request.GetResponse();
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(GetResponseString(response));
            XmlNode el = xdoc["weatherdata"]["product"].FirstChild["location"];
            XmlElement temperature = el["temperature"];
            XmlElement windSpeed = el["windSpeed"];
            XmlElement pressure = el["pressure"];

            TemperatureData tData = new TemperatureData { Temperature = double.Parse(temperature.GetAttribute("value")), Units = temperature.GetAttribute("unit")[0].ToString().ToUpper() };
            WindSpeedData wsData = new WindSpeedData { MPS = double.Parse(windSpeed.GetAttribute("mps")) };
            PressureData pData = new PressureData { Pressure = double.Parse(pressure.GetAttribute("value")), Units = pressure.GetAttribute("unit") };

            return (tData, wsData, pData);
        }

        private static string GetResponseString(WebResponse response)
        {
            using (Stream stream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                return reader.ReadToEnd();
            }
        }
    }
}