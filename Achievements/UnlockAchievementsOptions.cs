using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200077B RID: 1915
	[Token(Token = "0x200077B")]
	public struct UnlockAchievementsOptions
	{
		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ED9")]
		public ProductUserId UserId
		{
			[Token(Token = "0x600314B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600314C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDA")]
		public Utf8String[] AchievementIds
		{
			[Token(Token = "0x600314D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600314E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
