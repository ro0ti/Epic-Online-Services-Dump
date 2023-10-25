using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Lobby
{
	// Token: 0x02000469 RID: 1129
	[Token(Token = "0x2000469")]
	internal struct QueryInvitesOptionsInternal : ISettable<QueryInvitesOptions>, IDisposable
	{
		// Token: 0x17000825 RID: 2085
		// (set) Token: 0x06001D31 RID: 7473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000825")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001D31")]
			[Address(RVA = "0x532D40", Offset = "0x531340", VA = "0x180532D40")]
			set
			{
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D32")]
		[Address(RVA = "0x532C40", Offset = "0x531240", VA = "0x180532C40", Slot = "4")]
		public void Set(ref QueryInvitesOptions other)
		{
		}

		// Token: 0x06001D33 RID: 7475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D33")]
		[Address(RVA = "0x532CA0", Offset = "0x5312A0", VA = "0x180532CA0", Slot = "5")]
		public void Set(ref QueryInvitesOptions? other)
		{
		}

		// Token: 0x06001D34 RID: 7476 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001D34")]
		[Address(RVA = "0x532BF0", Offset = "0x5311F0", VA = "0x180532BF0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000CF5 RID: 3317
		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000CF6 RID: 3318
		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LocalUserId;
	}
}
