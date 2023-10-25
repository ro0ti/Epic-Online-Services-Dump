using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000607 RID: 1543
	[Token(Token = "0x2000607")]
	public struct ExternalAccountInfo
	{
		// Token: 0x17000B7A RID: 2938
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7A")]
		public ProductUserId ProductUserId
		{
			[Token(Token = "0x600278D")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600278E")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7B RID: 2939
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7B")]
		public Utf8String DisplayName
		{
			[Token(Token = "0x600278F")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002790")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7C RID: 2940
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x06002792 RID: 10130 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7C")]
		public Utf8String AccountId
		{
			[Token(Token = "0x6002791")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002792")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7D RID: 2941
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x0000A10C File Offset: 0x0000830C
		// (set) Token: 0x06002794 RID: 10132 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7D")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x6002793")]
			[Address(RVA = "0x4447E0", Offset = "0x442DE0", VA = "0x1804447E0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x6002794")]
			[Address(RVA = "0x444820", Offset = "0x442E20", VA = "0x180444820")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B7E RID: 2942
		// (get) Token: 0x06002795 RID: 10133 RVA: 0x0000A124 File Offset: 0x00008324
		// (set) Token: 0x06002796 RID: 10134 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B7E")]
		public DateTimeOffset? LastLoginTime
		{
			[Token(Token = "0x6002795")]
			[Address(RVA = "0x4C3390", Offset = "0x4C1990", VA = "0x1804C3390")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x6002796")]
			[Address(RVA = "0x4C33E0", Offset = "0x4C19E0", VA = "0x1804C33E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06002797 RID: 10135 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6002797")]
		[Address(RVA = "0x55A8C0", Offset = "0x558EC0", VA = "0x18055A8C0")]
		internal void Set(ref ExternalAccountInfoInternal other)
		{
		}
	}
}
