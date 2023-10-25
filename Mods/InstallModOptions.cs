using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.Mods
{
	// Token: 0x02000369 RID: 873
	[Token(Token = "0x2000369")]
	public struct InstallModOptions
	{
		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000671")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6001770")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001771")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00006B24 File Offset: 0x00004D24
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000672")]
		public ModIdentifier? Mod
		{
			[Token(Token = "0x6001772")]
			[Address(RVA = "0x50DAD0", Offset = "0x50C0D0", VA = "0x18050DAD0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6001773")]
			[Address(RVA = "0x50DAF0", Offset = "0x50C0F0", VA = "0x18050DAF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00006B3C File Offset: 0x00004D3C
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000673")]
		public bool RemoveAfterExit
		{
			[Token(Token = "0x6001774")]
			[Address(RVA = "0x3D4580", Offset = "0x3D2B80", VA = "0x1803D4580")]
			[CompilerGenerated]
			readonly get
			{
				return default(bool);
			}
			[Token(Token = "0x6001775")]
			[Address(RVA = "0x475030", Offset = "0x473630", VA = "0x180475030")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
