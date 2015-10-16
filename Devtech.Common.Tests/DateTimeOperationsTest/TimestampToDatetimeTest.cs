using System;
using NUnit.Framework;

namespace Devtech.Common.Tests.DateTimeOperationsTest
{
	[TestFixture]
	public class TimestampToDatetimeTest
	{
		[TestCase]
		public void TimeStampToDateTime_ValidInput_ExpectedOutputReturned()
		{
			var expected = new DateTime(2015, 10, 16, 12, 9, 27);
			var dateTime = DateTimeOperations.UnixToDatetime(1444997367);

			Assert.AreEqual(expected, dateTime);
		}
	}
}