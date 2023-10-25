using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A3 RID: 1187
	[Token(Token = "0x20004A3")]
	internal struct QueryLeaderboardDefinitionsOptionsInternal : ISettable<QueryLeaderboardDefinitionsOptions>, IDisposable
	{
		// Token: 0x1700089D RID: 2205
		// (set) Token: 0x06001E99 RID: 7833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089D")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001E99")]
			[Address(RVA = "0x5331B0", Offset = "0x5317B0", VA = "0x1805331B0")]
			set
			{
			}
		}

		// Token: 0x1700089E RID: 2206
		// (set) Token: 0x06001E9A RID: 7834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089E")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001E9A")]
			[Address(RVA = "0x5330E0", Offset = "0x5316E0", VA = "0x1805330E0")]
			set
			{
			}
		}

		// Token: 0x1700089F RID: 2207
		// (set) Token: 0x06001E9B RID: 7835 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089F")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001E9B")]
			[Address(RVA = "0x533150", Offset = "0x531750", VA = "0x180533150")]
			set
			{
			}
		}

		// Token: 0x06001E9C RID: 7836 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E9C")]
		[Address(RVA = "0x532F90", Offset = "0x531590", VA = "0x180532F90", Slot = "4")]
		public void Set(ref QueryLeaderboardDefinitionsOptions other)
		{
		}

		// Token: 0x06001E9D RID: 7837 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E9D")]
		[Address(RVA = "0x532DF0", Offset = "0x5313F0", VA = "0x180532DF0", Slot = "5")]
		public void Set(ref QueryLeaderboardDefinitionsOptions? other)
		{
		}

		// Token: 0x06001E9E RID: 7838 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E9E")]
		[Address(RVA = "0x532DA0", Offset = "0x5313A0", VA = "0x180532DA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D8C RID: 3468
		[Token(Token = "0x4000D8C")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D8D RID: 3469
		[Token(Token = "0x4000D8D")]
		[FieldOffset(Offset = "0x8")]
		private long m_StartTime;

		// Token: 0x04000D8E RID: 3470
		[Token(Token = "0x4000D8E")]
		[FieldOffset(Offset = "0x10")]
		private long m_EndTime;

		// Token: 0x04000D8F RID: 3471
		[Token(Token = "0x4000D8F")]
		[FieldOffset(Offset = "0x18")]
		private IntPtr m_LocalUserId;
	}
}
