using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x02000491 RID: 1169
	[Token(Token = "0x2000491")]
	public struct LeaderboardRecord
	{
		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700087F")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x00008324 File Offset: 0x00006524
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000880")]
		public uint Rank
		{
			[Token(Token = "0x6001E1D")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6001E1E")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0000833C File Offset: 0x0000653C
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000881")]
		public int Score
		{
			[Token(Token = "0x6001E1F")]
			[Address(RVA = "0x4AF750", Offset = "0x4ADD50", VA = "0x1804AF750")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x4AF760", Offset = "0x4ADD60", VA = "0x1804AF760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000882")]
		public Utf8String UserDisplayName
		{
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001E23 RID: 7715 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001E23")]
		[Address(RVA = "0x5263F0", Offset = "0x5249F0", VA = "0x1805263F0")]
		internal void Set(ref LeaderboardRecordInternal other)
		{
		}
	}
}
