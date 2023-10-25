using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x0200003A RID: 58
	[Token(Token = "0x200003A")]
	public struct CopyExternalUserInfoByAccountTypeOptions
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060003BC RID: 956 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000035")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060003BE RID: 958 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000036")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003BE")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003BF")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00002624 File Offset: 0x00000824
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000037")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x60003C0")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60003C1")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
