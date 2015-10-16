using System;

namespace Devtech.Common
{
	public class DateTimeOperations
	{
		/// <summary>
		/// Converts unix timestamp (in seconds) to datetime object.
		/// </summary>
		/// <returns>Datetime object.</returns>
		/// <param name="timestamp">Unix timestamp in seconds.</param>
		public static DateTime UnixToDatetime(double timestamp)
		{
			var origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
			return origin.AddSeconds(timestamp);
		}

		/// <summary>
		/// Converts datetime object to unix timestamp in seconds.
		/// </summary>
		/// <returns>Unix timestamp in seconds.</returns>
		/// <param name="target">Datetime to convert.</param>
		public static long DatetimeToUnix(DateTime target)
		{
			long unixTimestamp = 0;
			if (target != DateTime.MinValue)
			{
				var date = new DateTime(1970, 1, 1, 0, 0, 0, target.Kind);
				unixTimestamp = Convert.ToInt64((target - date).TotalSeconds);
			}
			return unixTimestamp;
		}
	}
}
