using System;
using Devtech.Common.Encryptions;
using NUnit.Framework;

namespace Devtech.Common.Tests.EncryptionsTest
{
	[TestFixture]
	public class Base64EncodeTest
	{
		[TestCase]
		public void Base64Encode_ParameterNull_ExceptionThrown()
		{
			var cryptonator = new Base64Cryptonator();
			Assert.Throws<ArgumentNullException>(() => cryptonator.Encode(null));
		}

		[TestCase]
		public void Base64Encode_ParameterEmpty_ExceptionThrown()
		{
			var cryptonator = new Base64Cryptonator();
			Assert.Throws<ArgumentNullException>(() => cryptonator.Encode(string.Empty));
		}

		[TestCase]
		public void Base64Encode_ValidInput_ExpectedResultReturned()
		{
			var cryptonator = new Base64Cryptonator();
			const string expected = "dGVzdFN0cmluZzEyMw==";
			var decoded = cryptonator.Encode("testString123");

			Assert.AreEqual(decoded, expected);
		}
	}
}
