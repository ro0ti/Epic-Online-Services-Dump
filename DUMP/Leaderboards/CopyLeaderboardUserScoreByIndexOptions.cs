using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	public struct CopyLeaderboardUserScoreByIndexOptions
	{
		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x0000827C File Offset: 0x0000647C
		// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700086B")]
		public uint LeaderboardUserScoreIndex
		{
			[Token(Token = "0x6001DE4")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001DE5")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700086C")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001DE6")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DE7")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
