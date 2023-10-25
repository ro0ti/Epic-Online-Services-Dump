using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A4 RID: 1188
	[Token(Token = "0x20004A4")]
	public struct QueryLeaderboardRanksOptions
	{
		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06001E9F RID: 7839 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EA0 RID: 7840 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A0")]
		public Utf8String LeaderboardId
		{
			[Token(Token = "0x6001E9F")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EA0")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06001EA1 RID: 7841 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EA2 RID: 7842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A1")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EA1")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EA2")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
