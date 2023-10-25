using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000366 RID: 870
	[Token(Token = "0x2000366")]
	internal struct EnumerateModsOptionsInternal : ISettable<EnumerateModsOptions>, IDisposable
	{
		// Token: 0x17000666 RID: 1638
		// (set) Token: 0x06001754 RID: 5972 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000666")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001754")]
			[Address(RVA = "0x50B890", Offset = "0x509E90", VA = "0x18050B890")]
			set
			{
			}
		}

		// Token: 0x17000667 RID: 1639
		// (set) Token: 0x06001755 RID: 5973 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000667")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x6001755")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001756")]
		[Address(RVA = "0x50B740", Offset = "0x509D40", VA = "0x18050B740", Slot = "4")]
		public void Set(ref EnumerateModsOptions other)
		{
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001757")]
		[Address(RVA = "0x50B7C0", Offset = "0x509DC0", VA = "0x18050B7C0", Slot = "5")]
		public void Set(ref EnumerateModsOptions? other)
		{
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001758")]
		[Address(RVA = "0x50B6F0", Offset = "0x509CF0", VA = "0x18050B6F0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000A64 RID: 2660
		[Token(Token = "0x4000A64")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000A65 RID: 2661
		[Token(Token = "0x4000A65")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000A66 RID: 2662
		[Token(Token = "0x4000A66")]
		[FieldOffset(Offset = "0x10")]
		private ModEnumerationType m_Type;
	}
}
