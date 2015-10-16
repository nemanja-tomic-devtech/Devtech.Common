using System;

namespace Devtech.Common.Encryptions
{
	public class Base64Cryptonator : ICryptonator
	{
		/// <summary>
		/// Converts provided base64-encoded string into readable value.
		/// </summary>
		/// <param name="base64Value">Base64 encoded value.</param>
		/// <returns>Decoded base64 value.</returns>
		public string Decode(string base64Value)
		{
			if (string.IsNullOrEmpty(base64Value))
				throw new ArgumentNullException("base64Value");

			var bytes = Convert.FromBase64String(base64Value);
			return System.Text.Encoding.UTF8.GetString(bytes);
		}

		/// <summary>
		/// Converts provided string into base64-encoded value.
		/// </summary>
		/// <param name="plainText">String to be encoded using base64.</param>
		/// <returns>Base64-encoded string.</returns>
		public string Encode(string plainText)
		{
			if (plainText == null)
				throw new ArgumentNullException("plainText");
			
			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(plainTextBytes);
		}
	}
}
