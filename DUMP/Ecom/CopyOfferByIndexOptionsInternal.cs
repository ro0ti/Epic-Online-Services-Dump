using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000543 RID: 1347
	[Token(Token = "0x2000543")]
	internal struct CopyOfferByIndexOptionsInternal : ISettable<CopyOfferByIndexOptions>, IDisposable
	{
		// Token: 0x17000A13 RID: 2579
		// (set) Token: 0x060022D1 RID: 8913 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A13")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022D1")]
			[Address(RVA = "0x53EEC0", Offset = "0x53D4C0", VA = "0x18053EEC0")]
			set
			{
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (set) Token: 0x060022D2 RID: 8914 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A14")]
		public uint OfferIndex
		{
			[Token(Token = "0x60022D2")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x53EE40", Offset = "0x53D440", VA = "0x18053EE40", Slot = "4")]
		public void Set(ref CopyOfferByIndexOptions other)
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x53ED70", Offset = "0x53D370", VA = "0x18053ED70", Slot = "5")]
		public void Set(ref CopyOfferByIndexOptions? other)
		{
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x53ED20", Offset = "0x53D320", VA = "0x18053ED20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F5E RID: 3934
		[Token(Token = "0x4000F5E")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F5F RID: 3935
		[Token(Token = "0x4000F5F")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F60 RID: 3936
		[Token(Token = "0x4000F60")]
		[FieldOffset(Offset = "0x10")]
		private uint m_OfferIndex;
	}
}
