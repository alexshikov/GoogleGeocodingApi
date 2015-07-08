using System;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class GeocodingResult
	{
		[JsonProperty ("address_components")]
		public AddressComponent[] AddressComponents { get; set; }

		[JsonProperty ("formatted_address")]
		public string FormattedAddress { get; set; }

		[JsonProperty ("postcode_localities")]
		public string[] PostcodeLocalities { get; set; }

		[JsonProperty ("geometry")]
		public Geometry Geometry { get; set; }

		[JsonProperty ("types")]
		public AddressType[] Types { get; set; }

		[JsonProperty ("partial_match")]
		public bool IsPartialMatch { get; set; }

		[JsonProperty ("place_id")]
		public string PlaceId { get; set; }
	}
}

