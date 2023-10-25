using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000763 RID: 1891
	[Token(Token = "0x2000763")]
	public struct OnAchievementsUnlockedCallbackV2Info : ICallbackInfo
	{
		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600308C RID: 12428 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E97")]
		public object ClientData
		{
			[Token(Token = "0x600308B")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600308C")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600308E RID: 12430 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E98")]
		public ProductUserId UserId
		{
			[Token(Token = "0x600308D")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600308E")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x0600308F RID: 12431 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06003090 RID: 12432 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E99")]
		public Utf8String AchievementId
		{
			[Token(Token = "0x600308F")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003090")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003091 RID: 12433 RVA: 0x0000C83C File Offset: 0x0000AA3C
		// (set) Token: 0x06003092 RID: 12434 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000E9A")]
		public DateTimeOffset? UnlockTime
		{
			[Token(Token = "0x6003091")]
			[Address(RVA = "0x4D4FF0", Offset = "0x4D35F0", VA = "0x1804D4FF0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6003092")]
			[Address(RVA = "0x4F1720", Offset = "0x4EFD20", VA = "0x1804F1720")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003093 RID: 12435 RVA: 0x0000C854 File Offset: 0x0000AA54
		[Token(Token = "0x6003093")]
		[Address(RVA = "0x42B2A0", Offset = "0x4298A0", VA = "0x18042B2A0", Slot = "5")]
		public Result? GetResultCode()
		{
			return null;
		}

		// Token: 0x06003094 RID: 12436 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6003094")]
		[Address(RVA = "0x589550", Offset = "0x587B50", VA = "0x180589550")]
		internal void Set(ref OnAchievementsUnlockedCallbackV2InfoInternal other)
		{
		}
	}
}
