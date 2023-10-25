using System;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A9 RID: 1193
	[Token(Token = "0x20004A9")]
	internal struct UserScoresQueryStatInfoInternal : IGettable<UserScoresQueryStatInfo>, ISettable<UserScoresQueryStatInfo>, IDisposable
	{
		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06001EBF RID: 7871 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EC0 RID: 7872 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B0")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001EBF")]
			[Address(RVA = "0x5388C0", Offset = "0x536EC0", VA = "0x1805388C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001EC0")]
			[Address(RVA = "0x538930", Offset = "0x536F30", VA = "0x180538930")]
			set
			{
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x00008624 File Offset: 0x00006824
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008B1")]
		public LeaderboardAggregation Aggregation
		{
			[Token(Token = "0x6001EC1")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			get
			{
				return LeaderboardAggregation.Min;
			}
			[Token(Token = "0x6001EC2")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			set
			{
			}
		}

		// Token: 0x06001EC3 RID: 7875 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EC3")]
		[Address(RVA = "0x538770", Offset = "0x536D70", VA = "0x180538770", Slot = "5")]
		public void Set(ref UserScoresQueryStatInfo other)
		{
		}

		// Token: 0x06001EC4 RID: 7876 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EC4")]
		[Address(RVA = "0x5387F0", Offset = "0x536DF0", VA = "0x1805387F0", Slot = "6")]
		public void Set(ref UserScoresQueryStatInfo? other)
		{
		}

		// Token: 0x06001EC5 RID: 7877 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EC5")]
		[Address(RVA = "0x538700", Offset = "0x536D00", VA = "0x180538700", Slot = "7")]
		public void Dispose()
		{
		}

		// Token: 0x06001EC6 RID: 7878 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EC6")]
		[Address(RVA = "0x538750", Offset = "0x536D50", VA = "0x180538750", Slot = "4")]
		public void Get(out UserScoresQueryStatInfo output)
		{
		}

		// Token: 0x04000DA4 RID: 3492
		[Token(Token = "0x4000DA4")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000DA5 RID: 3493
		[Token(Token = "0x4000DA5")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_StatName;

		// Token: 0x04000DA6 RID: 3494
		[Token(Token = "0x4000DA6")]
		[FieldOffset(Offset = "0x10")]
		private LeaderboardAggregation m_Aggregation;
	}
}
