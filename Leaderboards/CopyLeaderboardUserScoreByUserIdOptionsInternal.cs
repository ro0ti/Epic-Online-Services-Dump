using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000487 RID: 1159
	[Token(Token = "0x2000487")]
	internal struct CopyLeaderboardUserScoreByUserIdOptionsInternal : ISettable<CopyLeaderboardUserScoreByUserIdOptions>, IDisposable
	{
		// Token: 0x17000871 RID: 2161
		// (set) Token: 0x06001DF1 RID: 7665 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000871")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x521DF0", Offset = "0x5203F0", VA = "0x180521DF0")]
			set
			{
			}
		}

		// Token: 0x17000872 RID: 2162
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000872")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x521D90", Offset = "0x520390", VA = "0x180521D90")]
			set
			{
			}
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF3")]
		[Address(RVA = "0x521CD0", Offset = "0x5202D0", VA = "0x180521CD0", Slot = "4")]
		public void Set(ref CopyLeaderboardUserScoreByUserIdOptions other)
		{
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF4")]
		[Address(RVA = "0x521BC0", Offset = "0x5201C0", VA = "0x180521BC0", Slot = "5")]
		public void Set(ref CopyLeaderboardUserScoreByUserIdOptions? other)
		{
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001DF5")]
		[Address(RVA = "0x521B60", Offset = "0x520160", VA = "0x180521B60", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D46 RID: 3398
		[Token(Token = "0x4000D46")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D47 RID: 3399
		[Token(Token = "0x4000D47")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04000D48 RID: 3400
		[Token(Token = "0x4000D48")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_StatName;
	}
}
