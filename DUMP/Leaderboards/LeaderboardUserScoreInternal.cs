using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000495 RID: 1173
	[Token(Token = "0x2000495")]
	internal struct LeaderboardUserScoreInternal : IGettable<LeaderboardUserScore>, ISettable<LeaderboardUserScore>, IDisposable
	{
		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x06001E46 RID: 7750 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E47 RID: 7751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000889")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001E46")]
			[Address(RVA = "0x526670", Offset = "0x524C70", VA = "0x180526670")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001E47")]
			[Address(RVA = "0x5266F0", Offset = "0x524CF0", VA = "0x1805266F0")]
			set
			{
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06001E48 RID: 7752 RVA: 0x00008474 File Offset: 0x00006674
		// (set) Token: 0x06001E49 RID: 7753 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700088A")]
		public int Score
		{
			[Token(Token = "0x6001E48")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001E49")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E4A")]
		[Address(RVA = "0x5265F0", Offset = "0x524BF0", VA = "0x1805265F0", Slot = "5")]
		public void Set(ref LeaderboardUserScore other)
		{
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E4B")]
		[Address(RVA = "0x526520", Offset = "0x524B20", VA = "0x180526520", Slot = "6")]
		public void Set(ref LeaderboardUserScore? other)
		{
		}

		// Token: 0x06001E4C RID: 7756 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E4C")]
		[Address(RVA = "0x526490", Offset = "0x524A90", VA = "0x180526490", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E4D")]
		[Address(RVA = "0x5264E0", Offset = "0x524AE0", VA = "0x1805264E0", Slot = "4")]
		public void Get(out LeaderboardUserScore output)
		{
		}

		// Token: 0x04000D7A RID: 3450
		[Token(Token = "0x4000D7A")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D7B RID: 3451
		[Token(Token = "0x4000D7B")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_UserId;

		// Token: 0x04000D7C RID: 3452
		[Token(Token = "0x4000D7C")]
		[FieldOffset(Offset = "0x10")]
		private int m_Score;
	}
}
