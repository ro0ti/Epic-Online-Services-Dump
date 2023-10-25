using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x0200077D RID: 1917
	[Token(Token = "0x200077D")]
	public struct UnlockedAchievement
	{
		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003154 RID: 12628 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003155 RID: 12629 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDD")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x6003154")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003155")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x06003156 RID: 12630 RVA: 0x0000CADC File Offset: 0x0000ACDC
		// (set) Token: 0x06003157 RID: 12631 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000EDE")]
		public DateTimeOffset? UnlockTime
		{
			[Token(Token = "0x6003156")]
			[Address(RVA = "0x4C33B0", Offset = "0x4C19B0", VA = "0x1804C33B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003157")]
			[Address(RVA = "0x4C3400", Offset = "0x4C1A00", VA = "0x1804C3400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003158 RID: 12632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003158")]
		[Address(RVA = "0x58CBC0", Offset = "0x58B1C0", VA = "0x18058CBC0")]
		internal void Set(ref UnlockedAchievementInternal other)
		{
		}
	}
}
