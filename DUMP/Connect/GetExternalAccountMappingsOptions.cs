using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Epic.OnlineServices.Connect
{
	// Token: 0x02000609 RID: 1545
	[Token(Token = "0x2000609")]
	public struct GetExternalAccountMappingsOptions
	{
		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x060027A6 RID: 10150 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027A7 RID: 10151 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B84")]
		public ProductUserId LocalUserId
		{
			[Token(Token = "0x60027A6")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027A7")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B85 RID: 2949
		// (get) Token: 0x060027A8 RID: 10152 RVA: 0x0000A16C File Offset: 0x0000836C
		// (set) Token: 0x060027A9 RID: 10153 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B85")]
		public ExternalAccountType AccountIdType
		{
			[Token(Token = "0x60027A8")]
			[Address(RVA = "0x4875A0", Offset = "0x485BA0", VA = "0x1804875A0")]
			[CompilerGenerated]
			readonly get
			{
				return ExternalAccountType.Epic;
			}
			[Token(Token = "0x60027A9")]
			[Address(RVA = "0x4875C0", Offset = "0x485BC0", VA = "0x1804875C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000B86 RID: 2950
		// (get) Token: 0x060027AA RID: 10154 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060027AB RID: 10155 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000B86")]
		public Utf8String TargetExternalUserId
		{
			[Token(Token = "0x60027AA")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60027AB")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
