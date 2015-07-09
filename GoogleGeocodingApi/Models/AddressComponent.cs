using System;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class AddressComponent
	{
		[JsonProperty ("long_name")]
		public string LongName { get; set; }

		[JsonProperty ("short_name")]
		public string ShortName { get; set; }

		[JsonProperty ("types")]
		public AddressComponentType[] Types { get; set; }
	}
}

