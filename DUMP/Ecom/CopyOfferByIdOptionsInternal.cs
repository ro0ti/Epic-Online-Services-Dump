using System;


namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000541 RID: 1345
	[Token(Token = "0x2000541")]
	internal struct CopyOfferByIdOptionsInternal : ISettable<CopyOfferByIdOptions>, IDisposable
	{
		// Token: 0x17000A0F RID: 2575
		// (set) Token: 0x060022C8 RID: 8904 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A0F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022C8")]
			[Address(RVA = "0x53EC60", Offset = "0x53D260", VA = "0x18053EC60")]
			set
			{
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (set) Token: 0x060022C9 RID: 8905 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A10")]
		public Utf8String OfferId
		{
			[Token(Token = "0x60022C9")]
			[Address(RVA = "0x53ECC0", Offset = "0x53D2C0", VA = "0x18053ECC0")]
			set
			{
			}
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x53EBA0", Offset = "0x53D1A0", VA = "0x18053EBA0", Slot = "4")]
		public void Set(ref CopyOfferByIdOptions other)
		{
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x53EA90", Offset = "0x53D090", VA = "0x18053EA90", Slot = "5")]
		public void Set(ref CopyOfferByIdOptions? other)
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x53EA30", Offset = "0x53D030", VA = "0x18053EA30", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F59 RID: 3929
		[Token(Token = "0x4000F59")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F5A RID: 3930
		[Token(Token = "0x4000F5A")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F5B RID: 3931
		[Token(Token = "0x4000F5B")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OfferId;
	}
}
