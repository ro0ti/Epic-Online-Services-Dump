using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x0200055B RID: 1371
	[Token(Token = "0x200055B")]
	internal struct GetOfferCountOptionsInternal : ISettable<GetOfferCountOptions>, IDisposable
	{
		// Token: 0x17000A46 RID: 2630
		// (set) Token: 0x0600236E RID: 9070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A46")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x600236E")]
			[Address(RVA = "0x547B70", Offset = "0x546170", VA = "0x180547B70")]
			set
			{
			}
		}

		// Token: 0x0600236F RID: 9071 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600236F")]
		[Address(RVA = "0x547B10", Offset = "0x546110", VA = "0x180547B10", Slot = "4")]
		public void Set(ref GetOfferCountOptions other)
		{
		}

		// Token: 0x06002370 RID: 9072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002370")]
		[Address(RVA = "0x547A70", Offset = "0x546070", VA = "0x180547A70", Slot = "5")]
		public void Set(ref GetOfferCountOptions? other)
		{
		}

		// Token: 0x06002371 RID: 9073 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002371")]
		[Address(RVA = "0x547A20", Offset = "0x546020", VA = "0x180547A20", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FD3 RID: 4051
		[Token(Token = "0x4000FD3")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FD4 RID: 4052
		[Token(Token = "0x4000FD4")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
