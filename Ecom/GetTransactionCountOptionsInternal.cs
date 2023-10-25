using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Ecom
{
	// Token: 0x02000561 RID: 1377
	[Token(Token = "0x2000561")]
	internal struct GetTransactionCountOptionsInternal : ISettable<GetTransactionCountOptions>, IDisposable
	{
		// Token: 0x17000A50 RID: 2640
		// (set) Token: 0x06002386 RID: 9094 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000A50")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6002386")]
			[Address(RVA = "0x5485F0", Offset = "0x546BF0", VA = "0x1805485F0")]
			set
			{
			}
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002387")]
		[Address(RVA = "0x548590", Offset = "0x546B90", VA = "0x180548590", Slot = "4")]
		public void Set(ref GetTransactionCountOptions other)
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002388")]
		[Address(RVA = "0x5484F0", Offset = "0x546AF0", VA = "0x1805484F0", Slot = "5")]
		public void Set(ref GetTransactionCountOptions? other)
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002389")]
		[Address(RVA = "0x5484A0", Offset = "0x546AA0", VA = "0x1805484A0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000FE0 RID: 4064
		[Token(Token = "0x4000FE0")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000FE1 RID: 4065
		[Token(Token = "0x4000FE1")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
