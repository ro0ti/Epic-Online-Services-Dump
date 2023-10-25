using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public struct GetExternalUserInfoCountOptions
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060003F2 RID: 1010 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003F3 RID: 1011 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003F2")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003F3")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700004E")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003F4")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003F5")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
