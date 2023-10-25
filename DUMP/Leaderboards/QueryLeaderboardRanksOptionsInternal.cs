using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A5 RID: 1189
	[Token(Token = "0x20004A5")]
	internal struct QueryLeaderboardRanksOptionsInternal : ISettable<QueryLeaderboardRanksOptions>, IDisposable
	{
		// Token: 0x170008A2 RID: 2210
		// (set) Token: 0x06001EA3 RID: 7843 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A2")]
		public Utf8String LeaderboardId
		{
			[Token(Token = "0x6001EA3")]
			[Address(RVA = "0x533470", Offset = "0x531A70", VA = "0x180533470")]
			set
			{
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (set) Token: 0x06001EA4 RID: 7844 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A3")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EA4")]
			[Address(RVA = "0x5334D0", Offset = "0x531AD0", VA = "0x1805334D0")]
			set
			{
			}
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EA5")]
		[Address(RVA = "0x5332A0", Offset = "0x5318A0", VA = "0x1805332A0", Slot = "4")]
		public void Set(ref QueryLeaderboardRanksOptions other)
		{
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EA6")]
		[Address(RVA = "0x533360", Offset = "0x531960", VA = "0x180533360", Slot = "5")]
		public void Set(ref QueryLeaderboardRanksOptions? other)
		{
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EA7")]
		[Address(RVA = "0x533240", Offset = "0x531840", VA = "0x180533240", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D92 RID: 3474
		[Token(Token = "0x4000D92")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D93 RID: 3475
		[Token(Token = "0x4000D93")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_LeaderboardId;

		// Token: 0x04000D94 RID: 3476
		[Token(Token = "0x4000D94")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_LocalUserId;
	}
}
