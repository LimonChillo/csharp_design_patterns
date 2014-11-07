/*
	David Kranewitter
	Simon Hintersonnleinter
*/
using System;
using System.IO;
using System.Text;

namespace a_Decorator
{
	public class EncryptInputStream : Stream
	{
		Stream str;

		public EncryptInputStream (Stream input):base()
		{
			str = input;
		}

		//public int Read() 
		//{
			//int c = base.Read();
			//return (c == -1 ? c : Character.toLowerCase((char)c));
		//}
		/*
		public int Read(byte[] b, int offset, int len) 
		{ 
			int result = base.Read(b, offset, len);

			for (int i = offset; i < offset+result; i++) 
			{
				//b[i] = (byte)Character.toLowerCase((char)b[i]); 
				
			}
			return result; 
		}
		*/

		#region implemented abstract members of Stream

		public override void Flush ()
		{
			throw new NotImplementedException ();
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
			var result = str.Read(buffer, offset, count);

			for (int i = 0; i < buffer.Length; i++) 
			{
				buffer[i] += 13;

				if (buffer[i] > 126)
					buffer[i] -= 94;

				Console.Write((char)(buffer[i])); 
			}

			Console.WriteLine ();

			return result;
		}

		public override long Seek (long offset, SeekOrigin origin)
		{
			throw new NotImplementedException ();
		}

		public override void SetLength (long value)
		{
			throw new NotImplementedException ();
		}

		public override void Write (byte[] buffer, int offset, int count)
		{
			throw new NotImplementedException ();
		}

		public override bool CanRead {
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool CanSeek {
			get {
				throw new NotImplementedException ();
			}
		}

		public override bool CanWrite {
			get {
				throw new NotImplementedException ();
			}
		}

		public override long Length {
			get { 
				return str.Length; 
			}
		}

		public override long Position {
			get {
				throw new NotImplementedException ();
			}
			set {
				throw new NotImplementedException ();
			}
		}

		public override void Close()
		{
			str.Close();
			str.Dispose();
		}

		#endregion
	}
}

