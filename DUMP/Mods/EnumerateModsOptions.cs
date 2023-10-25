using System;
using System.Runtime.CompilerServices;


namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000365 RID: 869
	[Token(Token = "0x2000365")]
	public struct EnumerateModsOptions
	{
		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001751 RID: 5969 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000664")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001750")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001751")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001752 RID: 5970 RVA: 0x00006A7C File Offset: 0x00004C7C
		// (set) Token: 0x06001753 RID: 5971 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000665")]
		public ModEnumerationType Type
		{
			[Token(Token = "0x6001752")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ModEnumerationType.Installed;
			}
			[Token(Token = "0x6001753")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
