using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200055D RID: 1373
	[Token(Token = "0x200055D")]
	internal struct GetOfferImageInfoCountOptionsInternal : ISettable<GetOfferImageInfoCountOptions>, IDisposable
	{
		// Token: 0x17000A49 RID: 2633
		// (set) Token: 0x06002376 RID: 9078 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A49")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002376")]
			[Address(RVA = "0x547E00", Offset = "0x546400", VA = "0x180547E00")]
			set
			{
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (set) Token: 0x06002377 RID: 9079 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A4A")]
		public Utf8String OfferId
		{
			[Token(Token = "0x6002377")]
			[Address(RVA = "0x547E60", Offset = "0x546460", VA = "0x180547E60")]
			set
			{
			}
		}

		// Token: 0x06002378 RID: 9080 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002378")]
		[Address(RVA = "0x547C30", Offset = "0x546230", VA = "0x180547C30", Slot = "4")]
		public void Set(ref GetOfferImageInfoCountOptions other)
		{
		}

		// Token: 0x06002379 RID: 9081 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002379")]
		[Address(RVA = "0x547CF0", Offset = "0x5462F0", VA = "0x180547CF0", Slot = "5")]
		public void Set(ref GetOfferImageInfoCountOptions? other)
		{
		}

		// Token: 0x0600237A RID: 9082 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600237A")]
		[Address(RVA = "0x547BD0", Offset = "0x5461D0", VA = "0x180547BD0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FD7 RID: 4055
		[Token(Token = "0x4000FD7")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FD8 RID: 4056
		[Token(Token = "0x4000FD8")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;

		// Token: 0x04000FD9 RID: 4057
		[Token(Token = "0x4000FD9")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_OfferId;
	}
}
