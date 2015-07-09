using System;

namespace GoogleGeocodingApi
{
	public class Bounds
	{
		public Location Northeast { get; set; }
		public Location Southwest { get; set; }

		public Location GetApproximateCenter ()
		{
			if (Northeast == null || Southwest == null) {
				return null;
			}

			double latitudeCenter = (Southwest.Latitude + Northeast.Latitude) / 2;
			double longitudeCenter;
			if (Southwest.Longitude <= Northeast.Longitude) 
			{
				longitudeCenter = (Northeast.Longitude + Southwest.Longitude) / 2;
			}
			else 
			{
				longitudeCenter = (Northeast.Longitude + 360 + Southwest.Longitude) / 2;
			}
			return new Location (latitudeCenter, longitudeCenter);
		}
	}
}

