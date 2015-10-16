using System;
using NUnit.Framework;

namespace Devtech.Common.Tests.DateTimeOperationsTest
{
	[TestFixture]
	public class DatetimeToTimestampTest
	{
		[TestCase]
		public void DateTimeToTimestamp_ValidInput_ExpectedOutputReturned()
		{
			const long expected = 1444997367;
			var timestamp = DateTimeOperations.DatetimeToUnix(new DateTime(2015, 10, 16, 12, 9, 27));

			Assert.AreEqual(expected, timestamp);
		}
	}
}
