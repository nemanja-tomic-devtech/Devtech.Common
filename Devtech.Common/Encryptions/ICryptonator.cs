namespace Devtech.Common.Encryptions
{
	public interface ICryptonator
	{
		string Encode(string plainText);
		string Decode(string encodedString);
	}
}