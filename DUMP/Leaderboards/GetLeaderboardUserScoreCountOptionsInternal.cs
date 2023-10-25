using System;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x0200048F RID: 1167
	[Token(Token = "0x200048F")]
	internal struct GetLeaderboardUserScoreCountOptionsInternal : ISettable<GetLeaderboardUserScoreCountOptions>, IDisposable
	{
		// Token: 0x1700087E RID: 2174
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700087E")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001E17")]
			[Address(RVA = "0x523BF0", Offset = "0x5221F0", VA = "0x180523BF0")]
			set
			{
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E18")]
		[Address(RVA = "0x523AF0", Offset = "0x5220F0", VA = "0x180523AF0", Slot = "4")]
		public void Set(ref GetLeaderboardUserScoreCountOptions other)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E19")]
		[Address(RVA = "0x523B50", Offset = "0x522150", VA = "0x180523B50", Slot = "5")]
		public void Set(ref GetLeaderboardUserScoreCountOptions? other)
		{
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E1A")]
		[Address(RVA = "0x523AA0", Offset = "0x5220A0", VA = "0x180523AA0", Slot = "6")]
		public void Dispose()
		{
		}

		// Token: 0x04000D57 RID: 3415
		[Token(Token = "0x4000D57")]
		[FieldOffset(Offset = "0x0")]
		private int m_ApiVersion;

		// Token: 0x04000D58 RID: 3416
		[Token(Token = "0x4000D58")]
		[FieldOffset(Offset = "0x8")]
		private IntPtr m_StatName;
	}
}
