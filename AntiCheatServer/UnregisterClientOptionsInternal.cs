using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatServer
{
	// Token: 0x020006B1 RID: 1713
	[Token(Token = "0x20006B1")]
	internal struct UnregisterClientOptionsInternal : ISettable<UnregisterClientOptions>, IDisposable
	{
		// Token: 0x17000CE1 RID: 3297
		// (set) Token: 0x06002BF7 RID: 11255 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000CE1")]
		public IntPtr ClientHandle
		{
			[Token(Token = "0x6002BF7")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06002BF8 RID: 11256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BF8")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref UnregisterClientOptions other)
		{
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BF9")]
		[Address(RVA = "0x580600", Offset = "0x57EC00", VA = "0x180580600", Slot = "5")]
		public void Set(ref UnregisterClientOptions? other)
		{
		}

		// Token: 0x06002BFA RID: 11258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002BFA")]
		[Address(RVA = "0x5805B0", Offset = "0x57EBB0", VA = "0x1805805B0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04001317 RID: 4887
		[Token(Token = "0x4001317")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04001318 RID: 4888
		[Token(Token = "0x4001318")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_ClientHandle;
	}
}
