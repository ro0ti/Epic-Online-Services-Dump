using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000488 RID: 1160
	[Token(Token = "0x2000488")]
	public struct Definition
	{
		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000873")]
		public Utf8String LeaderboardId
		{
			[Token(Token = "0x6001DF6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DF7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001DF9 RID: 7673 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000874")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001DF8")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DF9")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001DFA RID: 7674 RVA: 0x00008294 File Offset: 0x00006494
		// (set) Token: 0x06001DFB RID: 7675 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000875")]
		public LeaderboardAggregation Aggregation
		{
			[Token(Token = "0x6001DFA")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return LeaderboardAggregation.Min;
			}
			[Token(Token = "0x6001DFB")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001DFC RID: 7676 RVA: 0x000082AC File Offset: 0x000064AC
		// (set) Token: 0x06001DFD RID: 7677 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000876")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001DFC")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DFD")]
			[Address(RVA = "0x4F1720", Offset = "0x4EFD20", VA = "0x1804F1720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001DFE RID: 7678 RVA: 0x000082C4 File Offset: 0x000064C4
		// (set) Token: 0x06001DFF RID: 7679 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000877")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001DFE")]
			[Address(RVA = "0x5236A0", Offset = "0x521CA0", VA = "0x1805236A0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001DFF")]
			[Address(RVA = "0x5236C0", Offset = "0x521CC0", VA = "0x1805236C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E00")]
		[Address(RVA = "0x5234E0", Offset = "0x521AE0", VA = "0x1805234E0")]
		internal void Set(ref DefinitionInternal other)
		{
		}
	}
}
