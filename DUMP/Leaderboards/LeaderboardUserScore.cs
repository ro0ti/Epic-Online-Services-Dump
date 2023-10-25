using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	public struct LeaderboardUserScore
	{
		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000887")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001E41")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E42")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0000845C File Offset: 0x0000665C
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000888")]
		public int Score
		{
			[Token(Token = "0x6001E43")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6001E44")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E45")]
		[Address(RVA = "0x526750", Offset = "0x524D50", VA = "0x180526750")]
		internal void Set(ref LeaderboardUserScoreInternal other)
		{
		}
	}
}
