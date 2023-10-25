using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000751 RID: 1873
	[Token(Token = "0x2000751")]
	public struct CopyUnlockedAchievementByIndexOptions
	{
		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x06002FF2 RID: 12274 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002FF3 RID: 12275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E5E")]
		public ProductUserId UserId
		{
			[Token(Token = "0x6002FF2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002FF3")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x06002FF4 RID: 12276 RVA: 0x0000C794 File Offset: 0x0000A994
		// (set) Token: 0x06002FF5 RID: 12277 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E5F")]
		public uint AchievementIndex
		{
			[Token(Token = "0x6002FF4")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return 0U;
			}
			[Token(Token = "0x6002FF5")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
