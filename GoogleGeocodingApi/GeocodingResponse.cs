using System;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class GeocodingResponse
	{
		public string Status { get; set; }

		public GeocodingResult[] Results { get; set; }

		[JsonProperty ("error_message")]
		public string ErrorMessage { get; set; }

		public bool IsSuccess
		{
			get { return Status == "OK" || Status == "ZERO_RESULTS"; }
		}
	}
}

