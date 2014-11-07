/*
	David Kranewitter
	Simon Hintersonnleitner
*/
using System;
using System.IO;
using System.Text;

namespace a_Decorator
{
	public class CryptInputStream : Stream
	{
		protected Stream str;

		public CryptInputStream (Stream input):base()
		{
			str = input;
		}
			
		public override void Flush ()
		{
			throw new NotImplementedException ();
		}

		public override int Read (byte[] buffer, int offset, int count)
		{
			return 0;
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
				return str.CanRead; 
			}
		}

		public override bool CanSeek {
			get { 
				return str.CanSeek; 
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
			get
			{
				return str.Position;
			}
			set
			{
				str.Position = value;
			}
		}

		public override void Close()
		{
			str.Close();
			str.Dispose();
		}
	}
}

