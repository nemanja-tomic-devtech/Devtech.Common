using System;

namespace Devtech.Common
{
	public class Randominator
	{
		/// <summary>
		/// Forms random sequence of characters.
		/// </summary>
		/// <param name="charNum">Number of characters for the output</param>
		/// <returns>String of randomly generated characters</returns>
		public static string GetRandomSequence(int charNum)
		{
			var randominator = new Random((int)DateTime.Now.Ticks);
			var charSequence = "";
			for (var i = 0; i < charNum; i++)
			{
				var selector = randominator.Next(1, 4);
				int character;
				switch (selector)
				{
					case 1:
						character = randominator.Next(65, 91);
						charSequence += (char)character;
						break;
					case 2:
						character = randominator.Next(97, 123);
						charSequence += (char)character;
						break;
					default:
						character = randominator.Next(0, 9);
						charSequence += character.ToString();
						break;
				}
			}
			return charSequence;
		}
	}
}
