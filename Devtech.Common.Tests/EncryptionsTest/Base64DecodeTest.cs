using System;
using Devtech.Common.Encryptions;
using NUnit.Framework;

namespace Devtech.Common.Tests.EncryptionsTest
{
	[TestFixture]
	public class Base64DecodeTest
	{
		[TestCase]
		public void Base64Decode_ParameterNull_ExceptionThrown()
		{
			var cryptonator = new Base64Cryptonator();
			Assert.Throws<ArgumentNullException>(() => cryptonator.Decode(null));
		}

		[TestCase]
		public void Base64Decode_ParameterEmpty_ExceptionThrown()
		{
			var cryptonator = new Base64Cryptonator();
			Assert.Throws<ArgumentNullException>(() => cryptonator.Decode(string.Empty));
		}

		[TestCase]
		public void Base64Decode_ValidInput_ExpectedResultReturned()
		{
			var cryptonator = new Base64Cryptonator();
			const string expected = "testString123";
			var decoded = cryptonator.Decode("dGVzdFN0cmluZzEyMw==");

			Assert.AreEqual(decoded, expected);
		}
	}
}