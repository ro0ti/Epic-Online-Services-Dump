using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A6 RID: 1190
	[Token(Token = "0x20004A6")]
	public struct QueryLeaderboardUserScoresOptions
	{
		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06001EA8 RID: 7848 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EA9 RID: 7849 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A4")]
		public ProductUserId[] UserIds
		{
			[Token(Token = "0x6001EA8")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EA9")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06001EAA RID: 7850 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EAB RID: 7851 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A5")]
		public UserScoresQueryStatInfo[] StatInfo
		{
			[Token(Token = "0x6001EAA")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EAB")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06001EAC RID: 7852 RVA: 0x000085DC File Offset: 0x000067DC
		// (set) Token: 0x06001EAD RID: 7853 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A6")]
		public DateTimeOffset? StartTime
		{
			[Token(Token = "0x6001EAC")]
			[Address(RVA = "0x4E4FE0", Offset = "0x4E35E0", VA = "0x1804E4FE0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EAD")]
			[Address(RVA = "0x533B70", Offset = "0x532170", VA = "0x180533B70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06001EAE RID: 7854 RVA: 0x000085F4 File Offset: 0x000067F4
		// (set) Token: 0x06001EAF RID: 7855 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A7")]
		public DateTimeOffset? EndTime
		{
			[Token(Token = "0x6001EAE")]
			[Address(RVA = "0x533B30", Offset = "0x532130", VA = "0x180533B30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EAF")]
			[Address(RVA = "0x533B50", Offset = "0x532150", VA = "0x180533B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06001EB0 RID: 7856 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EB1 RID: 7857 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008A8")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6001EB0")]
			[Address(RVA = "0x4C33D0", Offset = "0x4C19D0", VA = "0x1804C33D0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EB1")]
			[Address(RVA = "0x4C3420", Offset = "0x4C1A20", VA = "0x1804C3420")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
