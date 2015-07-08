using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;

namespace GoogleGeocodingApi
{
	public class Geocoder
	{
		private const string BaseUrl = "http://maps.googleapis.com/maps/api/geocode/json";

		private HttpClient httpClient;
		private string apiKey;

		public Geocoder (string apiKey)
			: this (apiKey, new HttpClient ())
		{
		}

		public Geocoder (string apiKey, HttpClient httpClient)
		{
			this.httpClient = httpClient;
			this.apiKey = apiKey;
		}

		public Task<GeocodingResult[]> GetAddressesAsync (string address)
		{
			return GetAddressesAsync (new GeocodingRequest () { Address = address });
		}

		public async Task<GeocodingResult[]> GetAddressesAsync (GeocodingRequest request)
		{
			request.Validate ();

			var path = Uri.EscapeUriString (BuildUrl (request));

			var json = await httpClient.GetStringAsync (path);

			var response = JsonConvert.DeserializeObject<GeocodingResponse> (json);

			if (response.IsSuccess)
			{
				return response.Results;
			}

			throw new InvalidOperationException (string.Format ("Google Geocoding error [code: {0}]: {1}", response.Status, response.ErrorMessage));
		}

		private string BuildUrl (GeocodingRequest request)
		{
			var path = BaseUrl + "?language=en";
			if (!string.IsNullOrEmpty (apiKey))
			{
				path += "&key=" + apiKey;
			}
			return request.AddParametersToUrl (path);
		}
	}
}

