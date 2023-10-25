using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A7 RID: 1191
	[Token(Token = "0x20004A7")]
	internal struct QueryLeaderboardUserScoresOptionsInternal : ISettable<QueryLeaderboardUserScoresOptions>, IDisposable
	{
		// Token: 0x170008A9 RID: 2217
		// (set) Token: 0x06001EB2 RID: 7858 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A9")]
		public ProductUserId[] UserIds
		{
			[Token(Token = "0x6001EB2")]
			[Address(RVA = "0x533AB0", Offset = "0x5320B0", VA = "0x180533AB0")]
			set
			{
			}
		}

		// Token: 0x170008AA RID: 2218
		// (set) Token: 0x06001EB3 RID: 7859 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AA")]
		public UserScoresQueryStatInfo[] StatInfo
		{
			[Token(Token = "0x6001EB3")]
			[Address(RVA = "0x533A30", Offset = "0x532030", VA = "0x180533A30")]
			set
			{
			}
		}

		// Token: 0x170008AB RID: 2219
		// (set) Token: 0x06001EB4 RID: 7860 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AB")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001EB4")]
			[Address(RVA = "0x5339C0", Offset = "0x531FC0", VA = "0x1805339C0")]
			set
			{
			}
		}

		// Token: 0x170008AC RID: 2220
		// (set) Token: 0x06001EB5 RID: 7861 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AC")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001EB5")]
			[Address(RVA = "0x5338F0", Offset = "0x531EF0", VA = "0x1805338F0")]
			set
			{
			}
		}

		// Token: 0x170008AD RID: 2221
		// (set) Token: 0x06001EB6 RID: 7862 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AD")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EB6")]
			[Address(RVA = "0x533960", Offset = "0x531F60", VA = "0x180533960")]
			set
			{
			}
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EB7")]
		[Address(RVA = "0x533790", Offset = "0x531D90", VA = "0x180533790", Slot = "4")]
		public void Set(ref QueryLeaderboardUserScoresOptions other)
		{
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EB8")]
		[Address(RVA = "0x5335A0", Offset = "0x531BA0", VA = "0x1805335A0", Slot = "5")]
		public void Set(ref QueryLeaderboardUserScoresOptions? other)
		{
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EB9")]
		[Address(RVA = "0x533530", Offset = "0x531B30", VA = "0x180533530", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D9A RID: 3482
		[Token(Token = "0x4000D9A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D9B RID: 3483
		[Token(Token = "0x4000D9B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserIds;

		// Token: 0x04000D9C RID: 3484
		[Token(Token = "0x4000D9C")]
		[FieldOffset(Offset = "0x10")]
		private uint m_UserIdsCount;

		// Token: 0x04000D9D RID: 3485
		[Token(Token = "0x4000D9D")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_StatInfo;

		// Token: 0x04000D9E RID: 3486
		[Token(Token = "0x4000D9E")]
		[FieldOffset(Offset = "0x20")]
		private uint m_StatInfoCount;

		// Token: 0x04000D9F RID: 3487
		[Token(Token = "0x4000D9F")]
		[FieldOffset(Offset = "0x28")]
		private long m_StartTime;

		// Token: 0x04000DA0 RID: 3488
		[Token(Token = "0x4000DA0")]
		[FieldOffset(Offset = "0x30")]
		private long m_EndTime;

		// Token: 0x04000DA1 RID: 3489
		[Token(Token = "0x4000DA1")]
		[FieldOffset(Offset = "0x38")]
		private IntPtr m_LocalUserId;
	}
}
