using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Leaderboards
{
	// Token: 0x020004A8 RID: 1192
	[Token(Token = "0x20004A8")]
	public struct UserScoresQueryStatInfo
	{
		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06001EBA RID: 7866 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001EBB RID: 7867 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AE")]
		public Utf8String StatName
		{
			[Token(Token = "0x6001EBA")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001EBB")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0000860C File Offset: 0x0000680C
		// (set) Token: 0x06001EBD RID: 7869 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170008AF")]
		public LeaderboardAggregation Aggregation
		{
			[Token(Token = "0x6001EBC")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return LeaderboardAggregation.Min;
			}
			[Token(Token = "0x6001EBD")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001EBE")]
		[Address(RVA = "0x538990", Offset = "0x536F90", VA = "0x180538990")]
		internal void Set(ref UserScoresQueryStatInfoInternal other)
		{
		}
	}
}
