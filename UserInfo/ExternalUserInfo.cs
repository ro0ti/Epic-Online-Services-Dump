using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	public struct ExternalUserInfo
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00002654 File Offset: 0x00000854
		// (set) Token: 0x060003DE RID: 990 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000045")]
		public ExternalAccountType AccountType
		{
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x487750", Offset = "0x485D50", VA = "0x180487750")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x487780", Offset = "0x485D80", VA = "0x180487780")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060003DF RID: 991 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000046")]
		public Utf8String AccountId
		{
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003E0")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000047")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x60003E1")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003E2")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000048")]
		public Utf8String DisplayNameSanitized
		{
			[Token(Token = "0x60003E3")]
			[Address(RVA = "0x3E4B20", Offset = "0x3E3120", VA = "0x1803E4B20")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003E4")]
			[Address(RVA = "0x488180", Offset = "0x486780", VA = "0x180488180")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003E5")]
		[Address(RVA = "0x4A4F60", Offset = "0x4A3560", VA = "0x1804A4F60")]
		internal void Set(ref ExternalUserInfoInternal other)
		{
		}
	}
}
