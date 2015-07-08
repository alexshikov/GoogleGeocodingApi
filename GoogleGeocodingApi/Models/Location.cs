using System;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class Location
	{
		[JsonProperty ("lat")]
		public double Latitude { get; set; }

		[JsonProperty ("lng")]
		public double Longitude { get; set; }

		public Location ()
		{}

		public Location (double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}
	}
}

