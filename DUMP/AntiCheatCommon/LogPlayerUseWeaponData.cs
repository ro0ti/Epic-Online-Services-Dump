using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.AntiCheatCommon
{
	// Token: 0x020006D6 RID: 1750
	[Token(Token = "0x20006D6")]
	public struct LogPlayerUseWeaponData
	{
		// Token: 0x17000D49 RID: 3401
		// (get) Token: 0x06002CCE RID: 11470 RVA: 0x0000B744 File Offset: 0x00009944
		// (set) Token: 0x06002CCF RID: 11471 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D49")]
		public IntPtr PlayerHandle
		{
			[Token(Token = "0x6002CCE")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return 0;
			}
			[Token(Token = "0x6002CCF")]
			[Address(RVA = "0x4875D0", Offset = "0x485BD0", VA = "0x1804875D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4A RID: 3402
		// (get) Token: 0x06002CD0 RID: 11472 RVA: 0x0000B75C File Offset: 0x0000995C
		// (set) Token: 0x06002CD1 RID: 11473 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4A")]
		public Vec3f? PlayerPosition
		{
			[Token(Token = "0x6002CD0")]
			[Address(RVA = "0x4EC7F0", Offset = "0x4EADF0", VA = "0x1804EC7F0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CD1")]
			[Address(RVA = "0x575F60", Offset = "0x574560", VA = "0x180575F60")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4B RID: 3403
		// (get) Token: 0x06002CD2 RID: 11474 RVA: 0x0000B774 File Offset: 0x00009974
		// (set) Token: 0x06002CD3 RID: 11475 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4B")]
		public Quat? PlayerViewRotation
		{
			[Token(Token = "0x6002CD2")]
			[Address(RVA = "0x575E30", Offset = "0x574430", VA = "0x180575E30")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CD3")]
			[Address(RVA = "0x575F70", Offset = "0x574570", VA = "0x180575F70")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4C RID: 3404
		// (get) Token: 0x06002CD4 RID: 11476 RVA: 0x0000B78C File Offset: 0x0000998C
		// (set) Token: 0x06002CD5 RID: 11477 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4C")]
		public bool IsPlayerViewZoomed
		{
			[Token(Token = "0x6002CD4")]
			[Address(RVA = "0x4F5200", Offset = "0x4F3800", VA = "0x1804F5200")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CD5")]
			[Address(RVA = "0x4F5220", Offset = "0x4F3820", VA = "0x1804F5220")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4D RID: 3405
		// (get) Token: 0x06002CD6 RID: 11478 RVA: 0x0000B7A4 File Offset: 0x000099A4
		// (set) Token: 0x06002CD7 RID: 11479 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4D")]
		public bool IsMeleeAttack
		{
			[Token(Token = "0x6002CD6")]
			[Address(RVA = "0x4F5210", Offset = "0x4F3810", VA = "0x1804F5210")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6002CD7")]
			[Address(RVA = "0x4F5230", Offset = "0x4F3830", VA = "0x1804F5230")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000D4E RID: 3406
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002CD9 RID: 11481 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000D4E")]
		public Utf8String WeaponName
		{
			[Token(Token = "0x6002CD8")]
			[Address(RVA = "0x475020", Offset = "0x473620", VA = "0x180475020")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002CD9")]
			[Address(RVA = "0x4D5030", Offset = "0x4D3630", VA = "0x1804D5030")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002CDA")]
		[Address(RVA = "0x576EC0", Offset = "0x5754C0", VA = "0x180576EC0")]
		internal void Set(ref LogPlayerUseWeaponDataInternal other)
		{
		}
	}
}
