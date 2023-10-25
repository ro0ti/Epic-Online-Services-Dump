using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000545 RID: 1349
	[Token(Token = "0x2000545")]
	internal struct CopyOfferImageInfoByIndexOptionsInternal : ISettable<CopyOfferImageInfoByIndexOptions>, IDisposable
	{
		// Token: 0x17000A18 RID: 2584
		// (set) Token: 0x060022DC RID: 8924 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A18")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60022DC")]
			[Address(RVA = "0x53F180", Offset = "0x53D780", VA = "0x18053F180")]
			set
			{
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (set) Token: 0x060022DD RID: 8925 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A19")]
		public Utf8String OfferId
		{
			[Token(Token = "0x60022DD")]
			[Address(RVA = "0x53F1E0", Offset = "0x53D7E0", VA = "0x18053F1E0")]
			set
			{
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (set) Token: 0x060022DE RID: 8926 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A1A")]
		public uint ImageInfoIndex
		{
			[Token(Token = "0x60022DE")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			set
			{
			}
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x53EF80", Offset = "0x53D580", VA = "0x18053EF80", Slot = "4")]
		public void Set(ref CopyOfferImageInfoByIndexOptions other)
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x53F050", Offset = "0x53D650", VA = "0x18053F050", Slot = "5")]
		public void Set(ref CopyOfferImageInfoByIndexOptions? other)
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x53EF20", Offset = "0x53D520", VA = "0x18053EF20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000F64 RID: 3940
		[Token(Token = "0x4000F64")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000F65 RID: 3941
		[Token(Token = "0x4000F65")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000F66 RID: 3942
		[Token(Token = "0x4000F66")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OfferId;

		// Token: 0x04000F67 RID: 3943
		[Token(Token = "0x4000F67")]
		[FieldOffset(Offset = "0x18")]
		private uint m_ImageInfoIndex;
	}
}
