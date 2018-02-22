using System;
using System.Net;
using System.Xml.Linq;

namespace CV01PR05
{
    public struct GPS
    {
        public double Latitude;
        public double Longitude;

        public GPS(string lat, string lng)
        {
            Latitude = double.Parse(lat);
            Longitude = double.Parse(lng);
        }

        public override string ToString()
        {
            return "{Latitude:" + Latitude + ", Longitude:" + Longitude + "}";
        }
    }

    public static class Geocoding
    {
        private const string API_KEY = "AIzaSyBna9bvscoh9OuJPHtGn56gkYbSJOQ23nU";

        public static GPS GetGPS(string address)
        {
            string requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false&key={1}", Uri.EscapeDataString(address), API_KEY);

            WebRequest request = WebRequest.Create(requestUri);
            WebResponse response = request.GetResponse();
            XDocument xdoc = XDocument.Load(response.GetResponseStream());

            XElement result = xdoc.Element("GeocodeResponse").Element("result");
            XElement locationElement = result.Element("geometry").Element("location");
            XElement lat = locationElement.Element("lat");
            XElement lng = locationElement.Element("lng");

            return new GPS(lat.Value, lng.Value);
        }
    }
}