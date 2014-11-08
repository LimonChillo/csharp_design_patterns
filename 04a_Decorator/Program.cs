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
			try 
			{	
				File.WriteAllText("output.txt", String.Empty);
				Stream input = new EncryptInputStream( new BufferedStream(new FileStream("input.txt", FileMode.Open)));
				StreamWriter sw = new StreamWriter("output.txt", true);


				byte[] bytes = new byte[input.Length];
				int numBytesToRead = (int)input.Length;
				int numBytesRead = 0;

				Console.Write("Verschlüsselter Text: ");

				while (numBytesToRead > 0)
				{
					int n = input.Read(bytes, numBytesRead, numBytesToRead);

					for (int i = 0; i < bytes.Length; i++)
					{
						sw.Write((char)bytes[i]);
						Console.Write((char)bytes[i]); 
					}	

					numBytesRead += n;
					numBytesToRead -= n;
				}
				sw.Close ();
				input.Close();


				Console.WriteLine("\nWird in Textfile geschrieben!\nTextfile wird gelesen!");

				Console.Write("Entschlüsselter Text: ");

				Stream check = new BufferedStream(new DecryptInputStream( new FileStream("output.txt", FileMode.Open)));

				bytes = new byte[check.Length];
				numBytesToRead = (int)check.Length;
				numBytesRead = 0;
			

				while (numBytesToRead > 0)

				{
					int n = check.Read(bytes, numBytesRead, numBytesToRead);

					for (int i = 0; i < bytes.Length; i++)
					{
						Console.Write((char)bytes[i]); 
					}	


					numBytesRead += n;
					numBytesToRead -= n;
				}

				check.Close ();
			}

			catch (IOException e) 
			{
				Console.WriteLine(e.Message);
			}

		}
	}
}
