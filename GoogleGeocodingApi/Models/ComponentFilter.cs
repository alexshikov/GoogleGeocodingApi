using System;

namespace GoogleGeocodingApi
{
	public class ComponentFilter
	{
		public string Type { get; private set; }

		public string Value { get; set; }

		private ComponentFilter (string type, string value)
		{
			Type = type;
			Value = value;
		}

		public string ToUrlString ()
		{
			return string.Format ("{0}:{1}", Type.ToString ().ToLower (), Value);
		}

		#region Factory methods

		public static ComponentFilter Route (string route)
		{
			return new ComponentFilter ("route", route);
		}

		public static ComponentFilter Locality (string locality)
		{
			return new ComponentFilter ("locality", locality);
		}

		public static ComponentFilter AdministrativeArea (string administrativeArea)
		{
			return new ComponentFilter ("administrative_area", administrativeArea);
		}

		public static ComponentFilter PostalCode (string postalCode)
		{
			return new ComponentFilter ("postal_code", postalCode);
		}

		public static ComponentFilter Country (string country)
		{
			return new ComponentFilter ("country", country);
		}

		#endregion
	}
}

