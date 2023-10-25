using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.P2P
{
	// Token: 0x02000360 RID: 864
	[Token(Token = "0x2000360")]
	internal struct SocketIdInternal : IGettable<SocketId>, ISettable<SocketId>, IDisposable
	{
		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600172B RID: 5931 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000656")]
		public string SocketName
		{
			[Token(Token = "0x600172A")]
			[Address(RVA = "0x51FCD0", Offset = "0x51E2D0", VA = "0x18051FCD0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600172B")]
			[Address(RVA = "0x51FD40", Offset = "0x51E340", VA = "0x18051FD40")]
			set
			{
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172C")]
		[Address(RVA = "0x51FBB0", Offset = "0x51E1B0", VA = "0x18051FBB0", Slot = "5")]
		public void Set(ref SocketId other)
		{
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172D")]
		[Address(RVA = "0x51FC20", Offset = "0x51E220", VA = "0x18051FC20", Slot = "6")]
		public void Set(ref SocketId? other)
		{
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172E")]
		[Address(RVA = "0x3D7630", Offset = "0x3D5C30", VA = "0x1803D7630", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x0600172F RID: 5935 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600172F")]
		[Address(RVA = "0x51FB90", Offset = "0x51E190", VA = "0x18051FB90", Slot = "4")]
		public void Get(out SocketId output)
		{
		}

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_SocketName;
	}
}
