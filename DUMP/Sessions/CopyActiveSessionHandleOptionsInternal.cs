using System;


namespace Epic.OnlineServices.Sessions
{
	// Token: 0x020000FF RID: 255
	[Token(Token = "0x20000FF")]
	internal struct CopyActiveSessionHandleOptionsInternal : ISettable<CopyActiveSessionHandleOptions>, IDisposable
	{
		// Token: 0x170001B1 RID: 433
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001B1")]
		public Utf8String SessionName
		{
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x4BAD70", Offset = "0x4B9370", VA = "0x1804BAD70")]
			set
			{
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086B")]
		[Address(RVA = "0x4BAC70", Offset = "0x4B9270", VA = "0x1804BAC70", Slot = "4")]
		public void Set(ref CopyActiveSessionHandleOptions other)
		{
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086C")]
		[Address(RVA = "0x4BACD0", Offset = "0x4B92D0", VA = "0x1804BACD0", Slot = "5")]
		public void Set(ref CopyActiveSessionHandleOptions? other)
		{
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600086D")]
		[Address(RVA = "0x4BAC20", Offset = "0x4B9220", VA = "0x1804BAC20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000415 RID: 1045
		[Token(Token = "0x4000415")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000416 RID: 1046
		[Token(Token = "0x4000416")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_SessionName;
	}
}
