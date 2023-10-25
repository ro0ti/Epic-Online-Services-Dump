using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A2 RID: 1186
	[Token(Token = "0x20004A2")]
	public struct QueryLeaderboardDefinitionsOptions
	{
		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06001E93 RID: 7827 RVA: 0x000085AC File Offset: 0x000067AC
		// (set) Token: 0x06001E94 RID: 7828 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089A")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001E93")]
			[Address(RVA = "0x5083F0", Offset = "0x5069F0", VA = "0x1805083F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E94")]
			[Address(RVA = "0x533220", Offset = "0x531820", VA = "0x180533220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06001E95 RID: 7829 RVA: 0x000085C4 File Offset: 0x000067C4
		// (set) Token: 0x06001E96 RID: 7830 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089B")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001E95")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E96")]
			[Address(RVA = "0x4F1720", Offset = "0x4EFD20", VA = "0x1804F1720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06001E97 RID: 7831 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E98 RID: 7832 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700089C")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001E97")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E98")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
