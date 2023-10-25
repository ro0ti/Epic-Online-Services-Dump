using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public struct GetUnlockedAchievementCountOptions
	{
		// Token: 0x17000E8E RID: 3726
		// (get) Token: 0x06003062 RID: 12386 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003063 RID: 12387 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E8E")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6003062")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003063")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
