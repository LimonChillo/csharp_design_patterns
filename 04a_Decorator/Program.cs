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
			//Stream input = new EncryptInputStream( new FileStream("test.txt", FileMode.Open));
			//Stream input = new BufferedStream(new EncryptInputStream( new FileStream("test.txt", FileMode.Open)));
			Stream input = new EncryptInputStream( new BufferedStream(new FileStream("input.txt", FileMode.Open)));

			byte[] bytes = new byte[input.Length];
			int numBytesToRead = (int)input.Length;
			int numBytesRead = 0;

			try 
			{
				while (numBytesToRead > 0)

				{
					int n = input.Read(bytes, numBytesRead, numBytesToRead);

					for (int i = 0; i < bytes.Length; i++)
						Console.Write((char)bytes[i]); 
						
					// Break when the end of the file is reached.
					//if (n == 0)
					//	break;

					numBytesRead += n;
					numBytesToRead -= n;
				}
			}

			catch (IOException e) 
			{
				Console.WriteLine(e.Message);
			}
			input.Close();
		}
	}
}
