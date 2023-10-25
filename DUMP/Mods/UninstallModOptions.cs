using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x0200037B RID: 891
	[Token(Token = "0x200037B")]
	public struct UninstallModOptions
	{
		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x060017E4 RID: 6116 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060017E5 RID: 6117 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700068E")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60017E4")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017E5")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00006C2C File Offset: 0x00004E2C
		// (set) Token: 0x060017E7 RID: 6119 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700068F")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x60017E6")]
			[Address(RVA = "0x50DAD0", Offset = "0x50C0D0", VA = "0x18050DAD0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60017E7")]
			[Address(RVA = "0x50DAF0", Offset = "0x50C0F0", VA = "0x18050DAF0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
