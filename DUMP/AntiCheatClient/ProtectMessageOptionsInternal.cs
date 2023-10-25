using System;


namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	internal struct ProtectMessageOptionsInternal : ISettable<ProtectMessageOptions>, IDisposable
	{
		// Token: 0x17000DAA RID: 3498
		// (set) Token: 0x06002E1D RID: 11805 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAA")]
		public ArraySegment<byte> Data
		{
			[Token(Token = "0x6002E1D")]
			[Address(RVA = "0x57C790", Offset = "0x57AD90", VA = "0x18057C790")]
			set
			{
			}
		}

		// Token: 0x17000DAB RID: 3499
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DAB")]
		public uint OutBufferSizeBytes
		{
			[Token(Token = "0x6002E1E")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E1F")]
		[Address(RVA = "0x57C600", Offset = "0x57AC00", VA = "0x18057C600", Slot = "4")]
		public void Set(ref ProtectMessageOptions other)
		{
		}

		// Token: 0x06002E20 RID: 11808 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E20")]
		[Address(RVA = "0x57C6A0", Offset = "0x57ACA0", VA = "0x18057C6A0", Slot = "5")]
		public void Set(ref ProtectMessageOptions? other)
		{
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E21")]
		[Address(RVA = "0x57C400", Offset = "0x57AA00", VA = "0x18057C400", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x0400147F RID: 5247
		[Token(Token = "0x400147F")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001480 RID: 5248
		[Token(Token = "0x4001480")]
		[FieldOffset(Offset = "0x4")]
		private uint m_DataLengthBytes;

		// Token: 0x04001481 RID: 5249
		[Token(Token = "0x4001481")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_Data;

		// Token: 0x04001482 RID: 5250
		[Token(Token = "0x4001482")]
		[FieldOffset(Offset = "0x10")]
		private uint m_OutBufferSizeBytes;
	}
}
