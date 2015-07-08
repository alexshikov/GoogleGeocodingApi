using System;
using System.Linq;

namespace GoogleGeocodingApi
{
	public class GeocodingRequest
	{
		public string Address { get; set; }

		public string PlaceId { get; set; }

		public Location Location { get; set; }

		public ComponentFilter[] Components { get; set; }

		internal void Validate ()
		{
			if (!string.IsNullOrEmpty (Address) && !string.IsNullOrEmpty (PlaceId) && Location != null)
			{
				throw new InvalidOperationException ("Request must contain only one of 'Address', 'Location' or 'PlaceId'");
			}

			if (string.IsNullOrEmpty (Address) && string.IsNullOrEmpty (PlaceId) && Location == null && Components == null)
			{
				throw new InvalidOperationException ("Request must contain at least one of 'Address', 'Location', 'PlaceId' or 'Components'");
			}
		}

		internal string AddParametersToUrl (string url)
		{
			if (!string.IsNullOrEmpty (Address))
			{
				url += "&address=" + Address;
			}
			if (!string.IsNullOrEmpty (PlaceId))
			{
				url += "&place_id=" + PlaceId;
			}
			if (Components != null)
			{
				url += "&components=" + string.Join ("|", from c in Components select c.ToUrlString ());
			}
			return url;
		}
	}
}

