using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Achievements
{
	// Token: 0x02000775 RID: 1909
	[Token(Token = "0x2000775")]
	public struct QueryDefinitionsOptions
	{
		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003129 RID: 12585 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600312A RID: 12586 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECB")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x6003129")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600312A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600312B RID: 12587 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600312C RID: 12588 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECC")]
		public EpicAccountId EpicUserId_DEPRECATED
		{
			[Token(Token = "0x600312B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600312C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600312D RID: 12589 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600312E RID: 12590 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000ECD")]
		public Utf8String[] HiddenAchievementIds_DEPRECATED
		{
			[Token(Token = "0x600312D")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600312E")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
