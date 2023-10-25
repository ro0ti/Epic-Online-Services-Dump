using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200055F RID: 1375
	[Token(Token = "0x200055F")]
	internal struct GetOfferItemCountOptionsInternal : ISettable<GetOfferItemCountOptions>, IDisposable
	{
		// Token: 0x17000A4D RID: 2637
		// (set) Token: 0x0600237F RID: 9087 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600237F")]
			[Address(RVA = "0x5480F0", Offset = "0x5466F0", VA = "0x1805480F0")]
			set
			{
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (set) Token: 0x06002380 RID: 9088 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4E")]
		public Utf8String OfferId
		{
			[Token(Token = "0x6002380")]
			[Address(RVA = "0x548150", Offset = "0x546750", VA = "0x180548150")]
			set
			{
			}
		}

		// Token: 0x06002381 RID: 9089 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002381")]
		[Address(RVA = "0x547F20", Offset = "0x546520", VA = "0x180547F20", Slot = "4")]
		public void Set(ref GetOfferItemCountOptions other)
		{
		}

		// Token: 0x06002382 RID: 9090 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002382")]
		[Address(RVA = "0x547FE0", Offset = "0x5465E0", VA = "0x180547FE0", Slot = "5")]
		public void Set(ref GetOfferItemCountOptions? other)
		{
		}

		// Token: 0x06002383 RID: 9091 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002383")]
		[Address(RVA = "0x547EC0", Offset = "0x5464C0", VA = "0x180547EC0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FDC RID: 4060
		[Token(Token = "0x4000FDC")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FDD RID: 4061
		[Token(Token = "0x4000FDD")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FDE RID: 4062
		[Token(Token = "0x4000FDE")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OfferId;
	}
}
