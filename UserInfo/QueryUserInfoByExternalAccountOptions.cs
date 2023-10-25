using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public struct QueryUserInfoByExternalAccountOptions
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600045A RID: 1114 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006D")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600045C RID: 1116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006E")]
		public Utf8String ExternalAccountId
		{
			[Token(Token = "0x600045B")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600045C")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00002774 File Offset: 0x00000974
		// (set) Token: 0x0600045E RID: 1118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006F")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x600045D")]
			[Address(RVA = "0x3D2690", Offset = "0x3D0C90", VA = "0x1803D2690")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x600045E")]
			[Address(RVA = "0x457A40", Offset = "0x456040", VA = "0x180457A40")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
