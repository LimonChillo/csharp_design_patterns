/*
	David Kranewitter
	Simon Hintersonnleitner
*/

using System;
using System.IO;
using System.Text;

namespace a_Decorator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			EncryptInputStream input = new EncryptInputStream( new FileStream("test.txt", FileMode.Open));

			byte[] bytes = new byte[input.Length];
			int numBytesToRead = (int)input.Length;
			int numBytesRead = 0;

			try 
			{
				while (numBytesToRead > 0)

				{
					// Read may return anything from 0 to numBytesToRead.
					int n = input.Read(bytes, numBytesRead, numBytesToRead);

					for (int i = 0; i < bytes.Length; i++)
						Console.Write((char)bytes[i]); 

					//Console.Write(n);

					// Break when the end of the file is reached.
					if (n == 0)
						break;

					numBytesRead += n;
					numBytesToRead -= n;
				}
			}
			//new BufferedInputStream()


			catch (IOException e) 
			{
				Console.WriteLine(e.Message);
			}
			input.Close();
		}
	}
}
