using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.AntiCheatClient
{
	// Token: 0x0200071C RID: 1820
	[Token(Token = "0x200071C")]
	internal struct UnregisterPeerOptionsInternal : ISettable<UnregisterPeerOptions>, IDisposable
	{
		// Token: 0x17000DC5 RID: 3525
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000DC5")]
		public IntPtr PeerHandle
		{
			[Token(Token = "0x6002E54")]
			[Address(RVA = "0x487590", Offset = "0x485B90", VA = "0x180487590")]
			set
			{
			}
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E55")]
		[Address(RVA = "0x4ACEA0", Offset = "0x4AB4A0", VA = "0x1804ACEA0", Slot = "4")]
		public void Set(ref UnregisterPeerOptions other)
		{
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E56")]
		[Address(RVA = "0x5806C0", Offset = "0x57ECC0", VA = "0x1805806C0", Slot = "5")]
		public void Set(ref UnregisterPeerOptions? other)
		{
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002E57")]
		[Address(RVA = "0x580670", Offset = "0x57EC70", VA = "0x180580670", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x040014A3 RID: 5283
		[Token(Token = "0x40014A3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x040014A4 RID: 5284
		[Token(Token = "0x40014A4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_PeerHandle;
	}
}
