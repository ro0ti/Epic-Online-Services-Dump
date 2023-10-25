using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037F RID: 895
	[Token(Token = "0x200037F")]
	public struct UpdateModOptions
	{
		// Token: 0x1700069B RID: 1691
		// (get) Token: 0x06001804 RID: 6148 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001805 RID: 6149 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069B")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001804")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001805")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06001806 RID: 6150 RVA: 0x00006CD4 File Offset: 0x00004ED4
		// (set) Token: 0x06001807 RID: 6151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700069C")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x6001806")]
			[Address(RVA = "0x50DAD0", Offset = "0x50C0D0", VA = "0x18050DAD0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001807")]
			[Address(RVA = "0x50DAF0", Offset = "0x50C0F0", VA = "0x18050DAF0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
