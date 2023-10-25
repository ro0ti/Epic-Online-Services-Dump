using System;
using System.Runtime.CompilerServices;
// Dumped by ro0ti

namespace Epic.OnlineServices.UserInfo
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public struct CopyExternalUserInfoByAccountIdOptions
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002F")]
		public EpicAccountId LocalUserId
		{
			[Token(Token = "0x60003B0")]
			[Address(RVA = "0x4875B0", Offset = "0x485BB0", VA = "0x1804875B0")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003B1")]
			[Address(RVA = "0x4881A0", Offset = "0x4867A0", VA = "0x1804881A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000030")]
		public EpicAccountId TargetUserId
		{
			[Token(Token = "0x60003B2")]
			[Address(RVA = "0x487730", Offset = "0x485D30", VA = "0x180487730")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003B3")]
			[Address(RVA = "0x487760", Offset = "0x485D60", VA = "0x180487760")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x000020DE File Offset: 0x000002DE
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000031")]
		public Utf8String AccountId
		{
			[Token(Token = "0x60003B4")]
			[Address(RVA = "0x444710", Offset = "0x442D10", VA = "0x180444710")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x60003B5")]
			[Address(RVA = "0x4447F0", Offset = "0x442DF0", VA = "0x1804447F0")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
