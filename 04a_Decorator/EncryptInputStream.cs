/*
	David Kranewitter
	Simon Hintersonnleitner
*/
using System;
using System.IO;
using System.Text;

namespace a_Decorator
{
	public class EncryptInputStream : CryptInputStream
	{
		public EncryptInputStream (Stream input):base(input)
		{
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
			var result = str.Read(buffer, offset, count);

			for (int i = 0; i < buffer.Length; i++) 
			{
				buffer[i] += 13;

				if (buffer[i] > 126)
					buffer[i] -= 94;
			}

			return result;
		}
	}
}

