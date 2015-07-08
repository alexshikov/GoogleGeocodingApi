using System;
using System.Linq;

namespace GoogleGeocodingApi.Sample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var geocoder = new Geocoder (apiKey: null);

			var components = new ComponentFilter[] { ComponentFilter.Country ("US") };

			var request = new GeocodingRequest () {
				Address = "london",
				Components = components,
				//Location = new Location (37.785, -122.4),
			};
			var result = geocoder.GetAddressesAsync (request).Result;

			foreach (var r in result)
			{
				Console.WriteLine (r.FormattedAddress);
			}
		}
	}
}
