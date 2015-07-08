using System;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class Geometry
	{
		[JsonProperty ("bounds")]
		public Bounds Bounds { get; set; }

		[JsonProperty ("location")]
		public Location Location { get; set; }

		[JsonProperty ("location_type")]
		public LocationType LocationType { get; set; }

		[JsonProperty ("viewport")]
		public Bounds Viewport { get; set; }
	}
}

